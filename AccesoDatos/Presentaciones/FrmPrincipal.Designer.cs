
namespace Presentaciones
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeUsuariosToolStripMenuItem,
            this.administraciónDeProductosToolStripMenuItem,
            this.administraciónDeHerramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Administración de Usuarios";
            // 
            // administraciónDeUsuariosToolStripMenuItem
            // 
            this.administraciónDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsuarios});
            this.administraciónDeUsuariosToolStripMenuItem.Image = global::Presentaciones.Properties.Resources.icons8_contactos_64;
            this.administraciónDeUsuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administraciónDeUsuariosToolStripMenuItem.Name = "administraciónDeUsuariosToolStripMenuItem";
            this.administraciónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(280, 68);
            this.administraciónDeUsuariosToolStripMenuItem.Text = "Administración de Usuarios";
            // 
            // tsUsuarios
            // 
            this.tsUsuarios.Image = global::Presentaciones.Properties.Resources.icons8_user_40px;
            this.tsUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUsuarios.Name = "tsUsuarios";
            this.tsUsuarios.Size = new System.Drawing.Size(173, 46);
            this.tsUsuarios.Text = "Usuarios";
            this.tsUsuarios.Click += new System.EventHandler(this.tsUsuarios_Click);
            // 
            // administraciónDeProductosToolStripMenuItem
            // 
            this.administraciónDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProductos});
            this.administraciónDeProductosToolStripMenuItem.Image = global::Presentaciones.Properties.Resources.icons8_product_64px;
            this.administraciónDeProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administraciónDeProductosToolStripMenuItem.Name = "administraciónDeProductosToolStripMenuItem";
            this.administraciónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(290, 68);
            this.administraciónDeProductosToolStripMenuItem.Text = "Administración de Productos";
            // 
            // tsProductos
            // 
            this.tsProductos.Image = global::Presentaciones.Properties.Resources.icons8_product_48px;
            this.tsProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsProductos.Name = "tsProductos";
            this.tsProductos.Size = new System.Drawing.Size(191, 54);
            this.tsProductos.Text = "Productos";
            this.tsProductos.Click += new System.EventHandler(this.tsProductos_Click);
            // 
            // administraciónDeHerramientasToolStripMenuItem
            // 
            this.administraciónDeHerramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHerramientas});
            this.administraciónDeHerramientasToolStripMenuItem.Image = global::Presentaciones.Properties.Resources.icons8_maintenance_64px;
            this.administraciónDeHerramientasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administraciónDeHerramientasToolStripMenuItem.Name = "administraciónDeHerramientasToolStripMenuItem";
            this.administraciónDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(314, 68);
            this.administraciónDeHerramientasToolStripMenuItem.Text = "Administración de Herramientas";
            // 
            // tsHerramientas
            // 
            this.tsHerramientas.Image = global::Presentaciones.Properties.Resources.icons8_maintenance_40px;
            this.tsHerramientas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsHerramientas.Name = "tsHerramientas";
            this.tsHerramientas.Size = new System.Drawing.Size(207, 46);
            this.tsHerramientas.Text = "Herramientas";
            this.tsHerramientas.Click += new System.EventHandler(this.tsHerramientas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 473);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsUsuarios;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsProductos;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsHerramientas;
    }
}