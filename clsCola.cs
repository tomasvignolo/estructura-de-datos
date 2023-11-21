using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVignoloTp1
{
    internal class clsCola
    {
        #region Nodos
        public clsNodo Primero;
        public clsNodo Ultimo;
        #endregion

        #region Métodos
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;

            }
        }

        //Procedimiento para mostrar en el listview y en el datagridview.
        public void Recorrer(DataGridView dgvGrilla, ListBox lstLista)
        {
            clsNodo aux = Primero;
            dgvGrilla.Rows.Clear();
            lstLista.Items.Clear();
            while (aux != null)
            {
                dgvGrilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                lstLista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }

        }

        //public void Recorrer(ComboBox combo)
        //{
        //    clsNodo Aux = Primero;
        //    combo.Items.Clear();
        //    while (Aux != null)
        //    {
        //        combo.Items.Add(Aux.Codigo + " " + Aux.Nombre + " " + Aux.Tramite);
        //        Aux = Aux.Siguiente;
        //    }
        //}
        #endregion
    }
}
