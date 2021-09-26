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
        private ManejadorProductos _productosManejador;
        private Producto _productos;
        private bool banderaGuardar;
        public FrmAgregarProducto()
        {
            InitializeComponent();
            _productosManejador = new ManejadorProductos();
            _productos = new Producto();
            banderaGuardar = true;
        }

        public FrmAgregarProducto(Producto p)
        {
            InitializeComponent();
            _productosManejador = new ManejadorProductos();
            _productos = new Producto();
            banderaGuardar = false;
            txtCodigoBarra.Focus();
            _productos = p;
            txtCodigoBarra.Text = _productos.Codigobarras;
            txtNombre.Text = _productos.Nombre;
            txtDescripcion.Text = _productos.Descripcion;
            txtMarca.Text = _productos.Marca;
        }

        private void LimpiarCuadros()
        {
            txtCodigoBarra.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
        }

        private void Botonera(Boolean guardar, Boolean cancelar)
        {
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
        }

        private void ActualizarProducto()
        {
            _productosManejador.ActualizarProducto(new Producto
            {
                Codigobarras = txtCodigoBarra.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Marca = txtMarca.Text
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                GuardarProducto();
                LimpiarCuadros();
                Close();
            }
            else
            {
                ActualizarProducto();
                LimpiarCuadros();
                Close();
            }
        }

        private void GuardarProducto()
        {
            _productos.Codigobarras = txtCodigoBarra.Text;
            _productos.Nombre = txtNombre.Text;
            _productos.Descripcion = txtDescripcion.Text;
            _productos.Marca = txtMarca.Text;


            _productosManejador.GuardarProducto(_productos);

        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            txtCodigoBarra.Focus();
            Botonera(true, true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
