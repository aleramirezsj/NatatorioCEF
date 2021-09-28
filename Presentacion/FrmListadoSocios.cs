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
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmListadoSocios : Form
    {
        private readonly ReportViewer reporte;
        public FrmListadoSocios()
        {
            InitializeComponent();
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
            using var fs = new FileStream(@"reportes\RptListadoDeSocios.rdlc", FileMode.Open);
            //asignamos el archivo a la propiedad LocalReport del objeto ReportViewer
            reporte.LocalReport.LoadReportDefinition(fs);
            //buscamos los datos que va a graficar el reporte
            using var db = new DbNatatorioContext();
            var socios = db.Socios.ToList();
            //asignamos los datos a la propiedad DataSources del ReportViewer, utilizando
            //un objeto del tipo ReportDataSource
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSSocios", socios));
            reporte.RefreshReport();
        }
    }
}
