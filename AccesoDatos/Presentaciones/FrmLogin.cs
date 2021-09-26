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
using AccesoDatos;

namespace Presentaciones
{
    public partial class FrmLogin : Form
    {
        Conexion c = new Conexion("localhost", "root", "12345", "agenciaautomotriz", 3306);
        ManejadorLogin log;
        public FrmLogin()
        {
            InitializeComponent();
            log = new ManejadorLogin();
        }

        void Logear()
        {
            int valor = log.ObtenerLogins(txtUser.Text, txtPassword.Text);
            if (valor == 1)
            {

                var permiso = c.Permiso(string.Format("select id_tipo from usuarios where Nombre = '{0}'", txtUser.Text));
                int idTipo = int.Parse(permiso);
                FrmPrincipal p = new FrmPrincipal(idTipo);
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

     
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Logear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
