﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryVignoloTp1
{
    internal class clsArbolBinario
    {
        #region Nodos
        private clsNodo Inicio;

        public clsNodo Primero;
        public clsNodo Ultimo;

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }
        #endregion

        #region Agregar y Eliminar 
        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo Padre = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    Padre = aux;
                    if (Nuevo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierdo;
                    }
                    else
                    {
                        aux = aux.Derecho;
                    }
                }
                if (Nuevo.Codigo < Padre.Codigo)
                {
                    Padre.Izquierdo = Nuevo;
                }
                else
                {
                    Padre.Derecho = Nuevo;
                }

            }

        }

        public void Eliminar(Int32 Codigo)
        {
            clsNodo aux = Raiz;
            clsNodo ant = Raiz;
            while (aux != null && aux.Codigo != Codigo)
            {
                ant = aux;
                if (Codigo < aux.Codigo)
                {
                    aux = aux.Izquierdo;
                }
                else
                {
                    aux = aux.Derecho;
                }
            }
            if (aux != null && aux.Izquierdo == null && aux.Derecho == null)
            {
                if (Codigo < ant.Codigo)
                {
                    ant.Izquierdo = null;
                }
                else
                {
                    ant.Derecho = null;
                }
            }
            else
            {
                if (aux != null)
                {
                    if (aux.Izquierdo == null)
                    {
                        if (Codigo < ant.Codigo)
                        {
                            ant.Izquierdo = aux.Derecho;
                        }
                        else
                        {
                            ant.Derecho = aux.Derecho;
                        }
                    }

                }
                else
                {
                    if (aux != null)
                    {
                        if (aux.Derecho == null)
                        {
                            if (Codigo < ant.Codigo)
                            {
                                ant.Izquierdo = aux.Izquierdo;
                            }
                            else
                            {
                                ant.Derecho = aux.Izquierdo;
                            }

                        }

                    }
                    else
                    {
                        clsNodo aux2 = aux.Derecho;
                        clsNodo ant2 = aux.Derecho;
                        while (aux2.Izquierdo != null)
                        {
                            ant2 = aux2;
                            aux2 = aux2.Izquierdo;
                        }
                        aux.Codigo = aux2.Codigo;
                        aux.Nombre = aux2.Nombre;
                        aux.Tramite = aux2.Tramite;
                        if (aux2.Derecho == null)
                        {
                            ant2.Izquierdo = null;
                        }
                        else
                        {
                            ant2.Izquierdo = aux2.Derecho;
                        }
                    }
                }
            }
        }

        
        #endregion

        #region Recorrer y order para cbo, lst, dgv y archivo(ASCENDENTE)

        #region ListBox

        #region Recorrer  
        //Recorrer in order, pre order, post order en Lista
        public void RecorrerInOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            InOrderAsc(lstLista, Raiz);
        }
        public void RecorrerPreOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            PreOrderAsc(lstLista, Raiz);
        }
        public void RecorrerPostOrder(ListBox lstLista)
        {
            lstLista.Items.Clear();
            PostOrderAsc(lstLista, Raiz);
        }
        #endregion

        private void InOrderAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrderAsc(lst, R.Derecho);

        }

        private void PreOrderAsc(ListBox lst, clsNodo R)
        {
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderAsc(lst, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(lst, R.Derecho);
        }

        private void PostOrderAsc(ListBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(lst, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(lst, R.Derecho);
            lst.Items.Add(R.Codigo);

        }
        #endregion

        #region ComboBox

        #region Recorrer
        //Recorrer in order, pre order, post order en ComboBox
        public void RecorrerInOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            InOrderAsc(cbo, Raiz);


        }
        public void RecorrerPreOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            PreOrderAsc(cbo, Raiz);

        }
        public void RecorrerPostOrder(ComboBox cbo)
        {
            cbo.Items.Clear();
            PostOrderAsc(cbo, Raiz);
        }
        #endregion

        private void InOrderAsc(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(cbo, R.Izquierdo);
            cbo.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrderAsc(cbo, R.Derecho);
        }

        private void PreOrderAsc(ComboBox cbo, clsNodo R)
        {
            cbo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrderAsc(cbo, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(cbo, R.Derecho);
        }

        private void PostOrderAsc(ComboBox cbo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(cbo, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(cbo, R.Derecho);
            cbo.Items.Add(R.Codigo);
        }
        #endregion

        #region DataGridView

        #region Recorrer
        public void RecorrerInOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrderAsc(dgv, Raiz);


        }
        public void RecorrerPreOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PreOrderAsc(dgv, Raiz);

        }
        public void RecorrerPostOrder(DataGridView dgv)
        {
            dgv.Rows.Clear();
            PostOrderAsc(dgv, Raiz);
        }
        #endregion
        //Recorrer in order, pre order, post order en DataGridView
        private void InOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrderAsc(dgv, R.Derecho);

        }
        private void PreOrderAsc(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrderAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(dgv, R.Derecho);
        }

        private void PostOrderAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(dgv, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

        }
        #endregion

        #region StreamWriter

        #region Recorrer
        //Recorrer in order, pre order, post order en StreamWriter
        public void RecorrerInOrder(StreamWriter archivo)
        {
            archivo.WriteLine();
            InOrderAsc(archivo, Raiz);
        }

        public void RecorrerPreOrder(StreamWriter archivo)
        {
            archivo.WriteLine();
            PreOrderAsc(archivo, Raiz);
        }

        public void RecorrerPostOrder(StreamWriter archivo)
        {
            archivo.WriteLine();
            PostOrderAsc(archivo, Raiz);
        }
        #endregion
        private void InOrderAsc(StreamWriter archivo, clsNodo R)
        {
            if (R.Izquierdo != null) InOrderAsc(archivo, R.Izquierdo);
            archivo.Write(R.Codigo + "\n");
            if (R.Derecho != null) InOrderAsc(archivo, R.Derecho);
        }

        private void PreOrderAsc(StreamWriter archivo, clsNodo R)
        {
            archivo.Write(R.Codigo + "\n");
            if (R.Izquierdo != null) PreOrderAsc(archivo, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(archivo, R.Derecho);
        }

        private void PostOrderAsc(StreamWriter archivo, clsNodo R)
        {
            if (R.Izquierdo != null) PostOrderAsc(archivo, R.Izquierdo);
            if (R.Derecho != null) PostOrderAsc(archivo, R.Derecho);
            archivo.Write(R.Codigo + "\n");
        }
        #endregion

        #region TreeView

        #region Recorrer
       
        public void RecorrerPreOrder(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            PreOrderAsc(Arbol.Nodes, Raiz);
        }

      
        #endregion

        //Recorrer pre orden tree view

        private void PreOrderAsc(TreeNodeCollection NodoPadre, clsNodo R)
        {
            TreeNode NuevoNodo = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) PreOrderAsc(NuevoNodo.Nodes, R.Izquierdo);
            if (R.Derecho != null) PreOrderAsc(NuevoNodo.Nodes, R.Derecho);
        }
        #endregion

        #endregion

        #region Recorrer y order para cbo, lst, dgv y archivo(DESCENDENTE)

        #region ListBox

        //Recorrer in order, pre order, post order en Lista
        #region Recorrer
        public void RecorrerInOrderDes(ListBox lstLista)
        {
            lstLista.Items.Clear();
            InOrderDes(lstLista, Raiz);
        }
        #endregion

        private void InOrderDes(ListBox lst, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(lst, R.Derecho);
            lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrderDes(lst, R.Izquierdo);
        }

        #endregion

        #region ComboBox
        //Recorrer in order, pre order, post order en ComboBox
        
        public void RecorrerInOrderDes(ComboBox cbo)
        {
            cbo.Items.Clear();
            InOrderDes(cbo, Raiz);
        }

        private void InOrderDes(ComboBox cbo, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(cbo, R.Derecho);
            cbo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) InOrderDes(cbo, R.Izquierdo);
        }
        #endregion

        #region DataGridView

        //Recorrer in order, pre order, post order en DataGridView

        #region Recorrer
        public void RecorrerInOrderDes(DataGridView dgv)
        {
            dgv.Rows.Clear();
            InOrderDes(dgv, Raiz);
        }
        #endregion

        private void InOrderDes(DataGridView dgv, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo);
            if (R.Izquierdo != null) InOrderDes(dgv, R.Izquierdo);
        }
        #endregion

        #region sw

        #region Recorrer
        public void RecorrerInOrderDes(StreamWriter archivo)
        {
            archivo.WriteLine();
            InOrderDes(archivo, Raiz);


        }
        public void RecorrerPreOrderDes(StreamWriter archivo)
        {
            archivo.WriteLine();
            PreOrderDes(archivo, Raiz);

        }
        public void RecorrerPostOrderDes(StreamWriter archivo)
        {
            archivo.WriteLine();
            PostOrderDes(archivo, Raiz);
        }
        #endregion

        private void InOrderDes(StreamWriter archivo, clsNodo R)
        {
            if (R.Derecho != null) InOrderDes(archivo, R.Derecho);
            archivo.Write(R.Codigo);
            if (R.Izquierdo != null) InOrderDes(archivo, R.Izquierdo);
        }

        private void PreOrderDes(StreamWriter archivo, clsNodo R)
        {
            archivo.Write(R.Codigo);
            if (R.Derecho != null) PreOrderDes(archivo, R.Derecho);
            if (R.Izquierdo != null) PreOrderDes(archivo, R.Izquierdo);
        }

        private void PostOrderDes(StreamWriter archivo, clsNodo R)
        {
            if (R.Derecho != null) PostOrderDes(archivo, R.Derecho);
            if (R.Izquierdo != null) PostOrderDes(archivo, R.Izquierdo);
            archivo.Write(R.Codigo);
        }
        #endregion
        #endregion

        #region Equilibrar

        private clsNodo[] vecEquilibrar = new clsNodo[100];
        private Int32 ind = 0;

        private void CargarVectorInOrder(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrder(NodoPadre.Izquierdo);
            }
            vecEquilibrar[ind] = NodoPadre;
            ind++;
            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrder(NodoPadre.Derecho);
            }
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(vecEquilibrar[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void Equilibrar()
        {
            ind = 0;
            CargarVectorInOrder(Raiz);
            Raiz = null;
            EquilibrarArbol(0, ind - 1);

        }
        #endregion

        #region Buscar Nodo

        public clsNodo BuscarNodo(Int32 Codigo)
        {
            clsNodo NodoPadre = Raiz;
            while (NodoPadre != null)
            {
                if (NodoPadre.Codigo == Codigo)
                {
                    return NodoPadre;
                }
                else
                {
                    if (Codigo < NodoPadre.Codigo)
                    {
                        NodoPadre = NodoPadre.Izquierdo;
                    }
                    else
                    {
                        NodoPadre = NodoPadre.Derecho;
                    }
                }
            }
            return null;
        }
        #endregion

    }
}
