using PROYECTOFINALPROGRA1.clases.proyecto.GestorDeVentas;
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
            txtNombre.ReadOnly = readOnly;
            txtApellido.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtTelefono.ReadOnly = readOnly;
            txtDireccion.ReadOnly = readOnly;
            txtProfesion.ReadOnly = readOnly;
            txtnom.ReadOnly = readOnly;
            txtId.ReadOnly = readOnly;
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
            btnGuardar.Enabled = enable;
            btnCancelar.Enabled = enable;
        }

       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtProfesion.Clear();
            txtnom.Clear();
            txtId.Clear();
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
            usuario.nombre = txtNombre.Text;
            usuario.contrasena = txtApellido.Text;
            usuario.email = txtEmail.Text;
           
            dao.ActualizarUsuario(usuario);
            habilitarCampos(true);
            listarUsuarios();

        }
        private void createUsuari()
        {
            Dao dao = new Dao();    
            Usuario usuario = new Usuario();
            usuario.nombre =txtNombre.Text;
            usuario.contrasena= txtApellido.Text;
            usuario.email = txtEmail.Text;
            
            dao.insertarUsuarios(usuario);
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
            txtNombre.Text = (string)Fila.Cells[1].Value;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvUsuarios.SelectedRows[0];
            txtNombre.Text = (String)Fila.Cells[1].Value;
            txtApellido.Text= (String)Fila.Cells[2].Value;
            txtEmail.Text = (String)Fila.Cells[3].Value;
            txtTelefono.Text = (String)Fila.Cells[4].Value;
            txtDireccion.Text = (String)Fila.Cells[5].Value;
            txtProfesion.Text = (String)Fila.Cells[6].Value;
            habilitarCampos(false);
            HabilitarbtnGuardarCancelar(true);
            esNuevo = false;
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtProfesion.Text = "";
            txtnom.Text = "";
            txtId.Text = "";
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
