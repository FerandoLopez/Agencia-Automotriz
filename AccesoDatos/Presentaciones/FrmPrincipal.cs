﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciones
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tsUsuarios_Click(object sender, EventArgs e)
        {
           
        }

        private void tsProductos_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto p = new FrmAgregarProducto();
            p.MdiParent = this;
            p.Show();
        }

        private void tsHerramientas_Click(object sender, EventArgs e)
        {
            FrmAgregarHerramienta h = new FrmAgregarHerramienta();
            h.MdiParent = this;
            h.Show();
        }
    }
}
