using NatatorioCEF.Modelos;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NatatorioCEF.Presentacion
{
    public partial class FrmGeneracionCuotas : Form
    {
        DbNatatorioContext db = new DbNatatorioContext();
        public FrmGeneracionCuotas()
        {
            InitializeComponent();
            CargarCboAño();
            CargarCboMeses();
        }

        private void CargarCboMeses()
        {
            CboMes.DataSource = Enum.GetValues(typeof(MesesEnum));
        }

        private void CargarCboAño()
        {
            List<string> años = new List<string>();
            for (int i = 0; i < 21; i++)
            {
                var año = DateTime.Today.Year - 10 + i;
                años.Add(año.ToString());
            }
            CboAño.DataSource = años;
            CboAño.Text = DateTime.Today.Year.ToString();
        }

        private void BtnGenerarCuotas_Click(object sender, EventArgs e)
        {
            //obtenemos la lista de socios
            var listaDeSocios = db.Socios.ToList();
            foreach(Socio socio in listaDeSocios)
            {
                //controlamos que la cuota no exista
                //generamos la cuota
                var cuota = new Cuota()
                {
                    Importe = (float)NudMontoCuota.Value,
                    Mes = (int)CboMes.SelectedItem,
                    Año = Convert.ToInt32(CboAño.Text),
                    Recargo = (float)NudRecargoMora.Value,
                    SocioId = socio.Id,
                    Vencimiento = DtpVencimiento.Value
                };
                db.Cuotas.Add(cuota);
                db.SaveChanges();
            }
        }
    }
}
