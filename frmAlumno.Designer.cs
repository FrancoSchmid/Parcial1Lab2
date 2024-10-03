namespace pryParcial1
{
    partial class frmAlumno
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
            this.lblAlumnoDni = new System.Windows.Forms.Label();
            this.lblTrabajoPI = new System.Windows.Forms.Label();
            this.llbLaboratorio = new System.Windows.Forms.Label();
            this.lblAnalista = new System.Windows.Forms.Label();
            this.pctAlumno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlumnoDni
            // 
            this.lblAlumnoDni.AutoSize = true;
            this.lblAlumnoDni.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoDni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlumnoDni.Location = new System.Drawing.Point(15, 156);
            this.lblAlumnoDni.Name = "lblAlumnoDni";
            this.lblAlumnoDni.Size = new System.Drawing.Size(254, 21);
            this.lblAlumnoDni.TabIndex = 9;
            this.lblAlumnoDni.Text = "DNI 41681377  – Franco Schmid";
            // 
            // lblTrabajoPI
            // 
            this.lblTrabajoPI.AutoSize = true;
            this.lblTrabajoPI.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajoPI.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrabajoPI.Location = new System.Drawing.Point(15, 76);
            this.lblTrabajoPI.Name = "lblTrabajoPI";
            this.lblTrabajoPI.Size = new System.Drawing.Size(276, 21);
            this.lblTrabajoPI.TabIndex = 8;
            this.lblTrabajoPI.Text = "Instancia: 1º Instancia Evaluativa";
            // 
            // llbLaboratorio
            // 
            this.llbLaboratorio.AutoSize = true;
            this.llbLaboratorio.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLaboratorio.ForeColor = System.Drawing.Color.Magenta;
            this.llbLaboratorio.Location = new System.Drawing.Point(15, 43);
            this.llbLaboratorio.Name = "llbLaboratorio";
            this.llbLaboratorio.Size = new System.Drawing.Size(337, 21);
            this.llbLaboratorio.TabIndex = 7;
            this.llbLaboratorio.Text = "Materia: Laboratorio de Programación 2";
            // 
            // lblAnalista
            // 
            this.lblAnalista.AutoSize = true;
            this.lblAnalista.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalista.ForeColor = System.Drawing.Color.Cyan;
            this.lblAnalista.Location = new System.Drawing.Point(15, 12);
            this.lblAnalista.Name = "lblAnalista";
            this.lblAnalista.Size = new System.Drawing.Size(244, 21);
            this.lblAnalista.TabIndex = 6;
            this.lblAnalista.Text = "Carrera: Analista de Sistemas";
            // 
            // pctAlumno
            // 
            this.pctAlumno.Image = global::pryParcial1.Properties.Resources.foto_Parcial_1;
            this.pctAlumno.Location = new System.Drawing.Point(376, 12);
            this.pctAlumno.Name = "pctAlumno";
            this.pctAlumno.Size = new System.Drawing.Size(160, 165);
            this.pctAlumno.TabIndex = 10;
            this.pctAlumno.TabStop = false;
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(548, 191);
            this.Controls.Add(this.pctAlumno);
            this.Controls.Add(this.lblAlumnoDni);
            this.Controls.Add(this.lblTrabajoPI);
            this.Controls.Add(this.llbLaboratorio);
            this.Controls.Add(this.lblAnalista);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.pctAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAlumno;
        private System.Windows.Forms.Label lblAlumnoDni;
        private System.Windows.Forms.Label lblTrabajoPI;
        private System.Windows.Forms.Label llbLaboratorio;
        private System.Windows.Forms.Label lblAnalista;
    }
}