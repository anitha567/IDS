namespace Actividad_3_CRUD
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bienvenidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensajeDeBienvenidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiénesSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caballerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienvenidaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bienvenidaToolStripMenuItem
            // 
            this.bienvenidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensajeDeBienvenidaToolStripMenuItem,
            this.quiénesSomosToolStripMenuItem,
            this.misiónToolStripMenuItem,
            this.visiónToolStripMenuItem});
            this.bienvenidaToolStripMenuItem.Name = "bienvenidaToolStripMenuItem";
            this.bienvenidaToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.bienvenidaToolStripMenuItem.Text = "Bienvenida";
            this.bienvenidaToolStripMenuItem.Click += new System.EventHandler(this.bienvenidaToolStripMenuItem_Click);
            // 
            // mensajeDeBienvenidaToolStripMenuItem
            // 
            this.mensajeDeBienvenidaToolStripMenuItem.Name = "mensajeDeBienvenidaToolStripMenuItem";
            this.mensajeDeBienvenidaToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.mensajeDeBienvenidaToolStripMenuItem.Text = "Mensaje de bienvenida";
            this.mensajeDeBienvenidaToolStripMenuItem.Click += new System.EventHandler(this.mensajeDeBienvenidaToolStripMenuItem_Click);
            // 
            // quiénesSomosToolStripMenuItem
            // 
            this.quiénesSomosToolStripMenuItem.Name = "quiénesSomosToolStripMenuItem";
            this.quiénesSomosToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.quiénesSomosToolStripMenuItem.Text = "¿Quiénes Somos?";
            this.quiénesSomosToolStripMenuItem.Click += new System.EventHandler(this.quiénesSomosToolStripMenuItem_Click);
            // 
            // misiónToolStripMenuItem
            // 
            this.misiónToolStripMenuItem.Name = "misiónToolStripMenuItem";
            this.misiónToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.misiónToolStripMenuItem.Text = "Misión";
            this.misiónToolStripMenuItem.Click += new System.EventHandler(this.misiónToolStripMenuItem_Click);
            // 
            // visiónToolStripMenuItem
            // 
            this.visiónToolStripMenuItem.Name = "visiónToolStripMenuItem";
            this.visiónToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.visiónToolStripMenuItem.Text = "Visión";
            this.visiónToolStripMenuItem.Click += new System.EventHandler(this.visiónToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.damasToolStripMenuItem,
            this.caballerosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // damasToolStripMenuItem
            // 
            this.damasToolStripMenuItem.Name = "damasToolStripMenuItem";
            this.damasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.damasToolStripMenuItem.Text = "Damas";
            this.damasToolStripMenuItem.Click += new System.EventHandler(this.damasToolStripMenuItem_Click_1);
            // 
            // caballerosToolStripMenuItem
            // 
            this.caballerosToolStripMenuItem.Name = "caballerosToolStripMenuItem";
            this.caballerosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.caballerosToolStripMenuItem.Text = "Caballeros";
            this.caballerosToolStripMenuItem.Click += new System.EventHandler(this.caballerosToolStripMenuItem_Click_1);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.salirToolStripMenuItem.Text = "Salir   ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Zapatería UMI - Menú Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bienvenidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensajeDeBienvenidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiénesSomosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caballerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

