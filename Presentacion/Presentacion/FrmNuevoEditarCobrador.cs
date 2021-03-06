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
    public partial class FrmNuevoEditarCobrador : Form
    {
        private RepositoryCobradores _repositoryCobradores = new RepositoryCobradores();


        //atributo que almacen el Id de la entidad que vamos a modificar
        private int idModificado=0;
       //instanciamos un objeto DbContext que nos da acceso a la base de datos
       DbNatatorioContext dbNatatorio = new DbNatatorioContext();

        //constructor vacío que se ejecuta cuando creamos una nueva entidad
        public FrmNuevoEditarCobrador()
            {
                InitializeComponent();
            }
            //constructor que se ejecuta cuando modificamos una entidad
        public FrmNuevoEditarCobrador(int idSeleccionado)
        {
            InitializeComponent();
            this.idModificado = idSeleccionado;
            
            Cobrador cobrador = (Cobrador)_repositoryCobradores.GetById(idSeleccionado);
            //colocamos en la pantalla los datos del socio recibido
            TxtApellido.Text = cobrador.Apellido;
            TxtNombre.Text = cobrador.Nombre;
            
        }




        

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            //creamos un objeto del tipo socio
            Cobrador cobrador = new Cobrador();
            //tomamos los valores de la pantalla para asignarselos a el objeto socio
            cobrador.Nombre = TxtNombre.Text;
            cobrador.Apellido = TxtApellido.Text;

            if (this.idModificado == 0)
            {
                //agregamos el socio a la tabla Socios
                _repositoryCobradores.Add(cobrador);
            }
            else
            {
                cobrador.Id = this.idModificado;
                
                _repositoryCobradores.Update(cobrador);
            }
            //guardamos los cambios
            
            Close();
        }
    }
}
