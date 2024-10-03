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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        clsArchivo X = new clsArchivo();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            X.Buscar(txtCodigo, lblDescripcion, lblPrecio, lblCategoria, lblStock, lblValorStock);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            X.Mostrar(dgvDatos, cmbCategoria, txtCantArticulos, txtTotalValorStock);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            X.Exportar(dgvDatos);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {
            X.Cargar(cmbCategoria);
        }
    }
}
