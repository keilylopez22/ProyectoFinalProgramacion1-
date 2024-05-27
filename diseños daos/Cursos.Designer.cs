namespace PROYECTOFINALPROGRA1.diseños_daos
{
    partial class CURSOS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.txtNombreCursoBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvCursos = new System.Windows.Forms.DataGridView();
            this.BTNS = new System.Windows.Forms.GroupBox();
            this.btnAnteriorDelCurso = new System.Windows.Forms.Button();
            this.btnLimpiarDelCurso = new System.Windows.Forms.Button();
            this.btnCancelarDelCurso = new System.Windows.Forms.Button();
            this.btnListarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtHorarioCurso = new System.Windows.Forms.TextBox();
            this.txtFacultaddelCurso = new System.Windows.Forms.TextBox();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnGuardarCurso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarCurso = new System.Windows.Forms.Button();
            this.btneliminarCurso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).BeginInit();
            this.BTNS.SuspendLayout();
            this.groupDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCurso);
            this.groupBox1.Controls.Add(this.txtNombreCursoBuscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 78);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR";
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Location = new System.Drawing.Point(853, 42);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCurso.TabIndex = 21;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            // 
            // txtNombreCursoBuscar
            // 
            this.txtNombreCursoBuscar.Location = new System.Drawing.Point(121, 35);
            this.txtNombreCursoBuscar.Name = "txtNombreCursoBuscar";
            this.txtNombreCursoBuscar.Size = new System.Drawing.Size(371, 22);
            this.txtNombreCursoBuscar.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvCursos);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 144);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LISTAR CURSOS";
            // 
            // DgvCursos
            // 
            this.DgvCursos.AllowUserToAddRows = false;
            this.DgvCursos.AllowUserToDeleteRows = false;
            this.DgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCursos.Location = new System.Drawing.Point(3, 18);
            this.DgvCursos.Name = "DgvCursos";
            this.DgvCursos.ReadOnly = true;
            this.DgvCursos.RowHeadersWidth = 51;
            this.DgvCursos.RowTemplate.Height = 24;
            this.DgvCursos.Size = new System.Drawing.Size(952, 123);
            this.DgvCursos.TabIndex = 0;
            // 
            // BTNS
            // 
            this.BTNS.Controls.Add(this.btnAnteriorDelCurso);
            this.BTNS.Controls.Add(this.btnLimpiarDelCurso);
            this.BTNS.Controls.Add(this.btnCancelarDelCurso);
            this.BTNS.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNS.Location = new System.Drawing.Point(984, 22);
            this.BTNS.Name = "BTNS";
            this.BTNS.Size = new System.Drawing.Size(200, 212);
            this.BTNS.TabIndex = 23;
            this.BTNS.TabStop = false;
            this.BTNS.Text = "BTNS";
            // 
            // btnAnteriorDelCurso
            // 
            this.btnAnteriorDelCurso.Location = new System.Drawing.Point(10, 148);
            this.btnAnteriorDelCurso.Name = "btnAnteriorDelCurso";
            this.btnAnteriorDelCurso.Size = new System.Drawing.Size(132, 39);
            this.btnAnteriorDelCurso.TabIndex = 22;
            this.btnAnteriorDelCurso.Text = "Anterior";
            this.btnAnteriorDelCurso.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarDelCurso
            // 
            this.btnLimpiarDelCurso.Location = new System.Drawing.Point(6, 87);
            this.btnLimpiarDelCurso.Name = "btnLimpiarDelCurso";
            this.btnLimpiarDelCurso.Size = new System.Drawing.Size(136, 41);
            this.btnLimpiarDelCurso.TabIndex = 21;
            this.btnLimpiarDelCurso.Text = "Limpiar";
            this.btnLimpiarDelCurso.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDelCurso
            // 
            this.btnCancelarDelCurso.Location = new System.Drawing.Point(6, 29);
            this.btnCancelarDelCurso.Name = "btnCancelarDelCurso";
            this.btnCancelarDelCurso.Size = new System.Drawing.Size(136, 36);
            this.btnCancelarDelCurso.TabIndex = 20;
            this.btnCancelarDelCurso.Text = "Cancelar";
            this.btnCancelarDelCurso.UseVisualStyleBackColor = true;
            this.btnCancelarDelCurso.Click += new System.EventHandler(this.btnCancelarDelCurso_Click);
            // 
            // btnListarCurso
            // 
            this.btnListarCurso.Location = new System.Drawing.Point(994, 361);
            this.btnListarCurso.Name = "btnListarCurso";
            this.btnListarCurso.Size = new System.Drawing.Size(155, 45);
            this.btnListarCurso.TabIndex = 24;
            this.btnListarCurso.Text = "Listar";
            this.btnListarCurso.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(99, 30);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(371, 22);
            this.txtNombreCurso.TabIndex = 6;
            // 
            // txtHorarioCurso
            // 
            this.txtHorarioCurso.Location = new System.Drawing.Point(99, 64);
            this.txtHorarioCurso.Name = "txtHorarioCurso";
            this.txtHorarioCurso.Size = new System.Drawing.Size(371, 22);
            this.txtHorarioCurso.TabIndex = 11;
            // 
            // txtFacultaddelCurso
            // 
            this.txtFacultaddelCurso.Location = new System.Drawing.Point(99, 109);
            this.txtFacultaddelCurso.Name = "txtFacultaddelCurso";
            this.txtFacultaddelCurso.Size = new System.Drawing.Size(371, 22);
            this.txtFacultaddelCurso.TabIndex = 12;
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(121, 140);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCurso.TabIndex = 16;
            this.btnCrearCurso.Text = "Crear";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // btnGuardarCurso
            // 
            this.btnGuardarCurso.Location = new System.Drawing.Point(286, 140);
            this.btnGuardarCurso.Name = "btnGuardarCurso";
            this.btnGuardarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCurso.TabIndex = 17;
            this.btnGuardarCurso.Text = "Guardar";
            this.btnGuardarCurso.UseVisualStyleBackColor = true;
            this.btnGuardarCurso.Click += new System.EventHandler(this.btnGuardarCurso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Facultad:";
            // 
            // btnActualizarCurso
            // 
            this.btnActualizarCurso.Location = new System.Drawing.Point(443, 140);
            this.btnActualizarCurso.Name = "btnActualizarCurso";
            this.btnActualizarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarCurso.TabIndex = 18;
            this.btnActualizarCurso.Text = "Actualizar";
            this.btnActualizarCurso.UseVisualStyleBackColor = true;
            this.btnActualizarCurso.Click += new System.EventHandler(this.btnActualizarCurso_Click);
            // 
            // btneliminarCurso
            // 
            this.btneliminarCurso.Location = new System.Drawing.Point(590, 140);
            this.btneliminarCurso.Name = "btneliminarCurso";
            this.btneliminarCurso.Size = new System.Drawing.Size(75, 23);
            this.btneliminarCurso.TabIndex = 19;
            this.btneliminarCurso.Text = "eliminar";
            this.btneliminarCurso.UseVisualStyleBackColor = true;
            this.btneliminarCurso.Click += new System.EventHandler(this.btneliminarCurso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Horario:";
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.label5);
            this.groupDatos.Controls.Add(this.btneliminarCurso);
            this.groupDatos.Controls.Add(this.btnActualizarCurso);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.btnGuardarCurso);
            this.groupDatos.Controls.Add(this.btnCrearCurso);
            this.groupDatos.Controls.Add(this.txtFacultaddelCurso);
            this.groupDatos.Controls.Add(this.txtHorarioCurso);
            this.groupDatos.Controls.Add(this.txtNombreCurso);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatos.Location = new System.Drawing.Point(12, 12);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(966, 169);
            this.groupDatos.TabIndex = 16;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "DATOS";
            // 
            // CURSOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 450);
            this.Controls.Add(this.btnListarCurso);
            this.Controls.Add(this.BTNS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDatos);
            this.Name = "CURSOS";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Cursodise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).EndInit();
            this.BTNS.ResumeLayout(false);
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.TextBox txtNombreCursoBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvCursos;
        private System.Windows.Forms.GroupBox BTNS;
        private System.Windows.Forms.Button btnAnteriorDelCurso;
        private System.Windows.Forms.Button btnLimpiarDelCurso;
        private System.Windows.Forms.Button btnCancelarDelCurso;
        private System.Windows.Forms.Button btnListarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtHorarioCurso;
        private System.Windows.Forms.TextBox txtFacultaddelCurso;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.Button btnGuardarCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarCurso;
        private System.Windows.Forms.Button btneliminarCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupDatos;
    }
}