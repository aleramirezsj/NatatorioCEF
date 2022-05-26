using Microsoft.EntityFrameworkCore;
using NatatorioCEF.AdminData;
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
using ExtensionMethods;
using NatatorioCEF.Repositorys;

namespace NatatorioCEF.Presentacion
{
    public partial class FrmCobranzaDeCuotasInyDependencias : Form
    {
        DbNatatorioContext db = new DbNatatorioContext();
        Socio socioSeleccionado;
        Cobrador cobradorSeleccionado;
        RepositorySocios repositorySocios = new RepositorySocios();
        RepositoryCuotas repositoryCuotas = new RepositoryCuotas();
        RepositoryCobradores repositoryCobradores = new RepositoryCobradores();

        public FrmCobranzaDeCuotasInyDependencias()
        {
            InitializeComponent();
        }

        

        




        private void ListarCuotasSocio()
        {

            if (socioSeleccionado != null)
            {
                BtnAnularPago.Enabled = false;
                BtnRegistraPago.Enabled = false;

                GridCuotasAdeudadas.DataSource = repositoryCuotas.ObtenerCuotasAdeudadas(socioSeleccionado.Id);

                GridCuotasPagas.DataSource = repositoryCuotas.ObtenerCuotasPagadas(socioSeleccionado.Id);
            }
            else
            {
                GridCuotasAdeudadas.DataSource = null;
                GridCuotasPagas.DataSource = null;
            }
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
            //int idCuotaSeleccionada = (int)GridCuotasAdeudadas.CurrentRow.Cells[0].Value;
            int idCuotaSeleccionada = GridCuotasAdeudadas.IdSeleccionado();
            //Buscamos esa cuota con el método Find en el DbSet de cuotas, obteniendo un objeto del tipo Cuota.
            Cuota cuota = db.Cuotas.Find(idCuotaSeleccionada);
            //Definimos en la cuota obtenida la Fecha de Pago, Cobrador y el monto Cobrado(que teniendo en cuenta la fecha actual aplica o no el recargo, analizando si ya pasó la fecha de vencimiento)
            cuota.FechaPago = DateTime.Now;
            cuota.CobradorId = cobradorSeleccionado.Id;
            cuota.Cobrado = DateTime.Now.Date > cuota.Vencimiento.Date ? cuota.Importe + cuota.Recargo : cuota.Importe;
            db.Entry(cuota).State = EntityState.Modified;
            db.SaveChanges();
            ListarCuotasSocio();

        }

        private void BtnAnularPago_Click(object sender, EventArgs e)
        {
            //Obtener el ID de la cuota seleccionada en la grilla de cuotas
            //int idCuotaSeleccionada = (int)GridCuotasPagas.CurrentRow.Cells[0].Value;
            int idCuotaSeleccionada = GridCuotasPagas.IdSeleccionado();
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

        private void BtnBuscarSocio_Click(object sender, EventArgs e)
        {
            FrmBúsqueda frmBúsqueda = new FrmBúsqueda(new RepositorySocios(), "Socios");
            frmBúsqueda.ShowDialog();
            socioSeleccionado = (Socio)frmBúsqueda.entidadSeleccionada;
            if (socioSeleccionado != null)
            {
                TxtSocioBuscado.Text = socioSeleccionado.NombreCompleto;
            }
            else
            {
                TxtSocioBuscado.Text = "";
            }
            ListarCuotasSocio();
        }

        private void BtnBuscarCobrador_Click(object sender, EventArgs e)
        {
            FrmBúsqueda frmBúsqueda = new FrmBúsqueda(new RepositoryCobradores(), "Cobradores");
            frmBúsqueda.ShowDialog();
            cobradorSeleccionado = (Cobrador)frmBúsqueda.entidadSeleccionada;
            TxtCobradorBuscado.Text = cobradorSeleccionado != null?cobradorSeleccionado.NombreCompleto:"";

        }
    }
}
