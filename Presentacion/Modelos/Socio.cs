using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Presentacion.Modelos
{
    public class Socio
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string? Teléfono { get; set; }
        public string Dirección { get; set; }
        public int? SocioGaranteId { get; set; }
        public Socio SocioGarante { get; set; }
        public int? LocalidadId { get; set; }
        public Localidad Localidad { get; set; }

        public override string ToString()
        {
            return Apellido+" "+Nombre;
        }
    }
}
