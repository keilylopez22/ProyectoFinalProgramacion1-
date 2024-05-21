namespace PROYECTOFINALPROGRA1.diseños_daos
{
    partial class Cursodise
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BTNS = new System.Windows.Forms.GroupBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txthorario = new System.Windows.Forms.TextBox();
            this.txtfacultad = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.txtcoord = new System.Windows.Forms.TextBox();
            this.txtCtedratic = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.BTNS.SuspendLayout();
            this.groupDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 78);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(853, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 11;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 22);
            this.textBox2.TabIndex = 9;
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
            this.groupBox3.Controls.Add(this.DgvUsuarios);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 144);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LISTAR CURSOS";
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUsuarios.Location = new System.Drawing.Point(3, 18);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersWidth = 51;
            this.DgvUsuarios.RowTemplate.Height = 24;
            this.DgvUsuarios.Size = new System.Drawing.Size(952, 123);
            this.DgvUsuarios.TabIndex = 0;
            // 
            // BTNS
            // 
            this.BTNS.Controls.Add(this.btnAnterior);
            this.BTNS.Controls.Add(this.btnLimpiar);
            this.BTNS.Controls.Add(this.btnCancelar);
            this.BTNS.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNS.Location = new System.Drawing.Point(984, 22);
            this.BTNS.Name = "BTNS";
            this.BTNS.Size = new System.Drawing.Size(200, 212);
            this.BTNS.TabIndex = 23;
            this.BTNS.TabStop = false;
            this.BTNS.Text = "BTNS";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(10, 148);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(132, 39);
            this.btnAnterior.TabIndex = 22;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(6, 87);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 41);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 36);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(994, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Catedratico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(371, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(476, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(92, 15);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Text = "Id Coordinador:";
            // 
            // txthorario
            // 
            this.txthorario.Location = new System.Drawing.Point(99, 64);
            this.txthorario.Name = "txthorario";
            this.txthorario.Size = new System.Drawing.Size(371, 22);
            this.txthorario.TabIndex = 11;
            // 
            // txtfacultad
            // 
            this.txtfacultad.Location = new System.Drawing.Point(578, 64);
            this.txtfacultad.Name = "txtfacultad";
            this.txtfacultad.Size = new System.Drawing.Size(371, 22);
            this.txtfacultad.TabIndex = 12;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(121, 140);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(286, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Facultad:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(443, 140);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(590, 140);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 19;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
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
            this.groupDatos.Controls.Add(this.btneliminar);
            this.groupDatos.Controls.Add(this.btnActualizar);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.btnGuardar);
            this.groupDatos.Controls.Add(this.btnCrear);
            this.groupDatos.Controls.Add(this.txtfacultad);
            this.groupDatos.Controls.Add(this.txthorario);
            this.groupDatos.Controls.Add(this.txtEmail);
            this.groupDatos.Controls.Add(this.txtcoord);
            this.groupDatos.Controls.Add(this.txtCtedratic);
            this.groupDatos.Controls.Add(this.txtNombre);
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatos.Location = new System.Drawing.Point(12, 12);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(966, 169);
            this.groupDatos.TabIndex = 16;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "DATOS";
            // 
            // txtcoord
            // 
            this.txtcoord.Location = new System.Drawing.Point(578, 25);
            this.txtcoord.Name = "txtcoord";
            this.txtcoord.Size = new System.Drawing.Size(371, 22);
            this.txtcoord.TabIndex = 9;
            // 
            // txtCtedratic
            // 
            this.txtCtedratic.Location = new System.Drawing.Point(99, 92);
            this.txtCtedratic.Name = "txtCtedratic";
            this.txtCtedratic.Size = new System.Drawing.Size(371, 22);
            this.txtCtedratic.TabIndex = 8;
            // 
            // Cursodise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDatos);
            this.Name = "Cursodise";
            this.Text = "Cursodise";
            this.Load += new System.EventHandler(this.Cursodise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.BTNS.ResumeLayout(false);
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.GroupBox BTNS;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox txthorario;
        private System.Windows.Forms.TextBox txtfacultad;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.TextBox txtcoord;
        private System.Windows.Forms.TextBox txtCtedratic;
    }
}