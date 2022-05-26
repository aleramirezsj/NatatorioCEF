using NatatorioCEF.Modelos;
using NatatorioCEF.Presentacion;
using NatatorioCEF.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public static Usuario UsuarioLogueado;
        
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            //mostramos el formulario usando el método ShowDialog() que lo muestra como Modal, es decir, colocándolo Always on top
            //frmAcercaDe.ShowDialog();
            //si queremos permitir la instanciación múltiple del formulario podemos llamar a el método Show()
            //frmAcercaDe.MdiParent = this;
            frmAcercaDe.Show();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmGestionSocios frmGestionSocios = new FrmGestionSocios();
            //frmGestionSocios.MdiParent=this;    
            frmGestionSocios.Show();
        }

        private void cobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCobradores frmGestionCobradores = new FrmGestionCobradores();
            frmGestionCobradores.MdiParent= this;
            frmGestionCobradores.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios();
            //frmGestionUsuarios.MdiParent = this;
            frmGestionUsuarios.Show();
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            if (UsuarioLogueado==null)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (UsuarioLogueado == null)
                    Application.Exit();
                else
                {
                    usuariosToolStripMenuItem.Enabled = UsuarioLogueado.TipoUsuario == TipoUsuarioEnum.Administrador;
                }
            }
        }

        private void generaciónDeCuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCobranzaDeCuotasInyDependencias frmGeneracionCuotas = new FrmCobranzaDeCuotasInyDependencias();
            //frmGeneracionCuotas.MdiParent = this;
            frmGeneracionCuotas.Show();
        }

        private void tsbSocios_Click(object sender, EventArgs e)
        {
            sociosToolStripMenuItem_Click(sender, e);
        }

        private void cobradoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cobradoresToolStripMenuItem_Click(sender, e);
        }

        private void cargarUnNuevoCobradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNuevoEditarCobrador= new FrmNuevoEditarCobrador();
            //frmNuevoEditarCobrador.MdiParent = this;
            frmNuevoEditarCobrador.Show();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ModosVisualesEnum)tscbEstiloVisual.ComboBox.SelectedValue==ModosVisualesEnum.Modo_Oscuro)
            {
                AplicarModoOscuro();
            }
            else
            {
                AplicarModoClaro();
            }
        }

        private void AplicarModoClaro()
        {
            mnuMenuPrincipal.BackColor = default(Color);
            tspBarraDeHerramientas.BackColor = default(Color);
        }

        private void AplicarModoOscuro()
        {
            mnuMenuPrincipal.BackColor = Color.DarkGray;
            tspBarraDeHerramientas.BackColor = Color.DarkGray;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarCboEstiloVisual();
        }

        private void CargarCboEstiloVisual()
        {
            tscbEstiloVisual.ComboBox.DataSource = Enum.GetValues(typeof(ModosVisualesEnum));
        }

        private void modoOscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarModoOscuro();
        }

        private void modoClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarModoClaro();
        }

        private void FrmMenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                mnuModosVisuales.Show(MousePosition);
        }
    }
}
