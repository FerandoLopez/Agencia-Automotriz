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
        private ManejadorHerramientas _herramientasManejador;
        private Herramienta _herramientas;
        private bool banderaGuardar;
        public FrmAgregarHerramienta()
        {
            InitializeComponent();
            _herramientasManejador = new ManejadorHerramientas();
            _herramientas = new Herramienta();
            banderaGuardar = true;
        }

        public FrmAgregarHerramienta(Herramienta h)
        {
            InitializeComponent();

            _herramientasManejador = new ManejadorHerramientas();
            _herramientas = new Herramienta();
            banderaGuardar = false;
            txtCodigoHerramienta.Focus();
            _herramientas = h;
            txtCodigoHerramienta.Text = _herramientas.Codigoherramienta;
            txtNombre.Text = _herramientas.Nombre;
            txtMedida.Text = _herramientas.Medida;
            txtMarca.Text = _herramientas.Marca;
            txtDescripcion.Text = _herramientas.Descripcion;
        }

        private void LimpiarCuadros()
        {
            txtCodigoHerramienta.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtMedida.Text = "";
        }

        private void Botonera(Boolean guardar, Boolean cancelar)
        {
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
        }

        private void ActualizarHerramienta()
        {
            _herramientasManejador.ActualizarHerramienta(new Herramienta
            {
                Codigoherramienta = txtCodigoHerramienta.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Marca = txtMarca.Text,
                Medida = txtMedida.Text,
            });
        }
        private void GuardarHerramienta()
        {
            _herramientas.Codigoherramienta = txtCodigoHerramienta.Text;
            _herramientas.Nombre = txtNombre.Text;
            _herramientas.Descripcion = txtDescripcion.Text;
            _herramientas.Marca = txtMarca.Text;
            _herramientas.Medida = txtMedida.Text;

            _herramientasManejador.GuardarProducto(_herramientas);

        }

        private void FrmAgregarHerramienta_Load(object sender, EventArgs e)
        {
            txtCodigoHerramienta.Focus();
            Botonera(true, true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar)
            {
                GuardarHerramienta();
                LimpiarCuadros();
                Close();
            }
            else
            {
                ActualizarHerramienta();
                LimpiarCuadros();
                Close();
            }
        }
    }
}
