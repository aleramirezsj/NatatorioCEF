﻿using NatatorioCEF.Modelos;
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
            frmAcercaDe.ShowDialog();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmGestionSocios frmGestionSocios = new FrmGestionSocios();
            frmGestionSocios.ShowDialog();
        }

        private void cobradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCobradores frmGestionCobradores = new FrmGestionCobradores();
            frmGestionCobradores.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = new FrmGestionUsuarios();
            frmGestionUsuarios.ShowDialog();
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
    }
}
