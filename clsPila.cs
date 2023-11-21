using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVignoloTp1
{
    internal class clsPila
    {
        #region Nodos
        public clsNodo Primero;
        #endregion

        #region Métodos
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }

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
        #endregion
    }
}
