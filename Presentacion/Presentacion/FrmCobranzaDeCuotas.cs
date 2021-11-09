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
                lblSocioSeleccionado.Text = "Cuotas de " + socioSeleccionado;
                ListarCuotasSocio();
            }
        }

        private void ListarCuotasSocio()
        {
            var listaCuotas = from cuota in db.Cuotas
                              join socio in db.Socios
                              on cuota.SocioId equals socio.Id
                              where cuota.SocioId == idSocioSeleccionado
                              select new { Id = cuota.Id, Año=cuota.Año, Mes=cuota.Mes, Importe = cuota.Importe };
            GridCuotas.DataSource = listaCuotas.ToList();
            //GridCuotas.DataSource=db.Cuotas.Where(c=>c.SocioId==idSocioSeleccionado).ToList();
        }

        private void GridCuotas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCuotas.Columns["Id"] != null)
                GridCuotas.Columns["Id"].Width = 30;
            if (GridCuotas.Columns["Año"] != null)
                GridCuotas.Columns["Año"].Width = 50;
            if (GridCuotas.Columns["Mes"] != null)
                GridCuotas.Columns["Mes"].Width = 50;
            if (GridCuotas.Columns["Importe"] != null)
                GridCuotas.Columns["Importe"].Width = 60;
        }
    }
}
