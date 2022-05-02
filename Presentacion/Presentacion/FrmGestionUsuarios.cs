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

namespace Presentacion
{
    public partial class FrmGestionUsuarios : Form
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();
            ActualizarGrilla();

        }

        private void ActualizarGrilla()
        {
            using DbNatatorioContext db = new DbNatatorioContext();
            GridLista.DataSource = db.Usuarios.ToList();
        }
        private void ActualizarGrillaFiltrada()
        {
            using DbNatatorioContext db = new DbNatatorioContext();
            GridLista.DataSource = db.Usuarios.Where(s=>s.Nombre.Contains(TxtBusqueda.Text)).ToList();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarUsuario frmNuevoEditarUsuario = new FrmNuevoEditarUsuario();
            frmNuevoEditarUsuario.ShowDialog();
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
                //instanciamos el objeto que nos permite trabajar con la base de datos
                using DbNatatorioContext db = new DbNatatorioContext();
                //buscamos al socio que queremos borrar
                Usuario usuario = db.Usuarios.Find(idSeleccionado);
                //lo borramos
                db.Usuarios.Remove(usuario);
                //guardamos los cambios(esto es lo que realmente lo borra)
                db.SaveChanges();
                ActualizarGrilla();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //obtenemos el ID del socio seleccionado actualmente en la grilla
            var idSeleccionado = Convert.ToInt32(GridLista.CurrentRow.Cells[0].Value);
            //llamamos al formulario FrmNuevoEditarSocio pasándole por parámetro el IdSeleccionado
            FrmNuevoEditarUsuario frmNuevoEditarUsuario = new FrmNuevoEditarUsuario(idSeleccionado);
            frmNuevoEditarUsuario.ShowDialog();
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
            //var frmListadoDeCobradores = new FrmListadoCobradores();
            //frmListadoDeCobradores.ShowDialog();
        }

        private void GridSocios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridLista.Columns["Password"] != null)
                GridLista.Columns["Password"].Visible = false;
        }
    }
}
