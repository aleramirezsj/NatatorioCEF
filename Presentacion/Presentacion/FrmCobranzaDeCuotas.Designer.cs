
namespace NatatorioCEF.Presentacion
{
    partial class FrmCobranzaDeCuotas
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
            this.GridCuotasAdeudadas = new System.Windows.Forms.DataGridView();
            this.CboCobradores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegistraPago = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GridCuotasPagas = new System.Windows.Forms.DataGridView();
            this.BtnAnularPago = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotasAdeudadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotasPagas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PbxImagenSocios);
            this.panel1.Controls.Add(this.LblSocios);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 62);
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
            this.LblSocios.Size = new System.Drawing.Size(314, 45);
            this.LblSocios.TabIndex = 0;
            this.LblSocios.Text = "Cobranza de cuotas";
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
            this.lblSocioSeleccionado.Location = new System.Drawing.Point(365, 77);
            this.lblSocioSeleccionado.Name = "lblSocioSeleccionado";
            this.lblSocioSeleccionado.Size = new System.Drawing.Size(110, 25);
            this.lblSocioSeleccionado.TabIndex = 7;
            this.lblSocioSeleccionado.Text = "Cuotas de :";
            // 
            // GridCuotasAdeudadas
            // 
            this.GridCuotasAdeudadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCuotasAdeudadas.Location = new System.Drawing.Point(365, 143);
            this.GridCuotasAdeudadas.Name = "GridCuotasAdeudadas";
            this.GridCuotasAdeudadas.RowTemplate.Height = 25;
            this.GridCuotasAdeudadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCuotasAdeudadas.Size = new System.Drawing.Size(330, 138);
            this.GridCuotasAdeudadas.TabIndex = 8;
            this.GridCuotasAdeudadas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCuotas_CellEnter);
            // 
            // CboCobradores
            // 
            this.CboCobradores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCobradores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboCobradores.FormattingEnabled = true;
            this.CboCobradores.Location = new System.Drawing.Point(731, 178);
            this.CboCobradores.Name = "CboCobradores";
            this.CboCobradores.Size = new System.Drawing.Size(198, 29);
            this.CboCobradores.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(776, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cobrador:";
            // 
            // BtnRegistraPago
            // 
            this.BtnRegistraPago.Enabled = false;
            this.BtnRegistraPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistraPago.Location = new System.Drawing.Point(776, 224);
            this.BtnRegistraPago.Name = "BtnRegistraPago";
            this.BtnRegistraPago.Size = new System.Drawing.Size(120, 36);
            this.BtnRegistraPago.TabIndex = 11;
            this.BtnRegistraPago.Text = "Registrar Pago";
            this.BtnRegistraPago.UseVisualStyleBackColor = true;
            this.BtnRegistraPago.Click += new System.EventHandler(this.BtnRegistraPago_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cuotas adeudadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(365, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cuotas pagas";
            // 
            // GridCuotasPagas
            // 
            this.GridCuotasPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCuotasPagas.Location = new System.Drawing.Point(365, 312);
            this.GridCuotasPagas.Name = "GridCuotasPagas";
            this.GridCuotasPagas.RowTemplate.Height = 25;
            this.GridCuotasPagas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCuotasPagas.Size = new System.Drawing.Size(387, 126);
            this.GridCuotasPagas.TabIndex = 14;
            this.GridCuotasPagas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCuotasPagas_CellEnter);
            // 
            // BtnAnularPago
            // 
            this.BtnAnularPago.Enabled = false;
            this.BtnAnularPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnularPago.Location = new System.Drawing.Point(776, 342);
            this.BtnAnularPago.Name = "BtnAnularPago";
            this.BtnAnularPago.Size = new System.Drawing.Size(120, 36);
            this.BtnAnularPago.TabIndex = 15;
            this.BtnAnularPago.Text = "Anular Pago";
            this.BtnAnularPago.UseVisualStyleBackColor = true;
            this.BtnAnularPago.Click += new System.EventHandler(this.BtnAnularPago_Click);
            // 
            // FrmCobranzaDeCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.BtnAnularPago);
            this.Controls.Add(this.GridCuotasPagas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRegistraPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboCobradores);
            this.Controls.Add(this.GridCuotasAdeudadas);
            this.Controls.Add(this.lblSocioSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSocioBuscado);
            this.Controls.Add(this.GridSocios);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCobranzaDeCuotas";
            this.Text = "Cobranza de cuotas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotasAdeudadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotasPagas)).EndInit();
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
        private System.Windows.Forms.DataGridView GridCuotasAdeudadas;
        private System.Windows.Forms.ComboBox CboCobradores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegistraPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GridCuotasPagas;
        private System.Windows.Forms.Button BtnAnularPago;
    }
}