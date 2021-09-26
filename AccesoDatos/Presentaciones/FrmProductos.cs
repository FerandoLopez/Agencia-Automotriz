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
        ManejadorProductos mp;
        int i = 0;
        public static Producto pr;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            pr = new Producto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pr._IdProducto = 0;
            pr._Codigobarras = "";
            pr._Nombre = "";
            pr._Descripcion = "";
            pr._Marca = "";
            FrmAgregarProducto ap = new FrmAgregarProducto();
            ap.Dock = DockStyle.Fill;
            ap.ShowDialog();
            Actualizar();
        }

        void Actualizar()
        {
            mp.Mostrar(dtgProductos, txtBuscar.Text);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgProductos.RowCount > 0)
            {
                string r = mp.Borrar(pr);
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

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            pr._IdProducto = int.Parse(dtgProductos.Rows[i].Cells[0].Value.ToString());
            pr._Codigobarras= dtgProductos.Rows[i].Cells[1].Value.ToString();
            pr._Nombre= dtgProductos.Rows[i].Cells[2].Value.ToString();
            pr._Descripcion= dtgProductos.Rows[i].Cells[3].Value.ToString();
            pr._Marca= dtgProductos.Rows[i].Cells[4].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto ap = new FrmAgregarProducto();
            ap.ShowDialog();
            Actualizar();
        }
    }
}
