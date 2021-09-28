using Microsoft.EntityFrameworkCore;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmNuevoEditarSocio : Form
    {
        //atributo que almacen el Id del socio que vamos a modificar
        private int idSocioModificado=0;

        //constructor vacío que se ejecuta cuando creamos un nuevo socio
        public FrmNuevoEditarSocio()
        {
            InitializeComponent();
        }
        //constructor que se ejecuta cuando modificamos un socio
        public FrmNuevoEditarSocio(int idSeleccionado)
        {
            InitializeComponent();
            this.idSocioModificado = idSeleccionado;
            using DbNatatorioContext db = new DbNatatorioContext();
            //obtenemos el Socio a través de el ID recibido
            Socio socio = db.Socios.Find(idSeleccionado);
            //colocamos en la pantalla los datos del socio recibido
            TxtApellido.Text = socio.Apellido;
            TxtNombre.Text = socio.Nombre;
            TxtTelefono.Text = socio.Teléfono;
            NudDni.Value = socio.DNI;

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

            //instanciamos un objeto DbContext que nos da acceso a la base de datos
            using DbNatatorioContext db = new DbNatatorioContext();
            if (this.idSocioModificado == 0)
            {
                //agregamos el socio a la tabla Socios
                db.Socios.Add(socio);
            }
            else
            {
                socio.Id = this.idSocioModificado;
                db.Entry(socio).State = EntityState.Modified;
            }
            //guardamos los cambios
            db.SaveChanges();
            Close();
        }
    }
}
