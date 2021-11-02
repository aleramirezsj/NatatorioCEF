using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NatatorioCEF.Modelos
{
    public class Usuario 
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public TipoUsuarioEnum TipoUsuario { get; set; }
        //sobrescrimos el método ToString para que cuando listemos
        //los movimientos de los usuarios, salga su nombre
        public override string  ToString()
        {
            return Nombre;
        }
    }
}
