namespace PROYECTOFINALPROGRA1
{
    partial class Usuarios
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
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.txtcontrasenaUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupListar = new System.Windows.Forms.GroupBox();
            this.txtIdUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombreUsuarioBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnLimpiarDeUsuario = new System.Windows.Forms.Button();
            this.btnCancelarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btneliminarUsuario = new System.Windows.Forms.Button();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorparaUsuario = new System.Windows.Forms.Button();
            this.groupDatos.SuspendLayout();
            this.groupListar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.txtEmail);
            this.groupDatos.Controls.Add(this.txtEmailUsuario);
            this.groupDatos.Controls.Add(this.txtcontrasenaUsuario);
            this.groupDatos.Controls.Add(this.txtNombreUsuario);
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.label1);
            this.groupDatos.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatos.Location = new System.Drawing.Point(21, 40);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(955, 130);
            this.groupDatos.TabIndex = 0;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "DATOS";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(498, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(42, 15);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Text = "Email:";
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(578, 25);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.ReadOnly = true;
            this.txtEmailUsuario.Size = new System.Drawing.Size(371, 22);
            this.txtEmailUsuario.TabIndex = 9;
            // 
            // txtcontrasenaUsuario
            // 
            this.txtcontrasenaUsuario.Location = new System.Drawing.Point(99, 92);
            this.txtcontrasenaUsuario.Name = "txtcontrasenaUsuario";
            this.txtcontrasenaUsuario.Size = new System.Drawing.Size(371, 22);
            this.txtcontrasenaUsuario.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(99, 30);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ReadOnly = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(371, 22);
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
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
            // groupListar
            // 
            this.groupListar.Controls.Add(this.txtIdUsuarioBuscar);
            this.groupListar.Controls.Add(this.btnBuscarUsuario);
            this.groupListar.Controls.Add(this.label8);
            this.groupListar.Controls.Add(this.txtnombreUsuarioBuscar);
            this.groupListar.Controls.Add(this.label7);
            this.groupListar.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupListar.Location = new System.Drawing.Point(21, 187);
            this.groupListar.Name = "groupListar";
            this.groupListar.Size = new System.Drawing.Size(958, 78);
            this.groupListar.TabIndex = 1;
            this.groupListar.TabStop = false;
            this.groupListar.Text = "BUSCAR";
            // 
            // txtIdUsuarioBuscar
            // 
            this.txtIdUsuarioBuscar.Location = new System.Drawing.Point(559, 39);
            this.txtIdUsuarioBuscar.Name = "txtIdUsuarioBuscar";
            this.txtIdUsuarioBuscar.Size = new System.Drawing.Size(243, 22);
            this.txtIdUsuarioBuscar.TabIndex = 11;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(846, 42);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 8;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Id:";
            // 
            // txtnombreUsuarioBuscar
            // 
            this.txtnombreUsuarioBuscar.Location = new System.Drawing.Point(121, 35);
            this.txtnombreUsuarioBuscar.Name = "txtnombreUsuarioBuscar";
            this.txtnombreUsuarioBuscar.Size = new System.Drawing.Size(371, 22);
            this.txtnombreUsuarioBuscar.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvUsuarios);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 178);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LISTAR";
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
            this.DgvUsuarios.Size = new System.Drawing.Size(952, 157);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLimpiarDeUsuario
            // 
            this.btnLimpiarDeUsuario.Location = new System.Drawing.Point(1041, 108);
            this.btnLimpiarDeUsuario.Name = "btnLimpiarDeUsuario";
            this.btnLimpiarDeUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarDeUsuario.TabIndex = 2;
            this.btnLimpiarDeUsuario.Text = "Limpiar";
            this.btnLimpiarDeUsuario.UseVisualStyleBackColor = true;
            this.btnLimpiarDeUsuario.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelarUsuario
            // 
            this.btnCancelarUsuario.Location = new System.Drawing.Point(436, 272);
            this.btnCancelarUsuario.Name = "btnCancelarUsuario";
            this.btnCancelarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarUsuario.TabIndex = 3;
            this.btnCancelarUsuario.Text = "Cancelar";
            this.btnCancelarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(120, 272);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 4;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(21, 271);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnCrearUsuario.TabIndex = 5;
            this.btnCrearUsuario.Text = "Crear";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btneliminarUsuario
            // 
            this.btneliminarUsuario.Location = new System.Drawing.Point(323, 272);
            this.btneliminarUsuario.Name = "btneliminarUsuario";
            this.btneliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btneliminarUsuario.TabIndex = 6;
            this.btneliminarUsuario.Text = "eliminar";
            this.btneliminarUsuario.UseVisualStyleBackColor = true;
            this.btneliminarUsuario.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(223, 272);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUsuario.TabIndex = 7;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAnteriorparaUsuario
            // 
            this.btnAnteriorparaUsuario.Location = new System.Drawing.Point(1041, 448);
            this.btnAnteriorparaUsuario.Name = "btnAnteriorparaUsuario";
            this.btnAnteriorparaUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorparaUsuario.TabIndex = 9;
            this.btnAnteriorparaUsuario.Text = "Anterior";
            this.btnAnteriorparaUsuario.UseVisualStyleBackColor = true;
            this.btnAnteriorparaUsuario.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 620);
            this.Controls.Add(this.btnAnteriorparaUsuario);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.btneliminarUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.btnCancelarUsuario);
            this.Controls.Add(this.btnLimpiarDeUsuario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupListar);
            this.Controls.Add(this.groupDatos);
            this.Name = "Usuarios";
            this.Text = "usuarios";
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.groupListar.ResumeLayout(false);
            this.groupListar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.GroupBox groupListar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcontrasenaUsuario;
        private System.Windows.Forms.TextBox txtnombreUsuarioBuscar;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button btnLimpiarDeUsuario;
        private System.Windows.Forms.Button btnCancelarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btneliminarUsuario;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnAnteriorparaUsuario;
        private System.Windows.Forms.TextBox txtIdUsuarioBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox txtEmailUsuario;
    }
}