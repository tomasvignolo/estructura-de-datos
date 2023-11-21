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
    public partial class frmConsultaSQL : Form
    {
        public frmConsultaSQL()
        {
            InitializeComponent();
        }

        string varSQL = "";
        clsBaseDeDatos clsBaseDatos = new clsBaseDeDatos();

        private void frmConsultaSQL_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            varSQL = txtSQL.Text;
            clsBaseDatos.Listar(dgvSQL2, varSQL);
        }
    }
}
