namespace pryParcial1
{
    partial class frmConsultar
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
            System.Windows.Forms.Button btnVolver;
            System.Windows.Forms.Button btnBuscar;
            this.grpboxDatos = new System.Windows.Forms.GroupBox();
            this.lblValorStock = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantArticulos = new System.Windows.Forms.TextBox();
            this.lblCantArticulos = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtTotalValorStock = new System.Windows.Forms.TextBox();
            this.lblTotalValorStock = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CValorStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            this.grpboxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.PapayaWhip;
            btnVolver.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVolver.ForeColor = System.Drawing.Color.Magenta;
            btnVolver.Location = new System.Drawing.Point(6, 55);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(121, 26);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.MediumSpringGreen;
            btnBuscar.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnBuscar.ForeColor = System.Drawing.Color.Red;
            btnBuscar.Location = new System.Drawing.Point(6, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(121, 26);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpboxDatos
            // 
            this.grpboxDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.grpboxDatos.Controls.Add(btnBuscar);
            this.grpboxDatos.Controls.Add(this.lblValorStock);
            this.grpboxDatos.Controls.Add(this.lblStock);
            this.grpboxDatos.Controls.Add(this.lblPrecio);
            this.grpboxDatos.Controls.Add(this.lblCat);
            this.grpboxDatos.Controls.Add(this.lblDescripcion);
            this.grpboxDatos.Controls.Add(this.txtCodigo);
            this.grpboxDatos.Controls.Add(btnVolver);
            this.grpboxDatos.Controls.Add(this.txtCantArticulos);
            this.grpboxDatos.Controls.Add(this.lblCantArticulos);
            this.grpboxDatos.Controls.Add(this.lblCategoria);
            this.grpboxDatos.Controls.Add(this.txtTotalValorStock);
            this.grpboxDatos.Controls.Add(this.lblTotalValorStock);
            this.grpboxDatos.Controls.Add(this.cmbCategoria);
            this.grpboxDatos.Controls.Add(this.dgvDatos);
            this.grpboxDatos.Controls.Add(this.btnMostrar);
            this.grpboxDatos.Controls.Add(this.btnExportar);
            this.grpboxDatos.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxDatos.ForeColor = System.Drawing.Color.Violet;
            this.grpboxDatos.Location = new System.Drawing.Point(60, 21);
            this.grpboxDatos.Name = "grpboxDatos";
            this.grpboxDatos.Size = new System.Drawing.Size(680, 409);
            this.grpboxDatos.TabIndex = 7;
            this.grpboxDatos.TabStop = false;
            this.grpboxDatos.Text = "Datos";
            // 
            // lblValorStock
            // 
            this.lblValorStock.AutoSize = true;
            this.lblValorStock.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblValorStock.Location = new System.Drawing.Point(595, 25);
            this.lblValorStock.Name = "lblValorStock";
            this.lblValorStock.Size = new System.Drawing.Size(79, 17);
            this.lblValorStock.TabIndex = 15;
            this.lblValorStock.Text = "Valor Stock";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(547, 25);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(42, 17);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.Coral;
            this.lblPrecio.Location = new System.Drawing.Point(496, 25);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 17);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "precio";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCat.Location = new System.Drawing.Point(424, 25);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(66, 17);
            this.lblCat.TabIndex = 12;
            this.lblCat.Text = "categoria";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblDescripcion.Location = new System.Drawing.Point(239, 25);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 17);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(133, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.Text = "Buscar por codigo";
            // 
            // txtCantArticulos
            // 
            this.txtCantArticulos.BackColor = System.Drawing.Color.White;
            this.txtCantArticulos.Location = new System.Drawing.Point(195, 365);
            this.txtCantArticulos.Name = "txtCantArticulos";
            this.txtCantArticulos.Size = new System.Drawing.Size(62, 24);
            this.txtCantArticulos.TabIndex = 6;
            // 
            // lblCantArticulos
            // 
            this.lblCantArticulos.AutoSize = true;
            this.lblCantArticulos.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantArticulos.ForeColor = System.Drawing.Color.Yellow;
            this.lblCantArticulos.Location = new System.Drawing.Point(6, 370);
            this.lblCantArticulos.Name = "lblCantArticulos";
            this.lblCantArticulos.Size = new System.Drawing.Size(172, 17);
            this.lblCantArticulos.TabIndex = 5;
            this.lblCantArticulos.Text = "Cantidad de publicaciones:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Cyan;
            this.lblCategoria.Location = new System.Drawing.Point(334, 61);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(86, 17);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // txtTotalValorStock
            // 
            this.txtTotalValorStock.BackColor = System.Drawing.Color.White;
            this.txtTotalValorStock.Location = new System.Drawing.Point(426, 367);
            this.txtTotalValorStock.Name = "txtTotalValorStock";
            this.txtTotalValorStock.Size = new System.Drawing.Size(121, 24);
            this.txtTotalValorStock.TabIndex = 4;
            // 
            // lblTotalValorStock
            // 
            this.lblTotalValorStock.AutoSize = true;
            this.lblTotalValorStock.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValorStock.ForeColor = System.Drawing.Color.Magenta;
            this.lblTotalValorStock.Location = new System.Drawing.Point(263, 370);
            this.lblTotalValorStock.Name = "lblTotalValorStock";
            this.lblTotalValorStock.Size = new System.Drawing.Size(136, 17);
            this.lblTotalValorStock.TabIndex = 3;
            this.lblTotalValorStock.Text = "Total valor de stock :";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(426, 56);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 25);
            this.cmbCategoria.TabIndex = 1;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CDescripcion,
            this.CCosto,
            this.CStock,
            this.CValorStock});
            this.dgvDatos.Location = new System.Drawing.Point(6, 86);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(668, 273);
            this.dgvDatos.TabIndex = 2;
            // 
            // CCodigo
            // 
            this.CCodigo.HeaderText = "Codigo";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.Width = 120;
            // 
            // CDescripcion
            // 
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.Width = 220;
            // 
            // CCosto
            // 
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
            // 
            // CStock
            // 
            this.CStock.HeaderText = "Stock";
            this.CStock.Name = "CStock";
            // 
            // CValorStock
            // 
            this.CValorStock.HeaderText = "Valor en stock";
            this.CValorStock.Name = "CValorStock";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrar.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Cyan;
            this.btnMostrar.Location = new System.Drawing.Point(553, 53);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(121, 29);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Indigo;
            this.btnExportar.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Yellow;
            this.btnExportar.Location = new System.Drawing.Point(553, 365);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(121, 29);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(54)))));
            this.BackgroundImage = global::pryParcial1.Properties.Resources.fondo_Parcial;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxDatos);
            this.Name = "frmConsultar";
            this.Text = "frmConsultar";
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            this.grpboxDatos.ResumeLayout(false);
            this.grpboxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxDatos;
        private System.Windows.Forms.TextBox txtCantArticulos;
        private System.Windows.Forms.Label lblCantArticulos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtTotalValorStock;
        private System.Windows.Forms.Label lblTotalValorStock;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CValorStock;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblValorStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}