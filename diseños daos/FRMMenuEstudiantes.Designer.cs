namespace PROYECTOFINALPROGRA1.diseños_daos
{
    partial class FRMMenuEstudiantes
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
            this.pnlContenedorEstudiante = new System.Windows.Forms.Panel();
            this.pnlesloganestudiante = new System.Windows.Forms.Panel();
            this.pnlContenedorEstudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorEstudiante
            // 
            this.pnlContenedorEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlContenedorEstudiante.Controls.Add(this.pnlesloganestudiante);
            this.pnlContenedorEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorEstudiante.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorEstudiante.Name = "pnlContenedorEstudiante";
            this.pnlContenedorEstudiante.Size = new System.Drawing.Size(1093, 740);
            this.pnlContenedorEstudiante.TabIndex = 0;
            // 
            // pnlesloganestudiante
            // 
            this.pnlesloganestudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlesloganestudiante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlesloganestudiante.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlesloganestudiante.Location = new System.Drawing.Point(0, 0);
            this.pnlesloganestudiante.Name = "pnlesloganestudiante";
            this.pnlesloganestudiante.Size = new System.Drawing.Size(223, 740);
            this.pnlesloganestudiante.TabIndex = 0;
            // 
            // FRMMenuEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 740);
            this.Controls.Add(this.pnlContenedorEstudiante);
            this.Name = "FRMMenuEstudiantes";
            this.Text = "FRMMenuEstudiantes";
            this.pnlContenedorEstudiante.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorEstudiante;
        private System.Windows.Forms.Panel pnlesloganestudiante;
    }
}