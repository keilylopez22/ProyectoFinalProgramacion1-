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

namespace PROYECTOFINALPROGRA1.diseños_daos
{
    public partial class Coordinadores : Form
    {
        private bool esNuevoCoordinadores = false;
        public Coordinadores()
        {
            InitializeComponent();
        }
        private void HabilitarCamposCoordinadores(bool readOnly)
        {
            txtNombreCoordinador.ReadOnly = readOnly;

            txtApellidosCoordinador.ReadOnly = readOnly;
            txtemailCoordinador.ReadOnly = readOnly;
            txttelefonoCoordinador.ReadOnly = readOnly;
            txtdireccionCoordinador.ReadOnly = readOnly;
            txtprofesioncoordinador.ReadOnly = readOnly;
            txtfacultadCoordinador.ReadOnly = readOnly;
            txtnacimientoCoordinador.ReadOnly = readOnly;
            txtNombreCoordinadorBuscar.ReadOnly = readOnly;
        }
        private void ListarCoordinadores()
        {
            DaoCoordinador daoCoordinador = new DaoCoordinador();
            DgvCoordinadores.DataSource = daoCoordinador.ObtenerTodosLosCoordinadores();


        }

        private void Coordinadores_Load(object sender, EventArgs e)
        {
            ListarCoordinadores();
        }
        private void HabDeshabGuardarCancelarCoordinadores(bool enable)
        {
            btnGuardarCoordinador.Enabled = enable;
            btnCancelarDelCoordinador.Enabled = enable;

        }

        private void btnCrearCoordinador_Click(object sender, EventArgs e)
        {
            HabilitarCamposCoordinadores(false);
            HabDeshabGuardarCancelarCoordinadores(true);
            esNuevoCoordinadores = true;
        }

        private void btnCancelarDelCoordinador_Click(object sender, EventArgs e)
        {
            HabilitarCamposCoordinadores(true);
            LimpiarCamposCoordinador();
            HabDeshabGuardarCancelarCoordinadores(false );
        }
        private void LimpiarCamposCoordinador()
        {
            txtNombreCoordinador.Text = " ";
            txtApellidosCoordinador.Text = " ";
            txtemailCoordinador.Text = " ";
            txttelefonoCoordinador.Text = " ";
            txtdireccionCoordinador.Text = " ";
            txtprofesioncoordinador.Text = " ";
            txtfacultadCoordinador.Text = " ";
            txtnacimientoCoordinador.Text = " ";
            txtNombreCoordinadorBuscar.Text = " ";

        }

        private void btnGuardarCoordinador_Click(object sender, EventArgs e)
        {
            if (esNuevoCoordinadores)
            {
                createCoordinad();
            }
            else
            {
                modifyCoordinad();
            }
            ListarCoordinadores();
            LimpiarCamposCoordinador();
            HabDeshabGuardarCancelarCoordinadores(true );

        }
        private void createCoordinad()
        {
            DaoCoordinador daoCoordinador = new DaoCoordinador();
            Coordinador coordinador = new Coordinador();


            coordinador.nombre = txtNombreCoordinador.Text;
            coordinador.apellido = txtApellidosCoordinador.Text;
            coordinador.email = txtemailCoordinador.Text;
            coordinador.telefono = txttelefonoCoordinador.Text;
            coordinador.direccion = txtdireccionCoordinador.Text;
            coordinador.profesion = txtprofesioncoordinador.Text;
            coordinador.facultad = txtfacultadCoordinador.Text;
            coordinador.profesion = txtprofesioncoordinador.Text;




            DateTime fechadenacimiento;
            if (DateTime.TryParse(txtnacimientoCoordinador.Text, out fechadenacimiento))
            {
                coordinador.fechadenacimiento = fechadenacimiento;
            }
            else
            {
                //si la conversion falla
                MessageBox.Show("la fecha de nacimiento no es valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            daoCoordinador.InsertarCoordinador(coordinador);
            HabilitarCamposCoordinadores(true);
            ListarCoordinadores();

        }
        private void modifyCoordinad()
        {
            DaoCoordinador daoCoordinador = new DaoCoordinador();
            Coordinador coordinador = new Coordinador();

            DataGridViewRow Fila = DgvCoordinadores.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            coordinador.id = id;



            coordinador.nombre = txtNombreCoordinador.Text;
            coordinador.apellido = txtApellidosCoordinador.Text;
            coordinador.email = txtemailCoordinador.Text;
            coordinador.telefono = txttelefonoCoordinador.Text;
            coordinador.direccion = txtdireccionCoordinador.Text;
            coordinador.profesion = txtprofesioncoordinador.Text;
            coordinador.facultad = txtfacultadCoordinador.Text;
            coordinador.profesion = txtprofesioncoordinador.Text;

            DateTime fechadenacimiento;
            if (DateTime.TryParse(txtnacimientoCoordinador.Text, out fechadenacimiento))
            {
                coordinador.fechadenacimiento = fechadenacimiento;
            }
            else
            {
                //si la conversion falla
                MessageBox.Show("la fecha de nacimiento no es valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            daoCoordinador.ActualizarCoordinador(coordinador);
            HabilitarCamposCoordinadores(true);
            ListarCoordinadores();


        }

       
        private void btneliminarCoordinador_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila =  DgvCoordinadores.SelectedRows[0];
            int id =(int)Fila.Cells[0].Value;
            DaoCoordinador daoCoordinador = new DaoCoordinador();
            daoCoordinador.EliminarCoordinador(id);
            ListarCoordinadores();
        }

        private void btnActualizarCoordinador_Click(object sender, EventArgs e)
        {

            DataGridViewRow Fila = DgvCoordinadores.SelectedRows[0];
            txtNombreCoordinador.Text = (String)Fila.Cells[1].Value;
            txtApellidosCoordinador.Text = (String)Fila.Cells[2].Value;
            txtemailCoordinador.Text = (String)Fila.Cells[3].Value;
            txttelefonoCoordinador.Text = (String)Fila.Cells[4].Value;
            txtdireccionCoordinador.Text = (String)Fila.Cells[5].Value;
            txtprofesioncoordinador.Text = (String)Fila.Cells[6].Value;
            txtfacultadCoordinador.Text = (String)Fila.Cells[6].Value;
            txtnacimientoCoordinador.Text = (String)Fila.Cells[6].Value;
            HabilitarCamposCoordinadores(false);
            
            HabDeshabGuardarCancelarCoordinadores(true);
            esNuevoCoordinadores = false;


        }
    }
}
