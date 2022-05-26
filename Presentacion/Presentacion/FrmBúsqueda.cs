using ExtensionMethods;
using NatatorioCEF.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NatatorioCEF.Presentacion
{
    public partial class FrmBúsqueda : Form
    {
        IRepository _repository;
        //public int idSeleccionado = 0;
        public object entidadSeleccionada;
        public FrmBúsqueda(IRepository repository, string titulo)
        {
            InitializeComponent();
            _repository = repository;
            CargarGrilla();
            LblTitulo.Text = titulo;
        }

        private void CargarGrilla()
        {
            GridGeneric.DataSource = _repository.GetAll();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
             //idSeleccionado = (int)GridGeneric.CurrentRow.Cells[0].Value;
             var id = GridGeneric.IdSeleccionado();
            entidadSeleccionada = _repository.GetById(id);  
            Close();
              
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            GridGeneric.DataSource = _repository.GetAll(TxtBusqueda.Text);
        }

        private void GridGeneric_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnSeleccionar_Click(sender, e);
            }
        }

        private void GridGeneric_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSeleccionar_Click(sender, e);
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSeleccionar_Click(sender, e);
            }
        }
    }
}
