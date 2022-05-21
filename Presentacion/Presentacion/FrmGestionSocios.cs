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
        private RepositorySocios _repositorySocios;

        DbNatatorioContext dbNatatorio = new DbNatatorioContext();
        public FrmGestionSocios()
        {
            InitializeComponent();
            ActualizarGrilla();
            _repositorySocios
        }

        private void ActualizarGrilla()
        {
            GridSocios.DataSource = _repositorySocios.GetAll();
        }
        private void ActualizarGrillaFiltrada()
        {
            //using DbNatatorioContext db = new DbNatatorioContext();
            //var listaSocios = from socio in db.Socios
            //                  join localidad in db.Localidades
            //                  on socio.LocalidadId equals localidad.Id
            //                  where socio.Nombre.Contains(TxtBusqueda.Text) || socio.Apellido.Contains(TxtBusqueda.Text)
            //        || socio.DNI.ToString().Contains(TxtBusqueda.Text)
            //                 select new
            //                 {
            //                     Nombre = socio.Nombre,
            //                     Apellido = socio.Apellido,
            //                     Localidad = localidad.Nombre
            //                 };
            
            GridSocios.DataSource = _repositorySocios.GetAll(TxtBusqueda.Text);
            //db.Socios.Include(s => s.Localidad).Where(s=>s.Apellido.Contains(TxtBusqueda.Text)||s.Nombre.Contains(TxtBusqueda.Text)||s.DNI.ToString().Contains(TxtBusqueda.Text)).ToList();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarSocio frmNuevoEditarSocio = new FrmNuevoEditarSocio();
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
                //instanciamos el objeto que nos permite trabajar con la base de datos
                using DbNatatorioContext db = new DbNatatorioContext();
                //buscamos al socio que queremos borrar
                Socio socio = db.Socios.Find(idSeleccionado);
                //lo borramos
                db.Socios.Remove(socio);
                //guardamos los cambios(esto es lo que realmente lo borra)
                db.SaveChanges();
                ActualizarGrilla();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //obtenemos el ID del socio seleccionado actualmente en la grilla
            var idSeleccionado = Convert.ToInt32(GridSocios.CurrentRow.Cells[0].Value);
            //llamamos al formulario FrmNuevoEditarSocio pasándole por parámetro el IdSeleccionado
            FrmNuevoEditarSocio frmNuevoEditarSocio = new FrmNuevoEditarSocio(idSeleccionado);
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

        private void FrmGestionSocios_Load(object sender, EventArgs e)
        {

        }
    }
}
