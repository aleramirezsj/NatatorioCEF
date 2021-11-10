using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Reporting.WinForms;
using NatatorioCEF.Modelos;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmListadoCuotas : Form
    {
        private readonly ReportViewer reporte;
        DbNatatorioContext db = new DbNatatorioContext();
        int añoSeleccionado;
        int mesSeleccionado;
        int cuotaSeleccionada=0;
        public FrmListadoCuotas(int año, int mes)
        {
            InitializeComponent();
            añoSeleccionado = año;
            mesSeleccionado = mes;
            
            //instanciamos un Visor de Reportes
            reporte = new ReportViewer();
            //hacemos que ocupe toda el formulario
            reporte.Dock = DockStyle.Fill;
            //agregamos visualmente el visor de reportes al formulario
            Controls.Add(reporte);
        }
        public FrmListadoCuotas(int idcuota)
        {
            InitializeComponent();
            cuotaSeleccionada = idcuota;

            //instanciamos un Visor de Reportes
            reporte = new ReportViewer();
            //hacemos que ocupe toda el formulario
            reporte.Dock = DockStyle.Fill;
            //agregamos visualmente el visor de reportes al formulario
            Controls.Add(reporte);
        }

        private void FrmListadoSocios_Load(object sender, EventArgs e)
        {
            //abrimos el reporte utilizando la clase FileStream
            using var fs = new FileStream(@"reportes\RptListadoDeCuotasPeriodo.rdlc", FileMode.Open);
            //asignamos el archivo a la propiedad LocalReport del objeto ReportViewer
            reporte.LocalReport.LoadReportDefinition(fs);
            //buscamos los datos que va a graficar el reporte

            if (cuotaSeleccionada > 0)
            {
                var cuotas = from cuota in db.Cuotas
                             join socio in db.Socios
                             on cuota.SocioId equals socio.Id
                             where cuota.Id == cuotaSeleccionada
                             select new
                             {
                                 Id = cuota.Id,
                                 Mes = cuota.Mes,
                                 Año = cuota.Año,
                                 Importe = cuota.Importe,
                                 Vencimiento = cuota.Vencimiento,
                                 Recargo = cuota.Recargo,
                                 Socio = socio.Apellido + " " + socio.Nombre
                             };
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCuotas", cuotas.ToList()));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                reporte.RefreshReport();
            }
            else
            {
                var cuotas = from cuota in db.Cuotas
                             join socio in db.Socios
                             on cuota.SocioId equals socio.Id
                             where cuota.Año == añoSeleccionado && cuota.Mes == mesSeleccionado
                             select new
                             {
                                 Id = cuota.Id,
                                 Mes = cuota.Mes,
                                 Año = cuota.Año,
                                 Importe = cuota.Importe,
                                 Vencimiento = cuota.Vencimiento,
                                 Recargo = cuota.Recargo,
                                 Socio = socio.Apellido + " " + socio.Nombre
                             };
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCuotas", cuotas.ToList()));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                reporte.RefreshReport();
            }
            //var cuotas = db.Cuotas.Include(c=>c.Socio).ToList();
            //asignamos los datos a la propiedad DataSources del ReportViewer, utilizando
            //un objeto del tipo ReportDataSource
            
        }
    }
}
