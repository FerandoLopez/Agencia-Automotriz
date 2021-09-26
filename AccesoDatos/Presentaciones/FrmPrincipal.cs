using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentaciones
{
    public partial class FrmPrincipal : Form
    {
        Usuario u;
        int _idTipo;
      //  int tipoUsuario;
        public FrmPrincipal(int idTipo)
        {
            _idTipo = idTipo;
            InitializeComponent();
            u = new Usuario();
           
            if (idTipo == 1)
            {
                this.menuStrip1.Visible = true;
            }
            if (idTipo == 2)
            {
                this.administraciónDeUsuariosToolStripMenuItem.Visible = false;
            }
            if (idTipo == 3)
            {
                this.administraciónDeUsuariosToolStripMenuItem.Visible = false;
            }
            if (idTipo == 4)
            {
                this.administraciónDeUsuariosToolStripMenuItem.Visible = false;
            }
            if (idTipo == 5)
            {
                this.administraciónDeUsuariosToolStripMenuItem.Visible = false;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios u = new FrmUsuarios(_idTipo);
            u.MdiParent = this;
            u.Show();
        }

        private void tsProductos_Click(object sender, EventArgs e)
        {
            FrmProductos p = new FrmProductos(_idTipo);
            p.MdiParent = this;
            p.Show();
        }

        private void tsHerramientas_Click(object sender, EventArgs e)
        {
            FrmHerramientas h = new FrmHerramientas(_idTipo);
            h.MdiParent = this;
            h.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
