namespace PROYECTOFINALPROGRA1.diseños_daos
{
    partial class Facultades
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
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.btneliminarFacultad = new System.Windows.Forms.Button();
            this.btnActualizarFacultad = new System.Windows.Forms.Button();
            this.btnGuardarFacultad = new System.Windows.Forms.Button();
            this.btnCrearFacultad = new System.Windows.Forms.Button();
            this.txtFacultadICoordinador = new System.Windows.Forms.Label();
            this.txtCoordinadorDeFacultad = new System.Windows.Forms.TextBox();
            this.txtNombreFacultad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarFacultad = new System.Windows.Forms.Button();
            this.txtidFacultadBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombreFacultadBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvFacultades = new System.Windows.Forms.DataGridView();
            this.btnListarFacultad = new System.Windows.Forms.Button();
            this.BTNS = new System.Windows.Forms.GroupBox();
            this.btnAnteriorDeFacultad = new System.Windows.Forms.Button();
            this.btnLimpiarDeFacultad = new System.Windows.Forms.Button();
            this.btnCancelarDeFacultad = new System.Windows.Forms.Button();
            this.groupDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacultades)).BeginInit();
            this.BTNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.btneliminarFacultad);
            this.groupDatos.Controls.Add(this.btnActualizarFacultad);
            this.groupDatos.Controls.Add(this.btnGuardarFacultad);
            this.groupDatos.Controls.Add(this.btnCrearFacultad);
            this.groupDatos.Controls.Add(this.txtFacultadICoordinador);
            this.groupDatos.Controls.Add(this.txtCoordinadorDeFacultad);
            this.groupDatos.Controls.Add(this.txtNombreFacultad);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatos.Location = new System.Drawing.Point(12, 12);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(675, 169);
            this.groupDatos.TabIndex = 17;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "DATOS";
            // 
            // btneliminarFacultad
            // 
            this.btneliminarFacultad.Location = new System.Drawing.Point(590, 140);
            this.btneliminarFacultad.Name = "btneliminarFacultad";
            this.btneliminarFacultad.Size = new System.Drawing.Size(75, 23);
            this.btneliminarFacultad.TabIndex = 19;
            this.btneliminarFacultad.Text = "eliminar";
            this.btneliminarFacultad.UseVisualStyleBackColor = true;
            this.btneliminarFacultad.Click += new System.EventHandler(this.btneliminarFacultad_Click);
            // 
            // btnActualizarFacultad
            // 
            this.btnActualizarFacultad.Location = new System.Drawing.Point(443, 140);
            this.btnActualizarFacultad.Name = "btnActualizarFacultad";
            this.btnActualizarFacultad.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarFacultad.TabIndex = 18;
            this.btnActualizarFacultad.Text = "Actualizar";
            this.btnActualizarFacultad.UseVisualStyleBackColor = true;
            this.btnActualizarFacultad.Click += new System.EventHandler(this.btnActualizarFacultad_Click);
            // 
            // btnGuardarFacultad
            // 
            this.btnGuardarFacultad.Location = new System.Drawing.Point(286, 140);
            this.btnGuardarFacultad.Name = "btnGuardarFacultad";
            this.btnGuardarFacultad.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarFacultad.TabIndex = 17;
            this.btnGuardarFacultad.Text = "Guardar";
            this.btnGuardarFacultad.UseVisualStyleBackColor = true;
            this.btnGuardarFacultad.Click += new System.EventHandler(this.btnGuardarFacultad_Click);
            // 
            // btnCrearFacultad
            // 
            this.btnCrearFacultad.Location = new System.Drawing.Point(121, 140);
            this.btnCrearFacultad.Name = "btnCrearFacultad";
            this.btnCrearFacultad.Size = new System.Drawing.Size(75, 23);
            this.btnCrearFacultad.TabIndex = 16;
            this.btnCrearFacultad.Text = "Crear";
            this.btnCrearFacultad.UseVisualStyleBackColor = true;
            this.btnCrearFacultad.Click += new System.EventHandler(this.btnCrearFacultad_Click);
            // 
            // txtFacultadICoordinador
            // 
            this.txtFacultadICoordinador.AutoSize = true;
            this.txtFacultadICoordinador.Location = new System.Drawing.Point(6, 81);
            this.txtFacultadICoordinador.Name = "txtFacultadICoordinador";
            this.txtFacultadICoordinador.Size = new System.Drawing.Size(79, 15);
            this.txtFacultadICoordinador.TabIndex = 10;
            this.txtFacultadICoordinador.Text = "Coordinador:";
            // 
            // txtCoordinadorDeFacultad
            // 
            this.txtCoordinadorDeFacultad.Location = new System.Drawing.Point(99, 81);
            this.txtCoordinadorDeFacultad.Name = "txtCoordinadorDeFacultad";
            this.txtCoordinadorDeFacultad.Size = new System.Drawing.Size(371, 22);
            this.txtCoordinadorDeFacultad.TabIndex = 9;
            // 
            // txtNombreFacultad
            // 
            this.txtNombreFacultad.Location = new System.Drawing.Point(99, 30);
            this.txtNombreFacultad.Name = "txtNombreFacultad";
            this.txtNombreFacultad.Size = new System.Drawing.Size(371, 22);
            this.txtNombreFacultad.TabIndex = 6;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarFacultad);
            this.groupBox1.Controls.Add(this.txtidFacultadBuscar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnombreFacultadBuscar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 78);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR";
            // 
            // btnBuscarFacultad
            // 
            this.btnBuscarFacultad.Location = new System.Drawing.Point(825, 39);
            this.btnBuscarFacultad.Name = "btnBuscarFacultad";
            this.btnBuscarFacultad.Size = new System.Drawing.Size(84, 23);
            this.btnBuscarFacultad.TabIndex = 21;
            this.btnBuscarFacultad.Text = "Buscar";
            this.btnBuscarFacultad.UseVisualStyleBackColor = true;
            // 
            // txtidFacultadBuscar
            // 
            this.txtidFacultadBuscar.Location = new System.Drawing.Point(559, 39);
            this.txtidFacultadBuscar.Name = "txtidFacultadBuscar";
            this.txtidFacultadBuscar.Size = new System.Drawing.Size(243, 22);
            this.txtidFacultadBuscar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Id:";
            // 
            // txtnombreFacultadBuscar
            // 
            this.txtnombreFacultadBuscar.Location = new System.Drawing.Point(121, 35);
            this.txtnombreFacultadBuscar.Name = "txtnombreFacultadBuscar";
            this.txtnombreFacultadBuscar.Size = new System.Drawing.Size(371, 22);
            this.txtnombreFacultadBuscar.TabIndex = 9;
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
            this.groupBox3.Controls.Add(this.DgvFacultades);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 144);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LISTAR FACULTADES";
            // 
            // DgvFacultades
            // 
            this.DgvFacultades.AllowUserToAddRows = false;
            this.DgvFacultades.AllowUserToDeleteRows = false;
            this.DgvFacultades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacultades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvFacultades.Location = new System.Drawing.Point(3, 18);
            this.DgvFacultades.Name = "DgvFacultades";
            this.DgvFacultades.ReadOnly = true;
            this.DgvFacultades.RowHeadersWidth = 51;
            this.DgvFacultades.RowTemplate.Height = 24;
            this.DgvFacultades.Size = new System.Drawing.Size(952, 123);
            this.DgvFacultades.TabIndex = 0;
            // 
            // btnListarFacultad
            // 
            this.btnListarFacultad.Location = new System.Drawing.Point(964, 342);
            this.btnListarFacultad.Name = "btnListarFacultad";
            this.btnListarFacultad.Size = new System.Drawing.Size(155, 45);
            this.btnListarFacultad.TabIndex = 20;
            this.btnListarFacultad.Text = "Listar";
            this.btnListarFacultad.UseVisualStyleBackColor = true;
            // 
            // BTNS
            // 
            this.BTNS.Controls.Add(this.btnAnteriorDeFacultad);
            this.BTNS.Controls.Add(this.btnLimpiarDeFacultad);
            this.BTNS.Controls.Add(this.btnCancelarDeFacultad);
            this.BTNS.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNS.Location = new System.Drawing.Point(741, 12);
            this.BTNS.Name = "BTNS";
            this.BTNS.Size = new System.Drawing.Size(200, 192);
            this.BTNS.TabIndex = 24;
            this.BTNS.TabStop = false;
            this.BTNS.Text = "BTNS";
            // 
            // btnAnteriorDeFacultad
            // 
            this.btnAnteriorDeFacultad.Location = new System.Drawing.Point(10, 148);
            this.btnAnteriorDeFacultad.Name = "btnAnteriorDeFacultad";
            this.btnAnteriorDeFacultad.Size = new System.Drawing.Size(132, 39);
            this.btnAnteriorDeFacultad.TabIndex = 22;
            this.btnAnteriorDeFacultad.Text = "Anterior";
            this.btnAnteriorDeFacultad.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarDeFacultad
            // 
            this.btnLimpiarDeFacultad.Location = new System.Drawing.Point(6, 87);
            this.btnLimpiarDeFacultad.Name = "btnLimpiarDeFacultad";
            this.btnLimpiarDeFacultad.Size = new System.Drawing.Size(136, 41);
            this.btnLimpiarDeFacultad.TabIndex = 21;
            this.btnLimpiarDeFacultad.Text = "Limpiar";
            this.btnLimpiarDeFacultad.UseVisualStyleBackColor = true;
            this.btnLimpiarDeFacultad.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelarDeFacultad
            // 
            this.btnCancelarDeFacultad.Location = new System.Drawing.Point(6, 29);
            this.btnCancelarDeFacultad.Name = "btnCancelarDeFacultad";
            this.btnCancelarDeFacultad.Size = new System.Drawing.Size(136, 36);
            this.btnCancelarDeFacultad.TabIndex = 20;
            this.btnCancelarDeFacultad.Text = "Cancelar";
            this.btnCancelarDeFacultad.UseVisualStyleBackColor = true;
            this.btnCancelarDeFacultad.Click += new System.EventHandler(this.btnCancelarDeFacultad_Click);
            // 
            // Facultades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 450);
            this.Controls.Add(this.BTNS);
            this.Controls.Add(this.btnListarFacultad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDatos);
            this.Name = "Facultades";
            this.Text = "Facultaddise";
            this.Load += new System.EventHandler(this.Facultades_Load);
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacultades)).EndInit();
            this.BTNS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.Button btneliminarFacultad;
        private System.Windows.Forms.Button btnActualizarFacultad;
        private System.Windows.Forms.Button btnGuardarFacultad;
        private System.Windows.Forms.Button btnCrearFacultad;
        private System.Windows.Forms.Label txtFacultadICoordinador;
        private System.Windows.Forms.TextBox txtCoordinadorDeFacultad;
        private System.Windows.Forms.TextBox txtNombreFacultad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarFacultad;
        private System.Windows.Forms.TextBox txtidFacultadBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombreFacultadBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvFacultades;
        private System.Windows.Forms.Button btnListarFacultad;
        private System.Windows.Forms.GroupBox BTNS;
        private System.Windows.Forms.Button btnAnteriorDeFacultad;
        private System.Windows.Forms.Button btnLimpiarDeFacultad;
        private System.Windows.Forms.Button btnCancelarDeFacultad;
    }
}