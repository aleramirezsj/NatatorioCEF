﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using NatatorioCEF.Utils;
using NatatorioCEF.Modelos;
using Presentacion.Modelos;
using Presentacion;

namespace NatatorioCEF.Presentation
{
    public partial class FrmLogin : Form
    {
        int intentosFallidos = 0;
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (ValidarAcceso()) { 
                this.Close();
            }
            else
            {
                intentosFallidos++;
                if (intentosFallidos == 3)
                    Application.Exit();
                else
                {
                    MessageBox.Show("Error en usuario o contraseña ingresados");
                    TxtUsuario.Text = "";
                    TxtContraseña.Text = "";
                    TxtUsuario.Focus();
                }
            }
        }
        private bool ValidarAcceso()
        {
            using var db = new DbNatatorioContext();
            string pass = Helper.ObtenerHashSha256(TxtContraseña.Text);
            var listaUsuarios = db.Usuarios.Where(u => u.User.Equals(TxtUsuario.Text)).Where(u => u.Password.Equals(pass)).ToList();
            //MessageBox.Show(listaUsuarios.Count.ToString());
            if (listaUsuarios.Count > 0)
            {
                FrmMenuPrincipal.UsuarioLogueado = listaUsuarios.ElementAt(0);
                return true;
            }
            else
            {
                return false;
            }

        }

        private void TxtContraseña_KeyDown(object sender, KeyEventArgs argumento)
        {
            if (argumento.KeyCode == Keys.Enter)
                BtnAcceder.PerformClick();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
