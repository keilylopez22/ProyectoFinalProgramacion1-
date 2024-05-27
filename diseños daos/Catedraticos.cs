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
    public partial class Catedraticos : Form
    {
        private bool esNuevoCatedraticos = false;
        public Catedraticos()
        {
            InitializeComponent();
        }
        private void HabilitarCamposCatedraticos(bool readOnly)
        {
            txtNombreCatedratico.ReadOnly = readOnly;
            txtApellidosCatedratico.ReadOnly = readOnly;
            txtEMAILCatedratico.ReadOnly = readOnly;
            txttelefonocatedratico.ReadOnly = readOnly;
            txtdireccionCatedratico.ReadOnly= readOnly;
            txtprofesionCatedratico.ReadOnly = readOnly;
            txtFacultadDeCatedratico.ReadOnly = readOnly;
           
            txtnacimientoCatedratico.ReadOnly = readOnly;
        }
        private void ListarCatedraticos()
        {
            DaoCatedratico daocatedratico = new DaoCatedratico();
            DgvCatedraticos.DataSource = daocatedratico.ObtenerTodosLosCatedraticos();

        }

       
        private void HabDeshabGuardarCncelarCatedraticos(bool enable)
        {
            btnGuardarCatedratico.Enabled = enable;
            btnCancelardeCatedratico.Enabled = enable;
        }


       


        
        private void modyfyCatedratic()
        {
            DaoCatedratico daoCatedratico = new DaoCatedratico();
            Catedratico catedraticos = new Catedratico();


            DataGridViewRow Fila = DgvCatedraticos.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;

            catedraticos.Id_Catedratico = id;

            catedraticos.Nombre_Catedratico= txtNombreCatedratico.Text;
            catedraticos.Apellido_Catedratico = txtApellidosCatedratico.Text;
            catedraticos.Email_Catedratico = txtEMAILCatedratico.Text;
            catedraticos.Telefono_Catedratico = txttelefonocatedratico.Text;
            catedraticos.Direccion_Catedratico = txtdireccionCatedratico.Text;
            catedraticos.Profesion_Catedratico = txtprofesionCatedratico.Text;
            catedraticos.Facultad_Catedratico = txtFacultadDeCatedratico.Text;

            DateTime Fechadenacimiento_Catedratico;
            if (DateTime.TryParse(txtnacimientoCatedratico.Text, out Fechadenacimiento_Catedratico))

            {
                catedraticos.Fechadenacimiento_Catedratico = Fechadenacimiento_Catedratico;
            }
            else
            {
                MessageBox.Show("El formato de fecha no es valido");
                return;
            }
            daoCatedratico.ActualizarCatedratico(catedraticos );
            HabilitarCamposCatedraticos(true);
            ListarCatedraticos();



        }
        private void createCatedratic()
        {
            DaoCatedratico daoCatedratico = new DaoCatedratico();
            Catedratico catedratico = new Catedratico();

            catedratico.Nombre_Catedratico = txtNombreCatedratico.Text;
            catedratico.Apellido_Catedratico = txtApellidosCatedratico.Text;
            catedratico.Email_Catedratico = txtEMAILCatedratico.Text; 
            catedratico.Telefono_Catedratico = txttelefonocatedratico.Text;
            catedratico.Direccion_Catedratico = txtdireccionCatedratico.Text;
            catedratico.Profesion_Catedratico = txtprofesionCatedratico.Text;
            catedratico.Facultad_Catedratico = txtFacultadDeCatedratico.Text;

            DateTime Fechadenacimiento_Catedratico;
            if (DateTime.TryParse(txtnacimientoCatedratico.Text, out Fechadenacimiento_Catedratico))
            {
                catedratico.Fechadenacimiento_Catedratico = Fechadenacimiento_Catedratico;
            }
            else
            {
                //si la conversion falla
                MessageBox.Show("la fecha de nacimiento no es valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            daoCatedratico.InsertarCatedratico(catedratico);
            HabilitarCamposCatedraticos(true);
            ListarCatedraticos();



        }

        private void Catedraticos_Load(object sender, EventArgs e)
        {
            ListarCatedraticos();
        }

        private void btnCrearCatedratico_Click(object sender, EventArgs e)
        {
            HabilitarCamposCatedraticos(false);
            HabDeshabGuardarCncelarCatedraticos(true);
            esNuevoCatedraticos = true;
        }

        private void btnCancelardeCatedratico_Click(object sender, EventArgs e)
        {
            limpiarCamposCatedraticos();
            HabilitarCamposCatedraticos(true);
            HabDeshabGuardarCncelarCatedraticos(false) ;
        }
        private void limpiarCamposCatedraticos()
        {
           txtNombreCatedratico.Text ="";
           txtApellidosCatedratico.Text="";
           txtdireccionCatedratico.Text ="";
           txtEMAILCatedratico.Text = "";
           txtdireccionCatedratico.Text = "";
           txtprofesionCatedratico.Text = "";

           txtFacultadDeCatedratico.Text ="";
           txtnacimientoCatedratico.Text = "";
        }

        

        private void btnActualizarCatedratico_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvCatedraticos.SelectedRows[0];
            txtNombreCatedratico.Text = (String)Fila.Cells[1].Value;
            txtApellidosCatedratico.Text = (String)Fila.Cells[2].Value;
            txtEMAILCatedratico.Text = (String)Fila.Cells[3].Value;
            txttelefonocatedratico.Text = (String)Fila.Cells[4].Value;
            txtdireccionCatedratico.Text = (String)Fila.Cells[5].Value;
            txtprofesionCatedratico.Text = (String)Fila.Cells[6].Value;
            txtFacultadDeCatedratico.Text = (String)Fila.Cells[7].Value;
            txtnacimientoCatedratico.Text = (String)Fila.Cells[8].Value;
        }

        private void btneliminarCatedratico_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvCatedraticos.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            DaoCatedratico daoCatedratico = new DaoCatedratico();
            daoCatedratico.EliminarCatedratico(id);
            ListarCatedraticos();
          

        }

        private void btnGuardarCatedratico_Click(object sender, EventArgs e)
        {
            if (esNuevoCatedraticos)
            {
                createCatedratic();
            }
            else
            {
                modyfyCatedratic();
            }
            ListarCatedraticos();
            limpiarCamposCatedraticos();
            HabDeshabGuardarCncelarCatedraticos(false);
        }
    }
}

