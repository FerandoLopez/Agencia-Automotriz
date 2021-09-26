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
    public partial class FrmHerramientas : Form
    {
        private ManejadorHerramientas _herramientaM;
        public static List<Herramienta> lista = new List<Herramienta>();
        public FrmHerramientas()
        {
            InitializeComponent();
            _herramientaM = new ManejadorHerramientas();
        }

        public void CargarHerramienta(string filtro)
        {
            dtgHerramientas.DataSource = _herramientaM.ObtenerHerramientas(filtro);
            dtgHerramientas.AutoResizeColumns();
        }
        private void EliminarHerramienta()
        {
            if (MessageBox.Show("Desea eliminar la herraienta seleccionada", "Eliminar HERRAMINETA", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var producto = dtgHerramientas.CurrentRow.Cells["Id"].Value.ToString();
                _herramientaM.EliminarHerramienta(producto);
            }
        }
        private void Limpiar()
        {
            txtBuscar.Text = "";
        }

        public List<Herramienta> Datos()
        {
            var lista = new List<Herramienta>();
            var herramienta = new Herramienta();
            herramienta.Idherramienta = int.Parse(dtgHerramientas.CurrentRow.Cells["Id"].Value.ToString());
            herramienta.Codigoherramienta = dtgHerramientas.CurrentRow.Cells["CodigoHerramienta"].Value.ToString();
            herramienta.Nombre = dtgHerramientas.CurrentRow.Cells["Nombre"].Value.ToString();
            herramienta.Medida = dtgHerramientas.CurrentRow.Cells["Medida"].Value.ToString();
            herramienta.Marca = dtgHerramientas.CurrentRow.Cells["Marca"].Value.ToString();
            herramienta.Descripcion = dtgHerramientas.CurrentRow.Cells["Descripcion"].Value.ToString();

            lista.Add(herramienta);

            return lista;
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {
            {
                Limpiar();
                CargarHerramienta("");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarHerramienta();
            CargarHerramienta("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarHerramienta(txtBuscar.Text);
        }

        private void FrmHerramientas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void dtgHerramientas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var info = (Herramienta)dtgHerramientas.CurrentRow.DataBoundItem;
            lista = Datos();
            FrmAgregarHerramienta m = new FrmAgregarHerramienta(info);
            m.FormClosing += FrmHerramientas_FormClosing;
            m.Show();
            Hide();
        }

        private void FrmHerramientas_FormClosing(object sender, FormClosingEventArgs e)
        {
            CargarHerramienta("");
            Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarHerramienta m = new FrmAgregarHerramienta();
            m.FormClosing += FrmHerramientas_FormClosing;
            m.ShowDialog();
            Hide();
        }
    }
}
