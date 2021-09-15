
namespace TP_WinForm
{
    partial class frmBusqueda
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
            this.chbCodigo = new System.Windows.Forms.CheckBox();
            this.chbNombre = new System.Windows.Forms.CheckBox();
            this.chbMarca = new System.Windows.Forms.CheckBox();
            this.chbCategoria = new System.Windows.Forms.CheckBox();
            this.labelBusqueda1 = new System.Windows.Forms.Label();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.labelEspecifico = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chbCodigo
            // 
            this.chbCodigo.AutoSize = true;
            this.chbCodigo.Location = new System.Drawing.Point(15, 67);
            this.chbCodigo.Name = "chbCodigo";
            this.chbCodigo.Size = new System.Drawing.Size(59, 17);
            this.chbCodigo.TabIndex = 0;
            this.chbCodigo.Text = "Codigo";
            this.chbCodigo.UseVisualStyleBackColor = true;
            this.chbCodigo.CheckedChanged += new System.EventHandler(this.chbCodigo_CheckedChanged);
            // 
            // chbNombre
            // 
            this.chbNombre.AutoSize = true;
            this.chbNombre.Location = new System.Drawing.Point(15, 87);
            this.chbNombre.Name = "chbNombre";
            this.chbNombre.Size = new System.Drawing.Size(63, 17);
            this.chbNombre.TabIndex = 1;
            this.chbNombre.Text = "Nombre";
            this.chbNombre.UseVisualStyleBackColor = true;
            this.chbNombre.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chbMarca
            // 
            this.chbMarca.AutoSize = true;
            this.chbMarca.Location = new System.Drawing.Point(15, 155);
            this.chbMarca.Name = "chbMarca";
            this.chbMarca.Size = new System.Drawing.Size(56, 17);
            this.chbMarca.TabIndex = 2;
            this.chbMarca.Text = "Marca";
            this.chbMarca.UseVisualStyleBackColor = true;
            this.chbMarca.CheckedChanged += new System.EventHandler(this.chbMarca_CheckedChanged);
            // 
            // chbCategoria
            // 
            this.chbCategoria.AutoSize = true;
            this.chbCategoria.Location = new System.Drawing.Point(15, 175);
            this.chbCategoria.Name = "chbCategoria";
            this.chbCategoria.Size = new System.Drawing.Size(71, 17);
            this.chbCategoria.TabIndex = 3;
            this.chbCategoria.Text = "Categoria";
            this.chbCategoria.UseVisualStyleBackColor = true;
            this.chbCategoria.CheckedChanged += new System.EventHandler(this.chbCategoria_CheckedChanged);
            // 
            // labelBusqueda1
            // 
            this.labelBusqueda1.AutoSize = true;
            this.labelBusqueda1.Location = new System.Drawing.Point(-2, 21);
            this.labelBusqueda1.Name = "labelBusqueda1";
            this.labelBusqueda1.Size = new System.Drawing.Size(191, 13);
            this.labelBusqueda1.TabIndex = 4;
            this.labelBusqueda1.Text = "Seleccione su criterio de busqueda . . .";
            this.labelBusqueda1.Click += new System.EventHandler(this.labelBusqueda1_Click);
            // 
            // labelGeneral
            // 
            this.labelGeneral.AutoSize = true;
            this.labelGeneral.Location = new System.Drawing.Point(54, 136);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(62, 13);
            this.labelGeneral.TabIndex = 5;
            this.labelGeneral.Text = "General . . .";
            this.labelGeneral.Click += new System.EventHandler(this.labelBusqueda2_Click);
            // 
            // labelEspecifico
            // 
            this.labelEspecifico.AutoSize = true;
            this.labelEspecifico.Location = new System.Drawing.Point(50, 49);
            this.labelEspecifico.Name = "labelEspecifico";
            this.labelEspecifico.Size = new System.Drawing.Size(74, 13);
            this.labelEspecifico.TabIndex = 6;
            this.labelEspecifico.Text = "Especifico . . .";
            this.labelEspecifico.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 213);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(81, 65);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(100, 20);
            this.txbCodigo.TabIndex = 9;
            this.txbCodigo.Visible = false;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(81, 87);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 10;
            this.txbNombre.Visible = false;
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(81, 152);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(100, 20);
            this.txbMarca.TabIndex = 11;
            this.txbMarca.Visible = false;
            // 
            // txbCategoria
            // 
            this.txbCategoria.Location = new System.Drawing.Point(81, 173);
            this.txbCategoria.Name = "txbCategoria";
            this.txbCategoria.Size = new System.Drawing.Size(100, 20);
            this.txbCategoria.TabIndex = 12;
            this.txbCategoria.Visible = false;
            // 
            // frmBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 248);
            this.Controls.Add(this.txbCategoria);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelEspecifico);
            this.Controls.Add(this.labelGeneral);
            this.Controls.Add(this.labelBusqueda1);
            this.Controls.Add(this.chbCategoria);
            this.Controls.Add(this.chbMarca);
            this.Controls.Add(this.chbNombre);
            this.Controls.Add(this.chbCodigo);
            this.Name = "frmBusqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbCodigo;
        private System.Windows.Forms.CheckBox chbNombre;
        private System.Windows.Forms.CheckBox chbMarca;
        private System.Windows.Forms.CheckBox chbCategoria;
        private System.Windows.Forms.Label labelBusqueda1;
        private System.Windows.Forms.Label labelGeneral;
        private System.Windows.Forms.Label labelEspecifico;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbCategoria;
    }
}