using Microsoft.EntityFrameworkCore;
using NatatorioCEF.Modelos;
using NatatorioCEF.Utils;
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
    public partial class FrmNuevoEditarUsuario : Form
    {
        //atributo que almacen el Id de la entidad que vamos a modificar
        private int idModificado=0;
       //instanciamos un objeto DbContext que nos da acceso a la base de datos
       DbNatatorioContext dbNatatorio = new DbNatatorioContext();
        Usuario usuario;

        //constructor vacío que se ejecuta cuando creamos una nueva entidad
        public FrmNuevoEditarUsuario()
            {
                InitializeComponent();
                LlenarCboTipoUsuario();
                usuario = new Usuario();
            }

        private void LlenarCboTipoUsuario()
        {
            CboTipoUsuario.DataSource = Enum.GetValues(typeof(TipoUsuarioEnum));
        }

        //constructor que se ejecuta cuando modificamos una entidad
        public FrmNuevoEditarUsuario(int idSeleccionado)
        {
            InitializeComponent();
            LlenarCboTipoUsuario();
            this.idModificado = idSeleccionado;
            using DbNatatorioContext db = new DbNatatorioContext();
            //obtenemos el Socio a través de el ID recibido
            usuario = db.Usuarios.Find(idSeleccionado);
            //colocamos en la pantalla los datos del socio recibido
            TxtNombre.Text = usuario.Nombre;
            TxtUsuario.Text = usuario.User;
            TxtContraseña.Text = usuario.Password;
            CboTipoUsuario.SelectedItem = usuario.TipoUsuario;
            
        }




        

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (ControlDeCargaDeDatos())
            {
                //tomamos los valores de la pantalla para asignarselos a el objeto socio
                usuario.Nombre = TxtNombre.Text;
                usuario.User = TxtUsuario.Text;
                usuario.TipoUsuario = (TipoUsuarioEnum)CboTipoUsuario.SelectedValue;
                if (TxtContraseña.Text != usuario.Password)
                    usuario.Password = Helper.ObtenerHashSha256(TxtContraseña.Text);

                if (this.idModificado == 0)
                {
                    //agregamos el socio a la tabla Socios
                    dbNatatorio.Usuarios.Add(usuario);
                }
                else
                {
                    usuario.Id = this.idModificado;
                    dbNatatorio.Entry(usuario).State = EntityState.Modified;
                }
                //guardamos los cambios
                dbNatatorio.SaveChanges();
                Close();
            }else
            {
                MessageBox.Show("Error, hay datos obligatorios que no fueron cargados", "Datos incompletos", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private bool ControlDeCargaDeDatos()
        {
            return (TxtNombre.TextLength > 0
                    && TxtContraseña.TextLength > 0
                    && TxtUsuario.TextLength > 0);
        }
    }
}
