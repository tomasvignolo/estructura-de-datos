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
    public partial class frmConsultaCombo : Form
    {
        public frmConsultaCombo()
        {
            InitializeComponent();
        }

        clsBaseDeDatos clsBaseDatos = new clsBaseDeDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmConsultaCombo_Load(object sender, EventArgs e)
        {
            cboOperaciones.Items.Add("Diferencia");
            cboOperaciones.Items.Add("Interseccion");
            cboOperaciones.Items.Add("Juntar");
            cboOperaciones.Items.Add("Proyeccion simple");
            cboOperaciones.Items.Add("Proyeccion multiatributo");
            cboOperaciones.Items.Add("Seleccion multiatributo con operador AND");
            cboOperaciones.Items.Add("Seleccion multiatributo con operador OR");
            cboOperaciones.Items.Add("Seleccion multiatributo por convolucion");
            cboOperaciones.Items.Add("Seleccion simple");
            cboOperaciones.Items.Add("Union");
        }

        private void cboOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            string operacionSeleccionada = cboOperaciones.SelectedItem.ToString();
            string varSQL = "";

            switch (operacionSeleccionada)
            {
                case "Diferencia":
                    varSQL = "SELECT * FROM libro WHERE idIdioma = 2 AND idLibro NOT IN (SELECT idLibro FROM libro WHERE idPais = 3) ORDER BY 1 ASC";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Interseccion":
                    varSQL = "SELECT * FROM libro WHERE idIdioma = 2 AND idLibro IN (SELECT idLibro FROM libro WHERE idPais = 3) ORDER BY 1 ASC";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Juntar":
                    varSQL = "SELECT * FROM libro INNER JOIN autor on LIBRO.IDAUTOR = AUTOR.IDAUTOR";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Proyeccion simple":
                    varSQL = "SELECT titulo FROM libro ORDER BY 1 DESC";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Proyeccion multiatributo":
                    varSQL = "SELECT titulo, año FROM libro ORDER BY titulo ASC";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Seleccion multiatributo con operador AND":
                    varSQL = "SELECT titulo, idAutor AS autor, idIdioma as idioma FROM libro WHERE idAutor <> 5 AND idIdioma = 1 ORDER BY titulo ASC";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Seleccion multiatributo con operador OR":
                    varSQL = "SELECT titulo, idAutor AS autor, idIdioma as idioma FROM libro WHERE idAutor <> 5 OR idIdioma = 1 ORDER BY titulo ASC";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Seleccion multiatributo por convolucion":
                    varSQL = "SELECT * FROM (SELECT * FROM libro WHERE idAutor = 4) AS x WHERE idIdioma = 1 ORDER BY titulo";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Seleccion simple":
                    varSQL = "SELECT titulo, idAutor FROM libro WHERE idAutor <> 5 ORDER BY titulo DESC";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
                case "Union":
                    varSQL = "SELECT * FROM libro WHERE idIdioma = 1 UNION SELECT * FROM libro WHERE idIdioma = 2";
                    clsBaseDatos.Listar(dgvSQL, varSQL);
                    break;
            }
        }
    }
}
