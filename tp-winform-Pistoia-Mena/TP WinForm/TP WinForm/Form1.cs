using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TP_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloService service = new ArticuloService();
            dgvArticulo.DataSource = service.listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_MouseClick(object sender, MouseEventArgs e)
        {
            

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar vent = new frmEliminar();
            vent.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ArticuloService service = new ArticuloService();
            dgvArticulo.DataSource = service.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda vent = new frmBusqueda();
            vent.ShowDialog();
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
