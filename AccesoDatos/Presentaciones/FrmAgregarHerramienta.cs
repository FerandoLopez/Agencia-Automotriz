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
    public partial class FrmAgregarHerramienta : Form
    {
        ManejadorHerramientas mh;
        public FrmAgregarHerramienta()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
            if (!FrmHerramientas.h._IdHerramienta.Equals(""))
            {
                txtCodigoHerramienta.Text = FrmHerramientas.h._CodigoHerramienta;
                txtNombre.Text =FrmHerramientas.h._Nombre;
                txtMedida.Text = FrmHerramientas.h._Medida;
                txtMarca.Text = FrmHerramientas.h._Marca;
                txtDescripcion.Text = FrmHerramientas.h._Descripcion;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmHerramientas.h._IdHerramienta == 0)
            {
                MessageBox.Show(mh.Guardar(new Herramienta(FrmHerramientas.h._IdHerramienta, txtCodigoHerramienta.Text, txtNombre.Text, txtMedida.Text, txtMarca.Text, txtDescripcion.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(mh.Editar(new Herramienta(FrmHerramientas.h._IdHerramienta, txtCodigoHerramienta.Text, txtNombre.Text, txtMedida.Text, txtMarca.Text, txtDescripcion.Text)));
            }
            Close();
        }
    }
}
