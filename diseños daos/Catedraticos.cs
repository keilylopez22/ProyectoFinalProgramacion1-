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
            txtemailCatedratico.ReadOnly = readOnly;
            txttelefonoCatedratico.ReadOnly = readOnly;
            txtdireccionCatedratico.ReadOnly= readOnly;
            txtFacultadDeCatedratico.ReadOnly = readOnly;
            txtedadCatedratico.ReadOnly = readOnly;
        }
        private void ListarCatedraticos()
        {
            DaoCatedratico daocatedratico = new DaoCatedratico();
            DgvCatedraticos.DataSource = daocatedratico.ObtenerTodosLosCatedraticos();

        }

       
        private void HabDeshabGuardarCncelarCatedraticos(bool enable)
        {
            btnGuardarCatedratico.Enabled = enable;
            btnCancelardeCatedratico.Enabled = (enable);
        }


       


        
        private void modyfyCatedratic()
        {
            DaoCatedratico daoCatedratico = new DaoCatedratico();
            Catedratico catedratico = new Catedratico();


            DataGridViewRow Fila = DgvCatedraticos.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            catedratico.id = id;

            catedratico.nombre = txtNombreCatedratico.Text;
            catedratico.email = txtemailCatedratico.Text;
            catedratico.direccion = txtdireccionCatedratico.Text;
            catedratico.telefono = txttelefonoCatedratico.Text;
            catedratico.facultad = txtFacultadDeCatedratico.Text;
            daoCatedratico.ActualizarCatedratico(catedratico );
            HabilitarCamposCatedraticos(true);
            ListarCatedraticos();



        }
        private void createCatedratic()
        {
            DaoCatedratico daoCatedratico = new DaoCatedratico();
            Catedratico catedratico = new Catedratico();

            DataGridViewRow Fila = DgvCatedraticos.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            catedratico.id = id;



            catedratico.nombre = txtNombreCatedratico.Text;
            catedratico.email = txtemailCatedratico.Text;
            catedratico.direccion = txtdireccionCatedratico.Text;
            catedratico.telefono = txttelefonoCatedratico.Text;
            catedratico.facultad = txtFacultadDeCatedratico.Text;
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
           txtemailCatedratico.Text="";
           txtdireccionCatedratico.Text ="";
           txttelefonoCatedratico.Text ="";
           txtFacultadDeCatedratico.Text ="";
        }
    }
}
