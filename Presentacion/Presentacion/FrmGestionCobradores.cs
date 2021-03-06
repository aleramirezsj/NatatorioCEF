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
    public partial class FrmGestionCobradores : Form
    {
        private RepositoryCobradores _repositoryCobradores = new RepositoryCobradores();
        public FrmGestionCobradores()
        {
            InitializeComponent();
            ActualizarGrilla();

        }

        private void ActualizarGrilla()
        {

            GridLista.DataSource = _repositoryCobradores.GetAll();
        }
        private void ActualizarGrillaFiltrada()
        {
           GridLista.DataSource = _repositoryCobradores.GetAll(TxtBusqueda.Text);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarCobrador frmNuevoEditarCobrador = new FrmNuevoEditarCobrador();
            frmNuevoEditarCobrador.ShowDialog();
            //actualizamos la grilla para que se vea el nuevo socio agregado
            ActualizarGrilla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el ID del socio seleccionado actualmente en la grilla
            var idSeleccionado = Convert.ToInt32(GridLista.CurrentRow.Cells[0].Value);
            var nombreSeleccionado = GridLista.CurrentRow.Cells[1].Value.ToString() + " " + GridLista.CurrentRow.Cells[2].Value.ToString();
            //preguntar si realmente desea eliminar al [nombre_Calendario_seleccionado]
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea borrar a {nombreSeleccionado}?", "Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //si responde que si, instanciamos al objeto dbcontext, y eliminamos el Calendario a través del id que obtuvimos
            if (respuesta == DialogResult.Yes)
            {
                _repositoryCobradores.Delete(idSeleccionado);
                ActualizarGrilla();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //obtenemos el ID del socio seleccionado actualmente en la grilla
            var idSeleccionado = Convert.ToInt32(GridLista.CurrentRow.Cells[0].Value);
            //llamamos al formulario FrmNuevoEditarSocio pasándole por parámetro el IdSeleccionado
            FrmNuevoEditarCobrador frmNuevoEditarCobrador = new FrmNuevoEditarCobrador(idSeleccionado);
            frmNuevoEditarCobrador.ShowDialog();
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
            var frmListadoDeCobradores = new FrmListadoCobradores();
            frmListadoDeCobradores.ShowDialog();
        }

        private void GridSocios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridLista.Columns["SocioGaranteId"] != null)
                GridLista.Columns["SocioGaranteId"].Visible = false;
            if (GridLista.Columns["LocalidadId"] != null)
                GridLista.Columns["LocalidadId"].Visible = false;
        }
    }
}
