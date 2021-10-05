using Microsoft.Reporting.WinForms;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (PBaBarraDeProgreso.Value == 10)
                EjecutarTareasAsincronas();
            //{
            //    ConsultaDeDatosSql();
            //    PBaBarraDeProgreso.Value = 50;
            //    ImpresionReporteNoVisible();
            //    PBaBarraDeProgreso.Value = 80;
            //}
            //si le damos a la barra de progreso un valor mayor al máximo(que en este caso es 100) no dá error, por ello validamos si ya llegó a 100
            if (PBaBarraDeProgreso.Value==100)
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
            
        }

        private async void EjecutarTareasAsincronas()
        {
            await ConsultaDeDatosSqlAsync();
            await ImpresionReporteNoVisibleAsync();
        }

        private Task ConsultaDeDatosSqlAsync()
        {
            var db = new DbNatatorioContext();
            var listaSocios = db.Socios.ToList();
            CargaBBDDCompleta = true;
            return Task.CompletedTask;
        }

        private Task ImpresionReporteNoVisibleAsync()
        {
            ReportViewer reporte = new ReportViewer();
            //abrimos el reporte utilizando la clase FileStream
            using var fs = new FileStream(@"reportes\RptListadoDeSocios.rdlc", FileMode.Open);
            //asignamos el archivo a la propiedad LocalReport del objeto ReportViewer
            reporte.LocalReport.LoadReportDefinition(fs);
            //buscamos los datos que va a graficar el reporte
            using var db = new DbNatatorioContext();
            var socios = db.Socios.ToList();
            //asignamos los datos a la propiedad DataSources del ReportViewer, utilizando
            //un objeto del tipo ReportDataSource
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSSocios", socios));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
            return Task.CompletedTask;
        }
    }
}
