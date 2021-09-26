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

    public partial class FrmAgregarProducto : Form
    {
        ManejadorProductos mp;
        public FrmAgregarProducto()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if (!FrmProductos.pr._IdProducto.Equals(""))
            {
                txtCodigoBarra.Text = FrmProductos.pr._Codigobarras;
                txtNombre.Text = FrmProductos.pr._Nombre;
                txtDescripcion.Text = FrmProductos.pr._Descripcion;
                txtMarca.Text = FrmProductos.pr._Marca;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmProductos.pr._IdProducto == 0)
            {
                MessageBox.Show(mp.Guardar(new Producto(FrmProductos.pr._IdProducto,txtCodigoBarra.Text,txtNombre.Text,txtDescripcion.Text,txtMarca.Text)));
                Close();
            }
            else
            {
                MessageBox.Show(mp.Editar(new Producto(FrmProductos.pr._IdProducto, txtCodigoBarra.Text, txtNombre.Text, txtDescripcion.Text,
                    txtMarca.Text)));
            }
            Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
