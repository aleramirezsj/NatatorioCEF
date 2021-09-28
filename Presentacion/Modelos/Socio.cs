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
    }
}
