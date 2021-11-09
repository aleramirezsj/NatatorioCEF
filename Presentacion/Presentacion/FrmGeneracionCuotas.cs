using Microsoft.EntityFrameworkCore;
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
            //CargarGrilla();
        }

        private void CargarGrilla()
        {
            var listaCuotas = from cuota in db.Cuotas
                              join socio in db.Socios
                              on cuota.SocioId equals socio.Id
                              where cuota.Año == int.Parse(CboAño.Text) && cuota.Mes== CboMes.SelectedIndex + 1
                              select new { Id = cuota.Id, Socio = socio.Apellido+ " "+socio.Nombre, Importe=cuota.Importe };
            GridCuotas.DataSource = listaCuotas.ToList();
            //GridCuotas.DataSource=db.Cuotas.Include(c => c.Socio).Where(c=>c.Año==int.Parse(CboAño.Text)&&c.Mes==CboMes.SelectedIndex+1).ToList();
        }
        private void CargarGrillaFiltrada()
        {
            var listaCuotas = from cuota in db.Cuotas
                              join socio in db.Socios
                              on cuota.SocioId equals socio.Id
                              where cuota.Año == int.Parse(CboAño.Text) && cuota.Mes == CboMes.SelectedIndex + 1 && (socio.Apellido.Contains(TxtSocioBuscado.Text)||socio.Nombre.Contains(TxtSocioBuscado.Text))
                              select new { Id = cuota.Id, Socio = socio.Apellido + " " + socio.Nombre, Importe = cuota.Importe };
            GridCuotas.DataSource = listaCuotas.ToList();
            //GridCuotas.DataSource=db.Cuotas.Include(c => c.Socio).Where(c=>c.Año==int.Parse(CboAño.Text)&&c.Mes==CboMes.SelectedIndex+1).ToList();
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
            //recorremos cada socio para generarle su cuota
            int cuotasCreadas=0, cuotasActualizadas=0, cuotasSinCambios = 0 ;
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
                var cuotaExistente = CuotaYaExistente(cuota);
                if (cuotaExistente == null)
                {
                    db.Cuotas.Add(cuota);
                    db.SaveChanges();
                    cuotasCreadas++;
                }
                else if (cuotaExistente.FechaPago == null)
                {
                    if (CuotasDistintas(cuota, cuotaExistente))
                    {
                        db.Entry(cuotaExistente).State = EntityState.Modified;
                        db.SaveChanges();
                        cuotasActualizadas++;
                    }
                }
                else
                    cuotasSinCambios++;

            }
            MessageBox.Show($"Se crearon {cuotasCreadas} cuotas" + Environment.NewLine + $"Se actualizaron {cuotasActualizadas} cuotas" + Environment.NewLine + $"{cuotasSinCambios} cuotas no recibieron cambios");
        }

        private bool CuotasDistintas(Cuota cuota, Cuota cuotaExistente)
        {
            if (cuota.Importe == cuotaExistente.Importe && cuota.Vencimiento == cuotaExistente.Vencimiento && cuota.Recargo == cuotaExistente.Recargo)
                return false;
            else
            {
                cuotaExistente.Importe = cuota.Importe;
                cuotaExistente.Vencimiento = cuota.Vencimiento;
                cuotaExistente.Recargo = cuota.Recargo;
                return true;
            }
        }

        private Cuota CuotaYaExistente(Cuota cuota)
        {
            var cuotaExistente=db.Cuotas.Where(c=>c.SocioId==cuota.SocioId && c.Año==cuota.Año && c.Mes==cuota.Mes).FirstOrDefault();
            return cuotaExistente;
        }

        private void CboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboAño.SelectedIndex>0)
                CargarGrilla();
        }

        private void CboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboMes.SelectedIndex >0)
                CargarGrilla();
        }

        private void GridCuotas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCuotas.Columns["Id"] != null)
                GridCuotas.Columns["Id"].Width = 30;
            if (GridCuotas.Columns["Socio"] != null)
                GridCuotas.Columns["Socio"].Width = 110;
            if (GridCuotas.Columns["Importe"] != null)
                GridCuotas.Columns["Importe"].Width = 60;
        }

        private void TxtSocioBuscado_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaFiltrada();
        }
    }
}
