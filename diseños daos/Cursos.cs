using PROYECTOFINALPROGRA1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINALPROGRA1.diseños_daos
{
    public partial class CURSOS : Form
    {
        private bool esNuevoCurso = false;
        public CURSOS()
        {
           
            InitializeComponent();
        }
        private void habilitarCamposCursos(bool readOnly)
        {
            txtNombreCurso.ReadOnly = readOnly;
            txtHorarioCurso.ReadOnly = readOnly;
            txtFacultaddelCurso.ReadOnly = readOnly;
            txtNombreCursoBuscar.ReadOnly = readOnly;
        }
        private void listarCursos() 
        {
            DaoCurso daoCurso = new DaoCurso();
            DgvCursos.DataSource = daoCurso.ObtenerTodosLosCursos();
        }

        private void Cursodise_Load(object sender, EventArgs e)
        {
            listarCursos();

        }
        private void HabDeshabGuardarCancelarCurso(bool enable)
        {
            btnGuardarCurso.Enabled = enable;
            btnCancelarDelCurso.Enabled = enable;
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            habilitarCamposCursos(false);
            HabDeshabGuardarCancelarCurso(true);
            esNuevoCurso = true;

        }

        private void btnCancelarDelCurso_Click(object sender, EventArgs e)
        {
            limpiarCamposCursos();
            habilitarCamposCursos(true);
            HabDeshabGuardarCancelarCurso(false);
        }
        private void limpiarCamposCursos()
        {
            txtNombreCurso.Text = " ";
            txtHorarioCurso.Text = " ";
            txtFacultaddelCurso.Text = " ";
            txtNombreCursoBuscar.Text = " ";
        }
        private void modifyCurso()
        {
            DaoCurso daoCurso = new DaoCurso();
            Curso curso = new Curso();

            DataGridViewRow Fila = DgvCursos.SelectedRows[0];
            int id = (int)Fila.Cells[0].Value;
            curso.Id = id;

            curso.Nombre = txtNombreCurso.Text;
            curso.Horario = txtHorarioCurso.Text;
            curso.Facultad = txtFacultaddelCurso.Text;
            daoCurso.ActualizarCursos(curso);
            habilitarCamposCursos(true);
            listarCursos();
        }
        private void createCurso()
        {
            DaoCurso daoCurso = new DaoCurso();
            Curso curso = new Curso();
            curso.Nombre = txtNombreCurso.Text;
            curso.Horario = txtHorarioCurso.Text;
            curso.Facultad = txtFacultaddelCurso.Text;
            daoCurso.InsertarCursos(curso);
            habilitarCamposCursos(true);
            listarCursos();

        }

        private void btnGuardarCurso_Click(object sender, EventArgs e)
        {
            if (esNuevoCurso)
            {
                createCurso();
            }
            else
            {
                modifyCurso();
            }
            listarCursos();
            limpiarCamposCursos();
            HabDeshabGuardarCancelarCurso(false);

        }

        private void btnActualizarCurso_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvCursos.SelectedRows[0];
            txtNombreCurso.Text = (String)Fila.Cells[1].Value;
            txtHorarioCurso.Text = (String)Fila.Cells[2].Value;
            txtFacultaddelCurso.Text = (String)Fila.Cells[3].Value;
            habilitarCamposCursos(false);
            HabDeshabGuardarCancelarCurso(true);
            esNuevoCurso = false;

        }

        private void btneliminarCurso_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = DgvCursos.SelectedRows[0];

            int id = (int)Fila.Cells[0].Value;

            DaoCurso daoCurso = new DaoCurso();
            daoCurso.EliminarCurso(id);

            listarCursos();
        }
    }
}
