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
        public int idSeleccionado = 0;
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
             idSeleccionado = (int)GridGeneric.CurrentRow.Cells[0].Value;
            Close();
              
        }
    }
}
