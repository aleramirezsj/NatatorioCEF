using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmSplash : Form
    {
        private bool CargaBBDDCompleta = false;
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void TmrTiempo_Tick(object sender, EventArgs e)
        {
            PBaBarraDeProgreso.Value = PBaBarraDeProgreso.Value + 2;
            //si le damos a la barra de progreso un valor mayor al máximo(que en este caso es 100) no dá error, por ello validamos si ya llegó a 100
            if(PBaBarraDeProgreso.Value==100)
            {
                if (CargaBBDDCompleta) { 
                    //apagamos el cronometro
                    TmrTiempo.Enabled = false;
                    var frmMenuPrincipal = new FrmMenuPrincipal();
                    frmMenuPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    PBaBarraDeProgreso.Value = 0;
                }
            }
        }

        private void FrmSplash_Activated(object sender, EventArgs e)
        {
            var db = new DbNatatorioContext();
            var listaSocios = db.Socios.ToList();
            CargaBBDDCompleta = true;
        }
    }
}
