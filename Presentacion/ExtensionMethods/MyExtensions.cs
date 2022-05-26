
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public static class MyExtensions
    {

        public static int IdSeleccionado(this ComboBox combo)
        {
            if (combo.SelectedValue != null && combo.SelectedValue.GetType() == typeof(int))
            {
                return (int)combo.SelectedValue;
            }
            else
                return 0;
        }
        public static string ObtenerColumna(this DataGridView grid, string columna)
        {
            if (grid.CurrentRow != null && grid.RowCount > 0)
                return grid.CurrentRow.Cells[columna].Value.ToString();
            else
                return "";
        }


        public static void MensajeAdvertenciaDeSalida(this Form form)
        {
            var respuesta = MessageBox.Show($"¿Está seguro que desea salir del formulario {form.Text}", "Atención", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
                form.Close();
        }
        public static int IdSeleccionado(this DataGridView grid)
        {
            return int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
        }
        //método sobre las grillas que oculta las columnas que normalmente no se muestran






        public static void OcultarColumnas(this DataGridView grid, string[] columnasAOcultar)
        {
            //form.EstaVisible() &&
            if (grid.RowCount > 0)
            {
                //oculta siempre las columnas que terminan con Id, ejemplo UsuarioId
                foreach (string columnaAOcultar in columnasAOcultar)
                {
                    foreach (DataGridViewColumn columna in grid.Columns)
                    {
                        if (columna.Name == columnaAOcultar)
                        {
                            columna.Visible = false;
                        }

                    }
                }

            }

        }



        public static bool EstaVisible(this Form form)
        {
            return Application.OpenForms.OfType<Form>().Where(f => f.Name == form.Name).SingleOrDefault<Form>() != null;
        }

    }

}