using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryVignoloTp1
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario clsArbolBinario = new clsArbolBinario();

        #region Frm
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            txtCodigo.Select();
            btnAgregar.Enabled = false;
            rdbAsc.Checked = true;
            btnEliminar.Enabled = true;
        }
        #endregion

        #region BtnAgregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                clsNodo clsNodo = new clsNodo();
                clsNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                clsNodo.Nombre = (txtNombre.Text);
                clsNodo.Tramite = (txtTramite.Text);

                clsArbolBinario.Agregar(clsNodo);
                clsArbolBinario.RecorrerInOrder(dgvArbolBinario);
                clsArbolBinario.RecorrerInOrder(lstArbolBinario);
                clsArbolBinario.RecorrerInOrder(cmbCodigo);
                clsArbolBinario.RecorrerPreOrder(trvArbolBinario);
                if (clsArbolBinario.Raiz == null)
                {
                    btnEliminar.Enabled = true; // Habilitar el botón eliminar
                }
            }
        }
        #endregion

        #region BtnEliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                if (clsArbolBinario.Raiz != null)
                {
                    clsArbolBinario.Eliminar(Convert.ToInt32(cmbCodigo.SelectedItem.ToString()));
                    if (rdbAsc.Checked == true)
                    {
                        clsArbolBinario.RecorrerInOrder(dgvArbolBinario);
                        clsArbolBinario.RecorrerInOrder(lstArbolBinario);
                        clsArbolBinario.RecorrerInOrder(cmbCodigo);
                        clsArbolBinario.RecorrerPreOrder(trvArbolBinario);

                    }

                    else
                    {
                        clsArbolBinario.RecorrerInOrderDes(dgvArbolBinario);
                        clsArbolBinario.RecorrerInOrderDes(lstArbolBinario);
                        clsArbolBinario.RecorrerInOrderDes(cmbCodigo);
                    }
                    cmbCodigo.Text = "";


                }
                else
                {
                    MessageBox.Show("Lista vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region BtnBuscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 codigo = Convert.ToInt32(cmbCodigo.SelectedItem);
            clsNodo nodo = clsArbolBinario.BuscarNodo(codigo);
            if (nodo != null)
            {
                // Mostrar los datos del nodo encontrado
                txtCodigoBUS.Text = nodo.Codigo.ToString();
                txtNombreBUS.Text = nodo.Nombre;
                txtTramiteBUS.Text = nodo.Tramite;
            }
            else
            {
                MessageBox.Show("No se encontró el nodo con código " + codigo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region BtnEquilibrar
        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            //Llamar al metodo equilibrar para que se equilibre el arbol
            clsArbolBinario.Equilibrar();
            //Mostrar el arbol equilibrado en el datagridview y en el listbox y en el combobox y en el treeview
            clsArbolBinario.RecorrerInOrder(dgvArbolBinario);
            clsArbolBinario.RecorrerInOrder(lstArbolBinario);
            clsArbolBinario.RecorrerInOrder(cmbCodigo);
            clsArbolBinario.RecorrerPreOrder(trvArbolBinario);
        }
        #endregion

        #region Validación
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Focus();
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
        #endregion

        #region Solo números
        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }
        #endregion

        #region BtnExportar
        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Crear una tabla temporal para contener los datos del DataGridView
            DataTable tabla = new DataTable();
            foreach (DataGridViewColumn columna in dgvArbolBinario.Columns)
            {
                tabla.Columns.Add(columna.HeaderText, typeof(string));
            }
            foreach (DataGridViewRow fila in dgvArbolBinario.Rows)
            {
                DataRow nuevaFila = tabla.NewRow();
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    nuevaFila[celda.ColumnIndex] = celda.Value;
                }
                tabla.Rows.Add(nuevaFila);
            }

            // Mostrar diálogo para seleccionar la ubicación y el nombre del archivo CSV
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Exportar la tabla a un archivo CSV
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                foreach (DataColumn columna in tabla.Columns)
                {
                    streamWriter.Write(columna.ColumnName + ",");
                }
                streamWriter.WriteLine();
                foreach (DataRow fila in tabla.Rows)
                {
                    for (int i = 0; i < tabla.Columns.Count; i++)
                    {
                        streamWriter.Write(fila[i].ToString() + ", ");
                    }
                    streamWriter.WriteLine();
                }
                streamWriter.Close();
            }
        }
        #endregion

        #region BtnLimpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiar todo el formulario
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigoBUS.Text = "";
            txtNombreBUS.Text = "";
            txtTramiteBUS.Text = "";
            cmbCodigo.Text = "";
            dgvArbolBinario.Rows.Clear();
            lstArbolBinario.Items.Clear();
            cmbCodigo.Items.Clear();
            trvArbolBinario.Nodes.Clear();
            clsArbolBinario.Raiz = null;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            rdbAsc.Checked = true;
            txtCodigo.Focus();
        }
        #endregion

        #region Recoridos
        private void rdbInOrder_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbAsc.Checked == true)
            {
                clsArbolBinario.RecorrerInOrder(dgvArbolBinario);
                clsArbolBinario.RecorrerInOrder(lstArbolBinario);
                clsArbolBinario.RecorrerInOrder(cmbCodigo);
                trvArbolBinario.Nodes.Clear();
            }
            if(rdbDes.Checked == true)
            {
                clsArbolBinario.RecorrerInOrder(dgvArbolBinario);
                clsArbolBinario.RecorrerInOrder(lstArbolBinario);
                clsArbolBinario.RecorrerInOrder(cmbCodigo);
            }
           
        }

        private void rdbPreOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsc.Checked == true)
            {
                clsArbolBinario.RecorrerPreOrder(dgvArbolBinario);
                clsArbolBinario.RecorrerPreOrder(cmbCodigo);
                clsArbolBinario.RecorrerPreOrder(lstArbolBinario);
                clsArbolBinario.RecorrerPreOrder(trvArbolBinario);
            }
            if (rdbDes.Checked == true)
            {
                clsArbolBinario.RecorrerPreOrder(dgvArbolBinario);
                clsArbolBinario.RecorrerPreOrder(cmbCodigo);
                clsArbolBinario.RecorrerPreOrder(lstArbolBinario);
                clsArbolBinario.RecorrerPreOrder(trvArbolBinario);
            }
        }

        private void rdbPostOrder_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbAsc.Checked == true)
            {
                clsArbolBinario.RecorrerPostOrder(dgvArbolBinario);
                clsArbolBinario.RecorrerPostOrder(lstArbolBinario);
                clsArbolBinario.RecorrerPostOrder(cmbCodigo);
                trvArbolBinario.Nodes.Clear();
            }
            if(rdbDes.Checked == true)
            {
                clsArbolBinario.RecorrerPostOrder(dgvArbolBinario);
                clsArbolBinario.RecorrerPostOrder(lstArbolBinario);
                clsArbolBinario.RecorrerPostOrder(cmbCodigo);

            }
        }
        #endregion


        private void rdbDes_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbAsc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
