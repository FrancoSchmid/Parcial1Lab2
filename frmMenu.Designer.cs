namespace pryParcial1
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmiConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiListarTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.lstvLista = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiConsultar,
            this.TsmiListarTodos,
            this.TsmiAlumno});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmiConsultar
            // 
            this.TsmiConsultar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmiConsultar.Name = "TsmiConsultar";
            this.TsmiConsultar.Size = new System.Drawing.Size(71, 20);
            this.TsmiConsultar.Text = "Consultar";
            this.TsmiConsultar.Click += new System.EventHandler(this.TsmiConsultar_Click_1);
            // 
            // TsmiListarTodos
            // 
            this.TsmiListarTodos.Name = "TsmiListarTodos";
            this.TsmiListarTodos.Size = new System.Drawing.Size(80, 20);
            this.TsmiListarTodos.Text = "Listar todos";
            this.TsmiListarTodos.Click += new System.EventHandler(this.TsmiListarTodos_Click);
            // 
            // TsmiAlumno
            // 
            this.TsmiAlumno.Name = "TsmiAlumno";
            this.TsmiAlumno.Size = new System.Drawing.Size(62, 20);
            this.TsmiAlumno.Text = "Alumno";
            this.TsmiAlumno.Click += new System.EventHandler(this.TsmiAlumno_Click);
            // 
            // lstvLista
            // 
            this.lstvLista.HideSelection = false;
            this.lstvLista.Location = new System.Drawing.Point(12, 37);
            this.lstvLista.Name = "lstvLista";
            this.lstvLista.Size = new System.Drawing.Size(776, 401);
            this.lstvLista.TabIndex = 2;
            this.lstvLista.UseCompatibleStateImageBehavior = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryParcial1.Properties.Resources.fondo_Parcial;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstvLista);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiConsultar;
        private System.Windows.Forms.ToolStripMenuItem TsmiAlumno;
        private System.Windows.Forms.ToolStripMenuItem TsmiListarTodos;
        private System.Windows.Forms.ListView lstvLista;
    }
}

