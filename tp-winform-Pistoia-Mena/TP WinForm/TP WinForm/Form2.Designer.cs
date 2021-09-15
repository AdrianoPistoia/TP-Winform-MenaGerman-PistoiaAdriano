
namespace TP_WinForm
{
    partial class frmEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbID = new System.Windows.Forms.CheckBox();
            this.chbNombre = new System.Windows.Forms.CheckBox();
            this.chbMarca = new System.Windows.Forms.CheckBox();
            this.chbCategoria = new System.Windows.Forms.CheckBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.labelEliminar2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(121, 31);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.Visible = false;
            // 
            // labelEliminar
            // 
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.Location = new System.Drawing.Point(35, 15);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(167, 13);
            this.labelEliminar.TabIndex = 2;
            this.labelEliminar.Text = "Seleccione su elemento a eliminar";
            this.labelEliminar.Click += new System.EventHandler(this.txtMensaje_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(141, 216);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(23, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chbID
            // 
            this.chbID.AutoSize = true;
            this.chbID.Location = new System.Drawing.Point(35, 34);
            this.chbID.Name = "chbID";
            this.chbID.Size = new System.Drawing.Size(59, 17);
            this.chbID.TabIndex = 5;
            this.chbID.Text = "Codigo";
            this.chbID.UseVisualStyleBackColor = true;
            this.chbID.CheckedChanged += new System.EventHandler(this.chbID_CheckedChanged);
            // 
            // chbNombre
            // 
            this.chbNombre.AutoSize = true;
            this.chbNombre.Location = new System.Drawing.Point(35, 57);
            this.chbNombre.Name = "chbNombre";
            this.chbNombre.Size = new System.Drawing.Size(63, 17);
            this.chbNombre.TabIndex = 6;
            this.chbNombre.Text = "Nombre";
            this.chbNombre.UseVisualStyleBackColor = true;
            this.chbNombre.CheckedChanged += new System.EventHandler(this.chbNombre_CheckedChanged);
            // 
            // chbMarca
            // 
            this.chbMarca.AutoSize = true;
            this.chbMarca.Location = new System.Drawing.Point(38, 140);
            this.chbMarca.Name = "chbMarca";
            this.chbMarca.Size = new System.Drawing.Size(56, 17);
            this.chbMarca.TabIndex = 7;
            this.chbMarca.Text = "Marca";
            this.chbMarca.UseVisualStyleBackColor = true;
            this.chbMarca.CheckedChanged += new System.EventHandler(this.chbMarca_CheckedChanged);
            // 
            // chbCategoria
            // 
            this.chbCategoria.AutoSize = true;
            this.chbCategoria.Location = new System.Drawing.Point(38, 160);
            this.chbCategoria.Name = "chbCategoria";
            this.chbCategoria.Size = new System.Drawing.Size(71, 17);
            this.chbCategoria.TabIndex = 8;
            this.chbCategoria.Text = "Categoria";
            this.chbCategoria.UseVisualStyleBackColor = true;
            this.chbCategoria.CheckedChanged += new System.EventHandler(this.chbCategoria_CheckedChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(121, 55);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 9;
            this.textBoxNombre.Visible = false;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(124, 137);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarca.TabIndex = 10;
            this.textBoxMarca.Visible = false;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(124, 160);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategoria.TabIndex = 11;
            this.textBoxCategoria.Visible = false;
            // 
            // labelEliminar2
            // 
            this.labelEliminar2.AutoSize = true;
            this.labelEliminar2.Location = new System.Drawing.Point(35, 121);
            this.labelEliminar2.Name = "labelEliminar2";
            this.labelEliminar2.Size = new System.Drawing.Size(191, 13);
            this.labelEliminar2.TabIndex = 12;
            this.labelEliminar2.Text = "Seleccione Categoria/Marca a Eliminar";
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 250);
            this.Controls.Add(this.labelEliminar2);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.chbCategoria);
            this.Controls.Add(this.chbMarca);
            this.Controls.Add(this.chbNombre);
            this.Controls.Add(this.chbID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.labelEliminar);
            this.Controls.Add(this.textBoxID);
            this.MaximizeBox = false;
            this.Name = "frmEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chbID;
        private System.Windows.Forms.CheckBox chbNombre;
        private System.Windows.Forms.CheckBox chbMarca;
        private System.Windows.Forms.CheckBox chbCategoria;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Label labelEliminar2;
    }
}