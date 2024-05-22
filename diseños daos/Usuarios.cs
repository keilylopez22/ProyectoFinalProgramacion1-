using PROYECTOFINALPROGRA1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINALPROGRA1
{
    public partial class Usuarios : Form
    {
        private bool esNuevo = false;
        public Usuarios()
        {
            InitializeComponent();
        }
        // Este código debe ir en el constructor del formulario Usuarios, después de InitializeComponent()
        
        private void habilitarCampos(bool readOnly)
        {
            txtNombreUsuario.ReadOnly = readOnly;
            
            txtcontrasenaUsuario.ReadOnly = readOnly;
            txtEmailUsuario.ReadOnly = readOnly;
            txtnombreUsuarioBuscar.ReadOnly = readOnly;
            txtIdUsuarioBuscar.ReadOnly = readOnly;
        }
        private void listarUsuarios()
        {
            Dao dao =new Dao();
            DgvUsuarios.DataSource = dao.ObtenerTodosLosUsuarios();
        }
        private void usuarios_Load(object sender, EventArgs e)
        {
            listarUsuarios();

        }
        private void HabilitarbtnGuardarCancelar(bool enable)
        {
            btnGuardarUsuario.Enabled = enable;
            btnCancelarUsuario.Enabled = enable;
        }

       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Clear();
            
            txtcontrasenaUsuario.Clear();
            txtEmailUsuario.Clear();
            txtnombreUsuarioBuscar.Clear();
            txtIdUsuarioBuscar.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //no entendi el porque de darle condicion boolenana a este boton
        private void btnCrear_Click(object sender, EventArgs e)
        {
            habilitarCampos(false);
            HabilitarbtnGuardarCancelar(true);
            esNuevo = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                createUsuari();
            }
            else
            {
                modifyusuari();
            }
            listarUsuarios();
            limpiarCampos();
            HabilitarbtnGuardarCancelar(false);



        }
        
        private void modifyusuari()
        {
            Dao dao = new Dao();
            Usuario usuario = new Usuario();

            DataGridViewRow Fila = DgvUsuarios.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            usuario.id = id;
            usuario.nombre = txtNombreUsuario.Text;
            usuario.contrasena = txtcontrasenaUsuario.Text;
            
            usuario.email = txtEmailUsuario.Text;
           
            dao.ActualizarUsuario(usuario);
            habilitarCampos(true);
            listarUsuarios();

        }
        private void createUsuari()
        {
            Dao dao = new Dao();    
            Usuario usuario = new Usuario();
            usuario.nombre =txtNombreUsuario.Text;
            usuario.contrasena= txtcontrasenaUsuario.Text;
            usuario.email = txtEmailUsuario.Text;
            

            dao.InsertarUsuarios(usuario);
            habilitarCampos(true);
            listarUsuarios();




        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvUsuarios.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            Dao dao = new Dao();
            dao.EliminarUsuarios(id);
            listarUsuarios();
            txtNombreUsuario.Text = (string)Fila.Cells[1].Value;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvUsuarios.SelectedRows[0];
            txtNombreUsuario.Text = (String)Fila.Cells[1].Value;
           
            txtcontrasenaUsuario.Text = (String)Fila.Cells[2].Value;
           
            txtEmailUsuario.Text = (String)Fila.Cells[3].Value;

            habilitarCampos(false);
            HabilitarbtnGuardarCancelar(true);
            esNuevo = false;
        }
        private void limpiarCampos()
        {
            txtNombreUsuario.Text = "";
          
            txtcontrasenaUsuario.Text = "";
            
            txtEmailUsuario.Text = "";
            txtnombreUsuarioBuscar.Text = "";
            txtIdUsuarioBuscar.Text = "";
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
          
                this.Hide();
                // Crea una instancia del formulario Login
                login loginForm = new login();

                // Muestra el formulario Login
                loginForm.Show();

                // Cierra el formulario actual (Usuarios)
                this.Close();
            

        }
    }
}
