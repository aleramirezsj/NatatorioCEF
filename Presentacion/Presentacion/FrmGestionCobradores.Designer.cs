
namespace Presentacion
{
    partial class FrmGestionCobradores
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
            this.LblSocios = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbxImagenSocios = new System.Windows.Forms.PictureBox();
            this.GridLista = new System.Windows.Forms.DataGridView();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSocios
            // 
            this.LblSocios.AutoSize = true;
            this.LblSocios.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblSocios.ForeColor = System.Drawing.Color.Purple;
            this.LblSocios.Location = new System.Drawing.Point(88, 4);
            this.LblSocios.Name = "LblSocios";
            this.LblSocios.Size = new System.Drawing.Size(190, 45);
            this.LblSocios.TabIndex = 0;
            this.LblSocios.Text = "Cobradores";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PbxImagenSocios);
            this.panel1.Controls.Add(this.LblSocios);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 62);
            this.panel1.TabIndex = 1;
            // 
            // PbxImagenSocios
            // 
            this.PbxImagenSocios.Image = global::NatatorioCEF.Properties.Resources.animado1;
            this.PbxImagenSocios.Location = new System.Drawing.Point(24, 4);
            this.PbxImagenSocios.Name = "PbxImagenSocios";
            this.PbxImagenSocios.Size = new System.Drawing.Size(58, 50);
            this.PbxImagenSocios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImagenSocios.TabIndex = 1;
            this.PbxImagenSocios.TabStop = false;
            // 
            // GridLista
            // 
            this.GridLista.AllowUserToOrderColumns = true;
            this.GridLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLista.Location = new System.Drawing.Point(72, 94);
            this.GridLista.Name = "GridLista";
            this.GridLista.RowTemplate.Height = 25;
            this.GridLista.Size = new System.Drawing.Size(549, 208);
            this.GridLista.TabIndex = 2;
            this.GridLista.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSocios_CellEnter);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(92, 362);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(209, 362);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "&Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(334, 362);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(636, 376);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(173, 318);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(171, 23);
            this.TxtBusqueda.TabIndex = 7;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(102, 321);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(45, 15);
            this.LblBuscar.TabIndex = 8;
            this.LblBuscar.Text = "Buscar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGestionCobradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.GridLista);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionCobradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobradores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSocios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbxImagenSocios;
        private System.Windows.Forms.DataGridView GridLista;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button button1;
    }
}