using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVignoloTp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador Datos = new frmDatosDesarrollador();
            Datos.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila = new frmPila();
            pila.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.ShowDialog();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple simple = new frmListaSimple();
            simple.ShowDialog();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble doble = new frmListaDoble();
            doble.ShowDialog(); 
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario arbol = new frmArbolBinario();
            arbol.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos BaseDatos = new frmBaseDeDatos();
            BaseDatos.ShowDialog();
        }

        private void tuMamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sQLPorComboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCombo SqlCombo = new frmConsultaCombo();
            SqlCombo.ShowDialog(); 
        }

        private void sQLPorTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSQL SqlTexto = new frmConsultaSQL();
            SqlTexto.ShowDialog();
        }
    }
}
