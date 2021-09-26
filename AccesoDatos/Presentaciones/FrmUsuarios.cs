using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;
using Entidades;

namespace Presentaciones
{


    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        int i = 0;
        public static Usuario us;
        public FrmUsuarios(int idTipo)
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            us = new Usuario();
            if (idTipo == 1)
            {
                this.btnAgregar.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            if (idTipo == 2)
            {
                this.btnAgregar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }
            if (idTipo == 3)
            {
                this.btnAgregar.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            if (idTipo == 4)
            {
                this.btnAgregar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = true;
            }
            if (idTipo == 5)
            {
                this.btnAgregar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            us._IdUsuario = 0;
            us._Nombre = "";
            us._Contrasenia = "";
            us._ApellidoP = "";
            us._ApellidoM = "";
            us._FechaNacimiento = "";
            us._RFC = "";
            us._Id_Tipo = 0;
            FrmAgregarUsuario au = new FrmAgregarUsuario();
            au.Dock = DockStyle.Fill;
            au.ShowDialog();
            Actualizar();
        }


        void Actualizar()
        {
            mu.Mostrar(dtgUsuarios, txtBuscar.Text);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgUsuarios.RowCount > 0)
            {
                string r = mu.Borrar(us);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un registro");
            }
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            us._IdUsuario = int.Parse(dtgUsuarios.Rows[i].Cells[0].Value.ToString());
            us._Nombre = dtgUsuarios.Rows[i].Cells[1].Value.ToString();
            us._Contrasenia = dtgUsuarios.Rows[i].Cells[2].Value.ToString();
            us._ApellidoP = dtgUsuarios.Rows[i].Cells[3].Value.ToString();
            us._ApellidoM = dtgUsuarios.Rows[i].Cells[4].Value.ToString();
            us._FechaNacimiento = dtgUsuarios.Rows[i].Cells[5].Value.ToString();
            us._RFC = dtgUsuarios.Rows[i].Cells[6].Value.ToString();
            us._Id_Tipo = int.Parse(dtgUsuarios.Rows[i].Cells[7].Value.ToString());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario au = new FrmAgregarUsuario();
            au.ShowDialog();
            Actualizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
