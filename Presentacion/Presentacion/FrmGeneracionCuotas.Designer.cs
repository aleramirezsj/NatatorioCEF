
namespace NatatorioCEF.Presentacion
{
    partial class FrmGeneracionCuotas
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
            this.CboAño = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NudMontoCuota = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.NudRecargoMora = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGenerarCuotas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRecargoMora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PbxImagenSocios);
            this.panel1.Controls.Add(this.LblSocios);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 62);
            this.panel1.TabIndex = 2;
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
            this.LblSocios.Size = new System.Drawing.Size(511, 45);
            this.LblSocios.TabIndex = 0;
            this.LblSocios.Text = "Generación de cuotas societarias";
            // 
            // CboAño
            // 
            this.CboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAño.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboAño.FormattingEnabled = true;
            this.CboAño.Location = new System.Drawing.Point(69, 83);
            this.CboAño.Name = "CboAño";
            this.CboAño.Size = new System.Drawing.Size(113, 29);
            this.CboAño.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(213, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mes";
            // 
            // CboMes
            // 
            this.CboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboMes.FormattingEnabled = true;
            this.CboMes.Location = new System.Drawing.Point(265, 83);
            this.CboMes.Name = "CboMes";
            this.CboMes.Size = new System.Drawing.Size(129, 29);
            this.CboMes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(166, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto cuota:";
            // 
            // NudMontoCuota
            // 
            this.NudMontoCuota.DecimalPlaces = 2;
            this.NudMontoCuota.Location = new System.Drawing.Point(274, 141);
            this.NudMontoCuota.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NudMontoCuota.Name = "NudMontoCuota";
            this.NudMontoCuota.Size = new System.Drawing.Size(120, 23);
            this.NudMontoCuota.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(104, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de vencimiento:";
            // 
            // DtpVencimiento
            // 
            this.DtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpVencimiento.Location = new System.Drawing.Point(274, 185);
            this.DtpVencimiento.Name = "DtpVencimiento";
            this.DtpVencimiento.Size = new System.Drawing.Size(120, 23);
            this.DtpVencimiento.TabIndex = 10;
            // 
            // NudRecargoMora
            // 
            this.NudRecargoMora.DecimalPlaces = 2;
            this.NudRecargoMora.Location = new System.Drawing.Point(274, 230);
            this.NudRecargoMora.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NudRecargoMora.Name = "NudRecargoMora";
            this.NudRecargoMora.Size = new System.Drawing.Size(120, 23);
            this.NudRecargoMora.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(129, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Recargo por mora:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(564, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 29);
            this.textBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(462, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buscar socio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(425, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(354, 261);
            this.dataGridView1.TabIndex = 15;
            // 
            // BtnGenerarCuotas
            // 
            this.BtnGenerarCuotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerarCuotas.Location = new System.Drawing.Point(139, 291);
            this.BtnGenerarCuotas.Name = "BtnGenerarCuotas";
            this.BtnGenerarCuotas.Size = new System.Drawing.Size(172, 27);
            this.BtnGenerarCuotas.TabIndex = 16;
            this.BtnGenerarCuotas.Text = "Generar cuotas";
            this.BtnGenerarCuotas.UseVisualStyleBackColor = true;
            this.BtnGenerarCuotas.Click += new System.EventHandler(this.BtnGenerarCuotas_Click);
            // 
            // FrmGeneracionCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.BtnGenerarCuotas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NudRecargoMora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtpVencimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NudMontoCuota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboAño);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGeneracionCuotas";
            this.Text = "Generación de cuotas societarias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRecargoMora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbxImagenSocios;
        private System.Windows.Forms.Label LblSocios;
        private System.Windows.Forms.ComboBox CboAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudMontoCuota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpVencimiento;
        private System.Windows.Forms.NumericUpDown NudRecargoMora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGenerarCuotas;
    }
}