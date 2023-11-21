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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila clsPila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo Nodo = new clsNodo();
                Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                Nodo.Nombre = txtNombre.Text;
                Nodo.Tramite = txtTramite.Text;

                //Procedimientos para mostrar
                clsPila.Agregar(Nodo);
                clsPila.Recorrer(dgvPila, lstPila);
                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Llene todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmPila_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clsPila.Primero != null)
            {
                txtCodigoRO.Text = clsPila.Primero.Codigo.ToString();
                txtNombreRO.Text = clsPila.Primero.Nombre;
                txtTramiteRO.Text = clsPila.Primero.Tramite;
                clsPila.Eliminar();
                clsPila.Recorrer(dgvPila, lstPila);
            }
            else
            {
                MessageBox.Show("No hay datos en la cola", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ValidarCampos()
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtTramite.Text))
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
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

        private void grbListado_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }
}
