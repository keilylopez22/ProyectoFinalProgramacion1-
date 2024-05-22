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
    public partial class FRMMenu : Form
    {
        public FRMMenu()
        {
            
            InitializeComponent();
            OcultarSubMenu();
        }

       private void OcultarSubMenu()
        {
            pnlSubMenuCurso.Visible = false;
            pnlSubMenuCatedraticos.Visible = false;
            pnlSubMenuEstudiantes.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            OcultarSubMenu();
            subMenu.Visible = true;
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenuCurso);
        }

        private void btnMenuCatedraticos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenuCatedraticos);

        }

        private void btnMenuEstudiantes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenuEstudiantes);
        }
    }

}
