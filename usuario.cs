using proyecto.GestorDeVentas;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void HabilitarCampos(bool readOnly)
        {
            txtNombre.ReadOnly = readOnly;
            txtApellido.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtTelefono.ReadOnly = readOnly;
            txtDireccion.ReadOnly = readOnly;
            txtProfesion.ReadOnly = readOnly;
        }

        private void ListarEstudiantes()
        {
            Dao dao = new Dao();
            dgvEstudiantes.DataSource = dao.ObtenerTodosLosEstudiantes();
        }

        private void EstudiantesForm_Load(object sender, EventArgs e)
        {
            ListarEstudiantes();
        }

        private void HabilitarDeshabilitarGuardarCancelar(bool enable)
        {
            btnGuardar.Enabled = enable;
            btnCancelar.Enabled = enable;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            HabilitarDeshabilitarGuardarCancelar(true);
            esNuevo = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos(true);
            HabilitarDeshabilitarGuardarCancelar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esNuevo)
            {
                CrearEstudiante();
            }
            else
            {
                ModificarEstudiante();
            }
            ListarEstudiantes();
            LimpiarCampos();
            HabilitarDeshabilitarGuardarCancelar(false);
        }

        private void ModificarEstudiante()
        {
            Dao dao = new Dao();
            Estudiante estudiante = new Estudiante();

            DataGridViewRow fila = dgvEstudiantes.SelectedRows[0];
            int id = (int)fila.Cells[0].Value;
            estudiante.Id = id;
            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.Email = txtEmail.Text;
            estudiante.Telefono = txtTelefono.Text;
            estudiante.Direccion = txtDireccion.Text;
            estudiante.Profesion = txtProfesion.Text;

            dao.ActualizarEstudiante(estudiante);

            HabilitarCampos(true);
            ListarEstudiantes();
        }

        private void CrearEstudiante()
        {
            Dao dao = new Dao();
            Estudiante estudiante = new Estudiante();

            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.Email = txtEmail.Text;
            estudiante.Telefono = txtTelefono.Text;
            estudiante.Direccion = txtDireccion.Text;
            estudiante.Profesion = txtProfesion.Text;

            dao.InsertarEstudiante(estudiante);

            HabilitarCampos(true);
            ListarEstudiantes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvEstudiantes.SelectedRows[0];
            int id = (int)fila.Cells[0].Value;

            Dao dao = new Dao();
            dao.EliminarEstudiante(id);

            ListarEstudiantes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvEstudiantes.SelectedRows[0];
            txtNombre.Text = (string)fila.Cells[1].Value;
            txtApellido.Text = (string)fila.Cells[2].Value;
            txtEmail.Text = (string)fila.Cells[3].Value;
            txtTelefono.Text = (string)fila.Cells[4].Value;
            txtDireccion.Text = (string)fila.Cells[5].Value;
            txtProfesion.Text = (string)fila.Cells[6].Value;

            HabilitarCampos(false);
            HabilitarDeshabilitarGuardarCancelar(true);
            esNuevo = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtProfesion.Text = "";
        }
    }
}
