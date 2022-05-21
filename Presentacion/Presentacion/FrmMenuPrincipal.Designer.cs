
namespace Presentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónDeCuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ToolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbSocios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.gestiónCobradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarUnNuevoCobradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolComboThemes = new System.Windows.Forms.ToolStripComboBox();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.efectosVisualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistmeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoOscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoClaroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ToolStripPrincipal.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(836, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.cobradoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.generaciónDeCuotasToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sociosToolStripMenuItem.Text = "Socios";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // cobradoresToolStripMenuItem
            // 
            this.cobradoresToolStripMenuItem.Name = "cobradoresToolStripMenuItem";
            this.cobradoresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cobradoresToolStripMenuItem.Text = "Cobradores";
            this.cobradoresToolStripMenuItem.Click += new System.EventHandler(this.cobradoresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // generaciónDeCuotasToolStripMenuItem
            // 
            this.generaciónDeCuotasToolStripMenuItem.Name = "generaciónDeCuotasToolStripMenuItem";
            this.generaciónDeCuotasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.generaciónDeCuotasToolStripMenuItem.Text = "Generación de cuotas";
            this.generaciónDeCuotasToolStripMenuItem.Click += new System.EventHandler(this.generaciónDeCuotasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NatatorioCEF.Properties.Resources.encabezado;
            this.pictureBox1.Location = new System.Drawing.Point(679, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ToolStripPrincipal
            // 
            this.ToolStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSocios,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.ToolComboThemes});
            this.ToolStripPrincipal.Location = new System.Drawing.Point(0, 24);
            this.ToolStripPrincipal.Name = "ToolStripPrincipal";
            this.ToolStripPrincipal.Size = new System.Drawing.Size(836, 49);
            this.ToolStripPrincipal.TabIndex = 4;
            this.ToolStripPrincipal.Text = "toolStrip1";
            // 
            // tsbSocios
            // 
            this.tsbSocios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSocios.Image = ((System.Drawing.Image)(resources.GetObject("tsbSocios.Image")));
            this.tsbSocios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSocios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSocios.Name = "tsbSocios";
            this.tsbSocios.Size = new System.Drawing.Size(46, 46);
            this.tsbSocios.Text = "toolStripButton1";
            this.tsbSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbSocios.ToolTipText = "Gestión de socios";
            this.tsbSocios.Click += new System.EventHandler(this.tsbSocios_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónCobradoresToolStripMenuItem,
            this.cargarUnNuevoCobradorToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(84, 46);
            this.toolStripSplitButton1.Text = "Cobradores";
            // 
            // gestiónCobradoresToolStripMenuItem
            // 
            this.gestiónCobradoresToolStripMenuItem.Name = "gestiónCobradoresToolStripMenuItem";
            this.gestiónCobradoresToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.gestiónCobradoresToolStripMenuItem.Text = "Gestión Cobradores";
            this.gestiónCobradoresToolStripMenuItem.Click += new System.EventHandler(this.gestiónCobradoresToolStripMenuItem_Click);
            // 
            // cargarUnNuevoCobradorToolStripMenuItem
            // 
            this.cargarUnNuevoCobradorToolStripMenuItem.Name = "cargarUnNuevoCobradorToolStripMenuItem";
            this.cargarUnNuevoCobradorToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cargarUnNuevoCobradorToolStripMenuItem.Text = "Cargar un nuevo Cobrador";
            this.cargarUnNuevoCobradorToolStripMenuItem.Click += new System.EventHandler(this.cargarUnNuevoCobradorToolStripMenuItem_Click);
            // 
            // ToolComboThemes
            // 
            this.ToolComboThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolComboThemes.Name = "ToolComboThemes";
            this.ToolComboThemes.Size = new System.Drawing.Size(121, 49);
            this.ToolComboThemes.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efectosVisualesToolStripMenuItem,
            this.salirDelSistmeaToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // efectosVisualesToolStripMenuItem
            // 
            this.efectosVisualesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoOscuroToolStripMenuItem,
            this.modoClaroToolStripMenuItem});
            this.efectosVisualesToolStripMenuItem.Name = "efectosVisualesToolStripMenuItem";
            this.efectosVisualesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.efectosVisualesToolStripMenuItem.Text = "Efectos Visuales";
            // 
            // salirDelSistmeaToolStripMenuItem
            // 
            this.salirDelSistmeaToolStripMenuItem.Name = "salirDelSistmeaToolStripMenuItem";
            this.salirDelSistmeaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDelSistmeaToolStripMenuItem.Text = "Salir del Sistmea";
            this.salirDelSistmeaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistmeaToolStripMenuItem_Click);
            // 
            // modoOscuroToolStripMenuItem
            // 
            this.modoOscuroToolStripMenuItem.Name = "modoOscuroToolStripMenuItem";
            this.modoOscuroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modoOscuroToolStripMenuItem.Text = "Modo Oscuro";
            this.modoOscuroToolStripMenuItem.Click += new System.EventHandler(this.modoOscuroToolStripMenuItem_Click);
            // 
            // modoClaroToolStripMenuItem
            // 
            this.modoClaroToolStripMenuItem.Name = "modoClaroToolStripMenuItem";
            this.modoClaroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modoClaroToolStripMenuItem.Text = "Modo Claro";
            this.modoClaroToolStripMenuItem.Click += new System.EventHandler(this.modoClaroToolStripMenuItem_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NatatorioCEF.Properties.Resources._1Q0IeFO;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.ToolStripPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Natatorio CEF : 2do año TSDS ISP20 -- San Justo - Santa Fe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMenuPrincipal_MouseDown);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ToolStripPrincipal.ResumeLayout(false);
            this.ToolStripPrincipal.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cobradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaciónDeCuotasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripPrincipal;
        private System.Windows.Forms.ToolStripButton tsbSocios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem gestiónCobradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarUnNuevoCobradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ToolComboThemes;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem efectosVisualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoOscuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoClaroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistmeaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

