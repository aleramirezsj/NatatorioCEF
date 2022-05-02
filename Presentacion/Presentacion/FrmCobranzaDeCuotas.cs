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
    public partial class FrmCobranzaDeCuotas : Form
    {
        DbNatatorioContext db = new DbNatatorioContext();
        string socioSeleccionado = "";
        int idSocioSeleccionado = 0;
        public FrmCobranzaDeCuotas()
        {
            InitializeComponent();
            CargarGrillaSocios();
            CargarCboCobradores();
        }

        private void CargarCboCobradores()
        {
            CboCobradores.DataSource=db.Cobradores.ToList();
            CboCobradores.DisplayMember = "NombreCompleto";
            CboCobradores.ValueMember = "Id";
            //CboCobradores.SelectedValue = 0;
        }

        private void CargarGrillaSocios()
        {
            GridSocios.DataSource = db.Socios.ToList();
        }

        private void TxtSocioBuscado_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaSociosFiltrada();
        }

        private void CargarGrillaSociosFiltrada()
        {
            GridSocios.DataSource = db.Socios.Where(s=>s.Apellido.Contains(TxtSocioBuscado.Text)||s.Nombre.Contains(TxtSocioBuscado.Text)).ToList();
        }

        private void GridSocios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridSocios.Rows.Count > 0)
            {
                idSocioSeleccionado = (int)GridSocios.CurrentRow.Cells[0].Value;
                socioSeleccionado = (string)GridSocios.CurrentRow.Cells[1].Value + " " + (string)GridSocios.CurrentRow.Cells[2].Value;
                lblSocioSeleccionado.Text = socioSeleccionado;
                ListarCuotasSocio();
            }
        }

        private void ListarCuotasSocio()
        {
            BtnAnularPago.Enabled = false;
            BtnRegistraPago.Enabled = false;
            var listaCuotasAdeudadas = from cuota in db.Cuotas
                              join socio in db.Socios
                              on cuota.SocioId equals socio.Id
                              where cuota.SocioId == idSocioSeleccionado && cuota.FechaPago==null
                              select new { Id = cuota.Id, Año=cuota.Año, Mes=cuota.Mes, Importe = cuota.Importe };
            GridCuotasAdeudadas.DataSource = listaCuotasAdeudadas.ToList();
            var listaCuotasPagas = from cuota in db.Cuotas
                                       join socio in db.Socios
                                       on cuota.SocioId equals socio.Id
                                       where cuota.SocioId == idSocioSeleccionado && cuota.FechaPago != null
                                       select new { Id = cuota.Id, Año = cuota.Año, Mes = cuota.Mes, Cobrado = cuota.Cobrado, FechaPago=cuota.FechaPago };
            GridCuotasPagas.DataSource = listaCuotasPagas.ToList();
        }

        private void GridCuotas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BtnRegistraPago.Enabled = true;
            if (GridCuotasAdeudadas.Columns["Id"] != null)
                GridCuotasAdeudadas.Columns["Id"].Width = 30;
            if (GridCuotasAdeudadas.Columns["Año"] != null)
                GridCuotasAdeudadas.Columns["Año"].Width = 50;
            if (GridCuotasAdeudadas.Columns["Mes"] != null)
                GridCuotasAdeudadas.Columns["Mes"].Width = 50;
            if (GridCuotasAdeudadas.Columns["Importe"] != null)
                GridCuotasAdeudadas.Columns["Importe"].Width = 60;
        }

        private void BtnRegistraPago_Click(object sender, EventArgs e)
        {
            //Obtener el ID de la cuota seleccionada en la grilla de cuotas
            int idCuotaSeleccionada = (int)GridCuotasAdeudadas.CurrentRow.Cells[0].Value;
            //Buscamos esa cuota con el método Find en el DbSet de cuotas, obteniendo un objeto del tipo Cuota.
            Cuota cuota = db.Cuotas.Find(idCuotaSeleccionada);
            //Definimos en la cuota obtenida la Fecha de Pago, Cobrador y el monto Cobrado(que teniendo en cuenta la fecha actual aplica o no el recargo, analizando si ya pasó la fecha de vencimiento)
            cuota.FechaPago = DateTime.Now;
            cuota.CobradorId = (int)CboCobradores.SelectedValue;
            cuota.Cobrado = DateTime.Now.Date > cuota.Vencimiento.Date ? cuota.Importe + cuota.Recargo : cuota.Importe;
            db.Entry(cuota).State = EntityState.Modified;
            db.SaveChanges();
            ListarCuotasSocio();

        }

        private void BtnAnularPago_Click(object sender, EventArgs e)
        {
            //Obtener el ID de la cuota seleccionada en la grilla de cuotas
            int idCuotaSeleccionada = (int)GridCuotasPagas.CurrentRow.Cells[0].Value;
            //Buscamos esa cuota con el método Find en el DbSet de cuotas, obteniendo un objeto del tipo Cuota.
            Cuota cuota = db.Cuotas.Find(idCuotaSeleccionada);
            //blanqueamos los campos registrados en el pago
            cuota.FechaPago = null;
            cuota.CobradorId = null;
            cuota.Cobrado = 0;
            db.Entry(cuota).State = EntityState.Modified;
            db.SaveChanges();
            ListarCuotasSocio();
        }

        private void GridCuotasPagas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BtnAnularPago.Enabled = true;
            if (GridCuotasPagas.Columns["Id"] != null)
                GridCuotasPagas.Columns["Id"].Width = 30;
            if (GridCuotasPagas.Columns["Año"] != null)
                GridCuotasPagas.Columns["Año"].Width = 50;
            if (GridCuotasPagas.Columns["Mes"] != null)
                GridCuotasPagas.Columns["Mes"].Width = 50;
            if (GridCuotasPagas.Columns["Cobrado"] != null)
                GridCuotasPagas.Columns["Cobrado"].Width = 60;
        }
    }
}
