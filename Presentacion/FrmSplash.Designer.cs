
namespace Presentacion
{
    partial class FrmSplash
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
            this.components = new System.ComponentModel.Container();
            this.LblNatatorio = new System.Windows.Forms.Label();
            this.PnlFondo = new System.Windows.Forms.Panel();
            this.PBaBarraDeProgreso = new System.Windows.Forms.ProgressBar();
            this.TmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblNatatorio
            // 
            this.LblNatatorio.AutoSize = true;
            this.LblNatatorio.Font = new System.Drawing.Font("Adobe Fangsong Std R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNatatorio.Location = new System.Drawing.Point(12, 9);
            this.LblNatatorio.Name = "LblNatatorio";
            this.LblNatatorio.Size = new System.Drawing.Size(202, 36);
            this.LblNatatorio.TabIndex = 0;
            this.LblNatatorio.Text = "Natatorio CEF";
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackgroundImage = global::Presentacion.Properties.Resources.natatorio;
            this.PnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlFondo.Location = new System.Drawing.Point(12, 48);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(603, 218);
            this.PnlFondo.TabIndex = 1;
            // 
            // PBaBarraDeProgreso
            // 
            this.PBaBarraDeProgreso.Location = new System.Drawing.Point(13, 280);
            this.PBaBarraDeProgreso.Name = "PBaBarraDeProgreso";
            this.PBaBarraDeProgreso.Size = new System.Drawing.Size(602, 23);
            this.PBaBarraDeProgreso.TabIndex = 2;
            // 
            // TmrTiempo
            // 
            this.TmrTiempo.Enabled = true;
            this.TmrTiempo.Tick += new System.EventHandler(this.TmrTiempo_Tick);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 315);
            this.ControlBox = false;
            this.Controls.Add(this.PBaBarraDeProgreso);
            this.Controls.Add(this.PnlFondo);
            this.Controls.Add(this.LblNatatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.Activated += new System.EventHandler(this.FrmSplash_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNatatorio;
        private System.Windows.Forms.Panel PnlFondo;
        private System.Windows.Forms.ProgressBar PBaBarraDeProgreso;
        private System.Windows.Forms.Timer TmrTiempo;
    }
}