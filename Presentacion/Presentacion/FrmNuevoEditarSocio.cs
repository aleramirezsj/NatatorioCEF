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
    public partial class FrmNuevoEditarSocio : Form
    {
        RepositorySocios _repositorySocios = new RepositorySocios();

        //atributo que almacen el Id del socio que vamos a modificar
        private int idSocioModificado=0;
       //instanciamos un objeto DbContext que nos da acceso a la base de datos
       DbNatatorioContext dbNatatorio = new DbNatatorioContext();

        //constructor vacío que se ejecuta cuando creamos un nuevo socio
        public FrmNuevoEditarSocio()
            {
                InitializeComponent();
                CargarComboSocioGarante();
                CargarComboLocalidades();
            }
            //constructor que se ejecuta cuando modificamos un socio
        public FrmNuevoEditarSocio(int idSeleccionado)
        {
            InitializeComponent();
            this.idSocioModificado = idSeleccionado;

            Socio socio = (Socio)_repositorySocios.GetById(idSeleccionado);
            //colocamos en la pantalla los datos del socio recibido
            TxtApellido.Text = socio.Apellido;
            TxtNombre.Text = socio.Nombre;
            TxtTelefono.Text = socio.Teléfono;
            TxtDirección.Text = socio.Dirección;
            NudDni.Value = socio.DNI;
            CargarComboSocioGarante(socio.SocioGaranteId);
            CargarComboLocalidades(socio.LocalidadId);
        }

        private void CargarComboSocioGarante(int? socioGaranteId=0)
        {
            IEnumerable<Socio> listaSocios = from socio in dbNatatorio.Socios
                                             select new Socio { Id = socio.Id, Nombre = socio.Apellido + " " + socio.Nombre };
            //cargamos el listado de socios en el combobox
            CboSocioGarante.DataSource = listaSocios.ToList();
            CboSocioGarante.DisplayMember = "Nombre";
            CboSocioGarante.ValueMember = "Id";
            if (socioGaranteId != null)
                CboSocioGarante.SelectedValue = socioGaranteId;
            else
                CboSocioGarante.SelectedValue = 0;

            AutoCompleteStringCollection autoCompletado = new AutoCompleteStringCollection();
            foreach (Socio item in listaSocios.ToList())
            {
                autoCompletado.Add(item.Nombre.ToString());
            }
            CboSocioGarante.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboSocioGarante.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CboSocioGarante.AutoCompleteCustomSource = autoCompletado;
        }
        private void CargarComboLocalidades(int? localidadId = 0)
        {

            CboLocalidad.DataSource = dbNatatorio.Localidades.ToList();
            CboLocalidad.DisplayMember = "Nombre";
            CboLocalidad.ValueMember = "Id";
            if (localidadId != null)
                CboLocalidad.SelectedValue = localidadId;
            else
                CboLocalidad.SelectedValue = 0;

            AutoCompleteStringCollection autoCompletado = new AutoCompleteStringCollection();
            foreach (Localidad item in dbNatatorio.Localidades.ToList())
            {
                autoCompletado.Add(item.Nombre.ToString());
            }
            CboLocalidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CboLocalidad.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CboLocalidad.AutoCompleteCustomSource = autoCompletado;
        }

        

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            //creamos un objeto del tipo socio
            Socio socio = new Socio();
            //tomamos los valores de la pantalla para asignarselos a el objeto socio
            socio.Nombre = TxtNombre.Text;
            socio.Apellido = TxtApellido.Text;
            socio.DNI = Convert.ToInt32(NudDni.Value);
            socio.Teléfono = TxtTelefono.Text;
            socio.Dirección = TxtDirección.Text;
            socio.SocioGaranteId = (int?)CboSocioGarante.SelectedValue;
            socio.LocalidadId = (int?)CboLocalidad.SelectedValue;


            if (this.idSocioModificado == 0)
            {
                //agregamos el socio a la tabla Socios
                _repositorySocios.Add(socio);
            }
            else
            {
                socio.Id = this.idSocioModificado;
                _repositorySocios.Update(socio);
            }
            Close();
        }
    }
}
