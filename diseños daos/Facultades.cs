using PROYECTOFINALPROGRA1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINALPROGRA1.diseños_daos
{
    public partial class Facultades : Form
    {
        private bool esNuevoFacultad = false;
        public Facultades()
        {
            
            InitializeComponent();
        }
        private void HabilitarCamposFacultad(bool readOnly)
        {
            txtNombreFacultad.ReadOnly = readOnly;
            txtCoordinadorDeFacultad.ReadOnly = readOnly;
            txtnombreFacultadBuscar.ReadOnly = readOnly;    
        }
        private void LimpiarCamposFacultad()
        {
            txtNombreFacultad.Text = "";
            txtnombreFacultadBuscar.Text = "";
            txtCoordinadorDeFacultad.Text = "";

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            LimpiarCamposFacultad();

        }
        private void ListarFacultades()
        {
            DaoFacultad daoFacultad = new DaoFacultad();
            DgvFacultades.DataSource = daoFacultad.ObtenerTodasLasFacultades();

        }
        private void HabDeshabGuardarCancelarrFacultades(bool enable)
        {
            btnGuardarFacultad.Enabled = enable;
            btnCancelarDeFacultad.Enabled = enable;

        }

        private void Facultades_Load(object sender, EventArgs e)
        {
            ListarFacultades();
        }
        private void modifyFacultad()
        {
            DaoFacultad daoFacultad = new DaoFacultad();
            Facultad facultad = new Facultad();

            DataGridViewRow Fila = DgvFacultades.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            facultad.id = id;
            facultad.nombre =txtNombreFacultad.Text;
            facultad.coordinador = txtCoordinadorDeFacultad.Text;
            daoFacultad.ActualizarFacultad(facultad);
            HabilitarCamposFacultad(true);
            ListarFacultades();
        }
        private void createFacultad()
        {
            DaoFacultad daoFacultad = new DaoFacultad();
            Facultad facultad = new Facultad();
            facultad.nombre = txtNombreFacultad.Text;
            facultad.coordinador = txtCoordinadorDeFacultad.Text;
            daoFacultad.Insertarfacultad(facultad);
            HabilitarCamposFacultad(true);
            ListarFacultades();

        }

        private void btnCrearFacultad_Click(object sender, EventArgs e)
        {
            HabilitarCamposFacultad(false);
            HabDeshabGuardarCancelarrFacultades(true);
            esNuevoFacultad = true;


        }

        private void btnGuardarFacultad_Click(object sender, EventArgs e)
        {
            if (esNuevoFacultad)
            {
                createFacultad();

            }
            else
            {
                modifyFacultad();
                
            }
            ListarFacultades();
            LimpiarCamposFacultad();
            HabDeshabGuardarCancelarrFacultades(false);
        }

        private void btnActualizarFacultad_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvFacultades.SelectedRows[0];
            txtNombreFacultad.Text = (String)Fila.Cells[1].Value;
            txtCoordinadorDeFacultad.Text = (String)Fila.Cells[2].Value;
            HabilitarCamposFacultad(false);
            HabDeshabGuardarCancelarrFacultades (true);
            esNuevoFacultad = false;

        }

        private void btneliminarFacultad_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvFacultades.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            DaoFacultad daoFacultad = new DaoFacultad();
            daoFacultad.EliminarFacultad(id);
            ListarFacultades();
        }

        private void btnCancelarDeFacultad_Click(object sender, EventArgs e)
        {
            LimpiarCamposFacultad();
            HabilitarCamposFacultad(true);
            HabDeshabGuardarCancelarrFacultades(false);

        }
    }
}
