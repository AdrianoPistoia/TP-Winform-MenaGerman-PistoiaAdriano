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
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void chbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txbCodigo.Visible = !txbCodigo.Visible;
            chbNombre.Visible = !chbNombre.Visible;
            chbMarca.Visible = !chbMarca.Visible;
            chbCategoria.Visible = !chbCategoria.Visible;
            labelGeneral.Visible = !labelGeneral.Visible;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txbNombre.Visible = !txbNombre.Visible;
            chbCodigo.Visible = !chbCodigo.Visible;
            chbMarca.Visible = !chbMarca.Visible;
            chbCategoria.Visible = !chbCategoria.Visible;
            labelGeneral.Visible = !labelGeneral.Visible;
        }

        private void labelBusqueda1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                if (chbCodigo.Visible == true)
                {
                    datos.setearConsulta("");
                    datos.ejecutarAccion();
                }
                if (chbNombre.Visible == true)
                {
                    datos.setearConsulta("");
                    datos.ejecutarAccion();
                }
                if (chbMarca.Visible == true)
                {
                    datos.setearConsulta("");
                    datos.ejecutarAccion();
                }
                if (chbCategoria.Visible == true)
                {
                    datos.setearConsulta("");
                    datos.ejecutarAccion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            this.Close();
        }

        private void chbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            txbCategoria.Visible = !txbCategoria.Visible;
            chbNombre.Visible = !chbNombre.Visible;
            chbCodigo.Visible = !chbCodigo.Visible;
            chbMarca.Visible = !chbMarca.Visible;
            labelEspecifico.Visible = !labelEspecifico.Visible;
        }

        private void chbMarca_CheckedChanged(object sender, EventArgs e)
        {
            txbMarca.Visible = !txbMarca.Visible;
            chbNombre.Visible = !chbNombre.Visible;
            chbCodigo.Visible = !chbCodigo.Visible;
            chbCategoria.Visible = !chbCategoria.Visible;
            labelEspecifico.Visible = !labelEspecifico.Visible;
        }

        private void labelBusqueda2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
