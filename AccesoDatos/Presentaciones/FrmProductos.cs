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
    public partial class FrmProductos : Form
    {
        private ManejadorProductos _productoM;
        public static List<Producto> lista = new List<Producto>();
        public FrmProductos()
        {
            InitializeComponent();
            _productoM = new ManejadorProductos();
        }

        public void CargarProductos(string filtro)
        {
            dtgProductos.DataSource = _productoM.ObtenerProducto(filtro);
            dtgProductos.AutoResizeColumns();
        }
        private void EliminarProducto()
        {
            if (MessageBox.Show("Desea eliminar el producto seleccionado", "Eliminar usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var producto = dtgProductos.CurrentRow.Cells["Id"].Value.ToString();
                _productoM.EliminarProducto(producto);
            }
        }
        private void Limpiar()
        {
            txtBuscar.Text = "";
        }

        public List<Producto> Datos()
        {
            var lista = new List<Producto>();
            var producto = new Producto();
            producto.Idproducto = int.Parse(dtgProductos.CurrentRow.Cells["Id"].Value.ToString());
            producto.Codigobarras= dtgProductos.CurrentRow.Cells["CodigoBarras"].Value.ToString();
            producto.Nombre= dtgProductos.CurrentRow.Cells["Nombre"].Value.ToString();
            producto.Descripcion= dtgProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
            producto.Marca= dtgProductos.CurrentRow.Cells["Marca"].Value.ToString();

            lista.Add(producto);

            return lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto m = new FrmAgregarProducto();
            m.FormClosing += FrmProductos_FormClosing;
            m.ShowDialog();
            Hide();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
                Limpiar();
                CargarProductos("");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
            CargarProductos("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text);
        }

        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void dtgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var info = (Producto)dtgProductos.CurrentRow.DataBoundItem;
            lista = Datos();
            FrmAgregarProducto m = new FrmAgregarProducto(info);
            m.FormClosing += FrmProductos_FormClosing;
            m.Show();
            Hide();
        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            CargarProductos("");
            Show();
        }
    }
}
