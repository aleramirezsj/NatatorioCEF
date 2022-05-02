
namespace Presentacion
{
    partial class FrmNuevoEditarSocio
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblDni = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.NudDni = new System.Windows.Forms.NumericUpDown();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtDirección = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboSocioGarante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboLocalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudDni)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(149, 47);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(51, 15);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(149, 94);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(51, 15);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido";
            // 
            // LblDni
            // 
            this.LblDni.AutoSize = true;
            this.LblDni.Location = new System.Drawing.Point(149, 141);
            this.LblDni.Name = "LblDni";
            this.LblDni.Size = new System.Drawing.Size(27, 15);
            this.LblDni.TabIndex = 2;
            this.LblDni.Text = "DNI";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(149, 185);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(52, 15);
            this.LblTelefono.TabIndex = 3;
            this.LblTelefono.Text = "Teléfono";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(234, 47);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(180, 23);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(234, 94);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(180, 23);
            this.TxtApellido.TabIndex = 5;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(234, 185);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(180, 23);
            this.TxtTelefono.TabIndex = 7;
            // 
            // NudDni
            // 
            this.NudDni.Location = new System.Drawing.Point(234, 141);
            this.NudDni.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NudDni.Name = "NudDni";
            this.NudDni.Size = new System.Drawing.Size(180, 23);
            this.NudDni.TabIndex = 6;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(197, 372);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(312, 372);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtDirección
            // 
            this.TxtDirección.Location = new System.Drawing.Point(234, 232);
            this.TxtDirección.Name = "TxtDirección";
            this.TxtDirección.Size = new System.Drawing.Size(180, 23);
            this.TxtDirección.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dirección";
            // 
            // CboSocioGarante
            // 
            this.CboSocioGarante.FormattingEnabled = true;
            this.CboSocioGarante.Location = new System.Drawing.Point(234, 276);
            this.CboSocioGarante.Name = "CboSocioGarante";
            this.CboSocioGarante.Size = new System.Drawing.Size(180, 23);
            this.CboSocioGarante.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Socio garante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Localidad";
            // 
            // CboLocalidad
            // 
            this.CboLocalidad.FormattingEnabled = true;
            this.CboLocalidad.Location = new System.Drawing.Point(234, 319);
            this.CboLocalidad.Name = "CboLocalidad";
            this.CboLocalidad.Size = new System.Drawing.Size(180, 23);
            this.CboLocalidad.TabIndex = 14;
            // 
            // FrmNuevoEditarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboLocalidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboSocioGarante);
            this.Controls.Add(this.TxtDirección);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.NudDni);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblDni);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Name = "FrmNuevoEditarSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo/editar socio";
            ((System.ComponentModel.ISupportInitialize)(this.NudDni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblDni;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.NumericUpDown NudDni;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtDirección;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboSocioGarante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboLocalidad;
    }
}