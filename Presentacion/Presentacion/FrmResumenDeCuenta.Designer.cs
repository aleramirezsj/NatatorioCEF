
namespace NatatorioCEF.Presentacion
{
    partial class FrmResumenDeCuenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbxImagenSocios = new System.Windows.Forms.PictureBox();
            this.LblSocios = new System.Windows.Forms.Label();
            this.GridSocios = new System.Windows.Forms.DataGridView();
            this.TxtSocioBuscado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSocioSeleccionado = new System.Windows.Forms.Label();
            this.GridCuotas = new System.Windows.Forms.DataGridView();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PbxImagenSocios);
            this.panel1.Controls.Add(this.LblSocios);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 62);
            this.panel1.TabIndex = 3;
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
            // LblSocios
            // 
            this.LblSocios.AutoSize = true;
            this.LblSocios.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LblSocios.ForeColor = System.Drawing.Color.Purple;
            this.LblSocios.Location = new System.Drawing.Point(88, 4);
            this.LblSocios.Name = "LblSocios";
            this.LblSocios.Size = new System.Drawing.Size(310, 45);
            this.LblSocios.TabIndex = 0;
            this.LblSocios.Text = "Resumen de cuenta";
            // 
            // GridSocios
            // 
            this.GridSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSocios.Location = new System.Drawing.Point(12, 143);
            this.GridSocios.Name = "GridSocios";
            this.GridSocios.RowTemplate.Height = 25;
            this.GridSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSocios.Size = new System.Drawing.Size(347, 295);
            this.GridSocios.TabIndex = 4;
            this.GridSocios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSocios_CellEnter);
            // 
            // TxtSocioBuscado
            // 
            this.TxtSocioBuscado.Location = new System.Drawing.Point(94, 114);
            this.TxtSocioBuscado.Name = "TxtSocioBuscado";
            this.TxtSocioBuscado.Size = new System.Drawing.Size(265, 23);
            this.TxtSocioBuscado.TabIndex = 5;
            this.TxtSocioBuscado.TextChanged += new System.EventHandler(this.TxtSocioBuscado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar socio:";
            // 
            // lblSocioSeleccionado
            // 
            this.lblSocioSeleccionado.AutoSize = true;
            this.lblSocioSeleccionado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSocioSeleccionado.Location = new System.Drawing.Point(382, 107);
            this.lblSocioSeleccionado.Name = "lblSocioSeleccionado";
            this.lblSocioSeleccionado.Size = new System.Drawing.Size(110, 25);
            this.lblSocioSeleccionado.TabIndex = 7;
            this.lblSocioSeleccionado.Text = "Cuotas de :";
            // 
            // GridCuotas
            // 
            this.GridCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCuotas.Location = new System.Drawing.Point(382, 143);
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.RowTemplate.Height = 25;
            this.GridCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCuotas.Size = new System.Drawing.Size(477, 295);
            this.GridCuotas.TabIndex = 8;
            this.GridCuotas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCuotas_CellEnter);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Enabled = false;
            this.BtnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnImprimir.Location = new System.Drawing.Point(873, 278);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(81, 36);
            this.BtnImprimir.TabIndex = 11;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // FrmResumenDeCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.GridCuotas);
            this.Controls.Add(this.lblSocioSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSocioBuscado);
            this.Controls.Add(this.GridSocios);
            this.Controls.Add(this.panel1);
            this.Name = "FrmResumenDeCuenta";
            this.Text = "Resumen de cuenta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbxImagenSocios;
        private System.Windows.Forms.Label LblSocios;
        private System.Windows.Forms.DataGridView GridSocios;
        private System.Windows.Forms.TextBox TxtSocioBuscado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSocioSeleccionado;
        private System.Windows.Forms.DataGridView GridCuotas;
        private System.Windows.Forms.Button BtnImprimir;
    }
}