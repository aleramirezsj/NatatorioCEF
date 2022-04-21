using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Presentacion.Modelos
{
    public class Cobrador
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [NotMapped]
        public string NombreCompleto
        {
            get { return Nombre+" "+Apellido; }
        }

    }
}
