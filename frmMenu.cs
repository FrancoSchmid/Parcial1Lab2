using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryParcial1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        clsArchivo X = new clsArchivo();

        private void TsmiConsultar_Click_1(object sender, EventArgs e)
        {
            frmConsultar frmConsultar = new frmConsultar();
            frmConsultar.Show();

            this.Hide();
        }

        private void TsmiAlumno_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlumno = new frmAlumno();
            frmAlumno.Show();

            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lstvLista.Hide();
        }

        private void TsmiListarTodos_Click(object sender, EventArgs e)
        {
            lstvLista.Show();
            X.MostrarTodo(lstvLista);
        }
    }
}
