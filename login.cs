﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PROYECTOFINALPROGRA1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text.Trim();
            string password = txtcontrasena.Text.Trim();

            if (usuario == "Keily" && password == "123")
            {
                // Oculta el formulario actual
                this.Hide();

                // Crea una instancia del siguiente formulario
                //Form2 form2 = new Form2();

                // Muestra el siguiente formulario
                //form2.Show();
                Console.WriteLine("el crud se abrio correctamente");
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos. Por favor, inténtelo nuevamente.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontrasena.Clear();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro registro = new Registro();
            registro.Show();
        }
    }
}
