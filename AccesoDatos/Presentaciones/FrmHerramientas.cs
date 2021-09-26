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
        ManejadorHerramientas mh;
        int i = 0;
        public static Herramienta h;
        public FrmHerramientas(int idTipo)
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
            h = new Herramienta();

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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgHerramientas.RowCount > 0)
            {
                string r = mh.Borrar(h);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            h._IdHerramienta = 0;
            h._CodigoHerramienta = "";
            h._Nombre = "";
            h._Medida = "";
            h._Marca = "";
            h._Descripcion = "";
            FrmAgregarHerramienta ah = new FrmAgregarHerramienta();
            ah.ShowDialog();
            Actualizar();
        }
        void Actualizar()
        {
            mh.Mostrar(dtgHerramientas, txtBuscar.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAgregarHerramienta ah = new FrmAgregarHerramienta();
            ah.ShowDialog();
            Actualizar();
        }

        private void dtgHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            h._IdHerramienta=int.Parse(dtgHerramientas.Rows[i].Cells[0].Value.ToString());
            h._CodigoHerramienta= dtgHerramientas.Rows[i].Cells[1].Value.ToString();
            h._Nombre = dtgHerramientas.Rows[i].Cells[2].Value.ToString();
            h._Medida= dtgHerramientas.Rows[i].Cells[3].Value.ToString();
            h._Marca= dtgHerramientas.Rows[i].Cells[4].Value.ToString();
            h._Descripcion= dtgHerramientas.Rows[i].Cells[5].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
