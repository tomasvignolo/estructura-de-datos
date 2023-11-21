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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble clsListaDoble = new clsListaDoble();


        private void frmListaDoble_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            clsListaDoble.Agregar(ObjNodo);
            clsListaDoble.Recorrer(dgvListaDoble, lstListaDoble);
           
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsListaDoble.Primero != null)
            {
                clsListaDoble.Eliminar(Convert.ToInt32(cmbCodigo.SelectedItem));
                if (rdbAsc.Checked == true)
                {
                    clsListaDoble.Recorrer(dgvListaDoble, lstListaDoble);
                    clsListaDoble.Recorrer(cmbCodigo);

                }
                else
                {
                    clsListaDoble.RecorrerDes(dgvListaDoble);
                    clsListaDoble.RecorrerDes(lstListaDoble);
                    clsListaDoble.RecorrerDes(cmbCodigo);
                }

            }
            else
            {
                MessageBox.Show("Lista vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Control()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            Control();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            Control();
        }

        private void txtTram_TextChanged(object sender, EventArgs e)
        {
            Control();
        }

        private void cboAscendente_CheckedChanged(object sender, EventArgs e)
        {
            clsListaDoble.Recorrer(dgvListaDoble, lstListaDoble);
            clsListaDoble.Recorrer(cmbCodigo);
        }

        private void rdbDes_CheckedChanged(object sender, EventArgs e)
        {
            clsListaDoble.RecorrerDes(dgvListaDoble);
            clsListaDoble.RecorrerDes(lstListaDoble);
        }
    }
}
