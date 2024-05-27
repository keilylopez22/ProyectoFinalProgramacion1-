using PROYECTOFINALPROGRA1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINALPROGRA1.diseños_daos
{
    public partial class Estudiantes : Form
    {
        private bool esNuevoEstudiantes = false;
        public Estudiantes()
        {
            InitializeComponent();
        }
        private void HabilitarCamposEstudiantes(bool readOnly)
        {
            txtNombreEstudiante.ReadOnly = readOnly;
            txtApellidosEstudiante.ReadOnly = readOnly;
            txttelefonoEstudiante.ReadOnly = readOnly;
            txtdireccionEstudiante.ReadOnly = readOnly;
            txtfacultadDeEstudiante.ReadOnly = readOnly;
            txtnacimientoEstudiante.ReadOnly = readOnly;
            txtnombreEstudianteBuscar.ReadOnly = readOnly;
            txtprofesiondelestudiante.ReadOnly = readOnly;
        }
        private void ListarEstudiantes()
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            DgvEstudiantes.DataSource = daoEstudiante.ObtenerTodosLosEstudiantes();

        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
             ListarEstudiantes();
        }
        private void HabDeshabGuardarCncelarEstudiantes(bool enable)
        {
            btnGuardarEstudiante.Enabled = enable;
            btnCancelardeEstudiante.Enabled =(enable);
        }
       

        private void btnCrearEstudiante_Click(object sender, EventArgs e)
        {
            HabilitarCamposEstudiantes(false);
            HabDeshabGuardarCncelarEstudiantes(true);
            esNuevoEstudiantes = true;
        }

       

        private void btnGuardarEstudiante_Click(object sender, EventArgs e)
        {
            if (esNuevoEstudiantes)
            {
                createEstudiant();
            }
            else
            {
                modyfyEstudiant();
            }
            ListarEstudiantes();
            limpiarCamposEstudiantes();
            HabDeshabGuardarCncelarEstudiantes(false) ;

        }
        private void modyfyEstudiant()
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            Estudiante estudiante = new Estudiante();


            DataGridViewRow Fila = DgvEstudiantes.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            estudiante.id = id;
            estudiante.nombre = txtNombreEstudiante.Text;
            estudiante.apellido = txtApellidosEstudiante.Text;
            estudiante.email = txtApellidosEstudiante.Text;
            estudiante.direccion = txtdireccionEstudiante.Text;
            estudiante.telefono = txttelefonoEstudiante.Text;
            estudiante.facultad = txtfacultadDeEstudiante.Text;


            DateTime fechadenacimiento;
            if (DateTime.TryParse(txtnacimientoEstudiante.Text, out fechadenacimiento))

            {
                estudiante.fechadenacimiento = fechadenacimiento;
            }
            else
            {
                MessageBox.Show("El formato de fecha no es valido");
                return;
            }
            daoEstudiante.ActualizarEstudiante(estudiante);
            HabilitarCamposEstudiantes(true) ;
            ListarEstudiantes(); 



        }
        private void createEstudiant()
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            Estudiante estudiante = new Estudiante();


            estudiante.nombre = txtNombreEstudiante.Text;
            estudiante.apellido = txtApellidosEstudiante.Text;
            estudiante.email = txtApellidosEstudiante.Text;
            estudiante.direccion = txtdireccionEstudiante.Text;
            estudiante.profesion = txtprofesiondelestudiante.Text;
            estudiante.telefono = txttelefonoEstudiante.Text;
            estudiante.facultad = txtfacultadDeEstudiante.Text;

            DateTime fechadenacimiento;
            if (DateTime.TryParse(txtnacimientoEstudiante.Text, out fechadenacimiento))
            {
                estudiante.fechadenacimiento = fechadenacimiento;
            }
            else
            {
                //si la conversion falla
                MessageBox.Show("la fecha de nacimiento no es valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            daoEstudiante.InsertarEstudiante(estudiante);
            HabilitarCamposEstudiantes(true);
            ListarEstudiantes();



        }
        private void btneliminarEstudiante_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvEstudiantes.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            DaoEstudiante daoEstudiante = new DaoEstudiante();
            daoEstudiante.EliminarEstudiante(id);
            ListarEstudiantes();
        }
        private void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvEstudiantes.SelectedRows[0];
            txtNombreEstudiante.Text = (String)Fila.Cells[1].Value;
            txtApellidosEstudiante.Text =  (String)Fila.Cells[2].Value;
            txtemailEstudiante.Text = (String)Fila.Cells[3].Value;
            txttelefonoEstudiante.Text = (String)Fila.Cells[4].Value;
            txtdireccionEstudiante.Text = (String)Fila.Cells[5].Value;
            txtprofesiondelestudiante.Text = (String)Fila.Cells[6].Value;
            txtfacultadDeEstudiante.Text = (String)Fila.Cells[7].Value;
            txtnacimientoEstudiante.Text = ((DateTime)Fila.Cells[8].Value).ToString();
            HabilitarCamposEstudiantes(false);
            HabDeshabGuardarCncelarEstudiantes(true);
            esNuevoEstudiantes = false;



        }
        private void limpiarCamposEstudiantes()
        {
            txtNombreEstudiante.Clear();
            txtApellidosEstudiante.Clear();
            txtemailEstudiante.Clear();
            txttelefonoEstudiante.Clear();
            txtdireccionEstudiante.Clear();
            txtprofesiondelestudiante.Clear();
            txtfacultadDeEstudiante.Clear();
            txtnacimientoEstudiante.Clear();
            txtnombreEstudianteBuscar.Clear();
            txtIdEstudianteBuscar.Clear();
        }
        private void btnLimpiarDeEstudiante_Click(object sender, EventArgs e)
        {
           limpiarCamposEstudiantes();
        }

        private void BuscarEstudiantes(String nombre)
        {
            DaoEstudiante daoEstudiante = new DaoEstudiante();

        }
       
    }
}
 