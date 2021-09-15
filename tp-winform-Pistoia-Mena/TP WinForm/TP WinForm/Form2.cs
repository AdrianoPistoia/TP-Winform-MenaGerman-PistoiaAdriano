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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //El this es innecesario pero practico para leer
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
            AccesoDatos datos = new AccesoDatos();
                if(chbID.Visible == true)
                {
                    datos.setearConsulta("delete from ARTICULOS where Codigo = '" + textBoxID.Text + "'");
                    datos.ejecutarAccion();  
                }
                if(chbNombre.Visible == true)
                {
                    datos.setearConsulta("delete from ARTICULOS where Nombre = '" + textBoxNombre.Text + "'");
                    datos.ejecutarAccion();
                }
                if (chbMarca.Visible == true)
                {
                    datos.setearConsulta("delete from MARCAS where Descripcion = '" + textBoxMarca.Text + "'");
                    datos.ejecutarAccion();
                }
                if (chbCategoria.Visible == true)
                {
                    datos.setearConsulta("delete from CATEGORIAS where Descripcion = '" + textBoxCategoria.Text + "'");
                    datos.ejecutarAccion();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                MessageBox.Show("Para ver el cambio reflejado, seleccione el boton Refrescar");
                this.Close();
            }
        }

        private void chbID_CheckedChanged(object sender, EventArgs e)
        {
            textBoxID.Visible = !textBoxID.Visible;
            chbNombre.Visible = !chbNombre.Visible;
            chbMarca.Visible = !chbMarca.Visible;
            chbCategoria.Visible = !chbCategoria.Visible;
            labelEliminar2.Visible = !labelEliminar2.Visible;

        }

        private void chbNombre_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNombre.Visible = !textBoxNombre.Visible;
            chbID.Visible = !chbID.Visible;
            chbMarca.Visible = !chbMarca.Visible;
            chbCategoria.Visible = !chbCategoria.Visible;
            labelEliminar2.Visible = !labelEliminar2.Visible;

        }

        private void chbMarca_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMarca.Visible = !textBoxMarca.Visible;
            chbNombre.Visible = !chbNombre.Visible;
            chbID.Visible = !chbID.Visible;
            chbCategoria.Visible = !chbCategoria.Visible;
            labelEliminar.Visible = !labelEliminar.Visible;
        }

        private void chbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCategoria.Visible = !textBoxCategoria.Visible;
            chbNombre.Visible = !chbNombre.Visible;
            chbMarca.Visible = !chbMarca.Visible;
            chbID.Visible = !chbID.Visible;
            labelEliminar.Visible = !labelEliminar.Visible;

        }
    }
}
