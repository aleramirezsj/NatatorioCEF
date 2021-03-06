using Microsoft.EntityFrameworkCore;
using NatatorioCEF.AdminData;
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
    public partial class FrmGestionSocios : Form
    {
        RepositorySocios _repositorySocios = new RepositorySocios(new DbNatatorioContext());
        public FrmGestionSocios()
        {
            InitializeComponent();
            ActualizarGrilla();

        }

        private void ActualizarGrilla()
        {
            
            GridSocios.DataSource = _repositorySocios.GetAll();
        }
        private void ActualizarGrillaFiltrada()
        {
            GridSocios.DataSource = _repositorySocios.GetAll(TxtBusqueda.Text);      
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarSocio frmNuevoEditarSocio = new FrmNuevoEditarSocio(_repositorySocios);
            frmNuevoEditarSocio.ShowDialog();
            //actualizamos la grilla para que se vea el nuevo socio agregado
            ActualizarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el ID del socio seleccionado actualmente en la grilla
            var idSeleccionado = Convert.ToInt32(GridSocios.CurrentRow.Cells[0].Value);
            var nombreSeleccionado = GridSocios.CurrentRow.Cells[1].Value.ToString() + " " + GridSocios.CurrentRow.Cells[2].Value.ToString();
            //preguntar si realmente desea eliminar al [nombre_Calendario_seleccionado]
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea borrar a {nombreSeleccionado}?", "Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el Calendario a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                _repositorySocios.Delete(idSeleccionado);
                ActualizarGrilla();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //obtenemos el ID del socio seleccionado actualmente en la grilla
            var idSeleccionado = Convert.ToInt32(GridSocios.CurrentRow.Cells[0].Value);
            //llamamos al formulario FrmNuevoEditarSocio pasándole por parámetro el IdSeleccionado
            FrmNuevoEditarSocio frmNuevoEditarSocio = new FrmNuevoEditarSocio(idSeleccionado,_repositorySocios);
            frmNuevoEditarSocio.ShowDialog();
            ActualizarGrilla();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Length > 0)
                ActualizarGrillaFiltrada();
            else
                ActualizarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmListadoDeSocios = new FrmListadoSocios();
            frmListadoDeSocios.ShowDialog();
        }

        private void GridSocios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridSocios.Columns["SocioGaranteId"] != null)
                GridSocios.Columns["SocioGaranteId"].Visible = false;
            if (GridSocios.Columns["LocalidadId"] != null)
                GridSocios.Columns["LocalidadId"].Visible = false;
        }
    }
}
