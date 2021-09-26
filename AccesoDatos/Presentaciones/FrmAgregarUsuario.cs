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
using Manejadores;

namespace Presentaciones
{
    public partial class FrmAgregarUsuario : Form
    {
        ManejadorUsuarios mu;
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            if (!FrmUsuarios.us._IdUsuario.Equals(""))
            {
                txtNombre.Text = FrmUsuarios.us._Nombre;
                txtContraseña.Text = FrmUsuarios.us._Contrasenia;
                txtApellidoP.Text = FrmUsuarios.us._ApellidoP;
                txtApellidoM.Text = FrmUsuarios.us._ApellidoM;
                txtNacimiento.Text = FrmUsuarios.us._FechaNacimiento;
                txtRFC.Text = FrmUsuarios.us._RFC;
                cbPermiso.Text = FrmUsuarios.us._Id_Tipo.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.us._IdUsuario == 0)
            {
                MessageBox.Show(mu.Guardar(new Usuario(FrmUsuarios.us._IdUsuario, txtNombre.Text,txtContraseña.Text,txtApellidoP.Text,txtApellidoM.Text,txtNacimiento.Text,txtRFC.Text, int.Parse(cbPermiso.SelectedValue.ToString()))));
                Close();
            }
            else
            {
                MessageBox.Show(mu.Editar(new Usuario(FrmUsuarios.us._IdUsuario, txtNombre.Text, txtContraseña.Text, txtApellidoP.Text, txtApellidoM.Text, txtNacimiento.Text, txtRFC.Text, int.Parse(cbPermiso.SelectedValue.ToString()))));
            }
            Close();
        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            var lista = mu.LlenarCombo();
            cbPermiso.DataSource = lista;
            cbPermiso.ValueMember = "_idpermiso";
            cbPermiso.DisplayMember = "_nombrepermiso";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
