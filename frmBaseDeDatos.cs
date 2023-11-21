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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        clsBaseDeDatos clsBaseDatos = new clsBaseDeDatos();

        private void frmBaseDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnPrSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                            "FROM LIBRO " +
                            "ORDER BY 1 DESC";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }

        private void btnPrMult_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                            "FROM LIBRO " +
                            "ORDER BY TITULO ASC";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            //String varSQL = "SELECT * " +
            // "FROM LIBRO, AUTOR " +
            // "WHERE LIBRO.IDAUTOR = AUTOR.IDAUTOR";

            String varSQL = "Select * " +
            "from LIBRO inner join AUTOR " +
            "on LIBRO.IDAUTOR = AUTOR.IDAUTOR";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, IDAUTOR " + 
                            "FROM LIBRO " +
                            "WHERE IDAUTOR <> 5 " +
                            "ORDER BY TITULO DESC";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }

        private void btnSeleccionMult_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, IDAUTOR AS AUTOR, IDIDIOMA AS IDIOMA " +
                            "FROM LIBRO " +
                            "WHERE IDAUTOR <> 5 AND IDIDIOMA = 1 " +
                            "ORDER BY TITULO ASC";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 1 " +
                            "UNION " +
                            "SELECT * FROM LIBRO WHERE IDIDIOMA = 2";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }

        private void btnIntersección_Click(object sender, EventArgs e)
        {
            String varSQL = "Select * from libro " +
                            " where idIdioma = 2 and " +
                            "idLibro in " +
                            " (Select idlibro from libro where IdPais = 3 )" +
                            " order by 1 asc ";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "Select * from libro " +
                            " where idIdioma = 2 and " +
                            "idLibro not in " +
                            " (Select idlibro from libro where IdPais = 3 )" +
                            " order by 1 asc ";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }

        private void btnSeleccConv_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                            "FROM (select * from libro where idautor = 4) as x " +
                            "WHERE IDIDIOMA = 1 " +
                            "ORDER BY TITULO";
            clsBaseDatos.Listar(dgvSQL, varSQL);
        }
    }
}
