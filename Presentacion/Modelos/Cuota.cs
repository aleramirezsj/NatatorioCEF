using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatatorioCEF.Modelos
{
    public class Cuota
    {
        public int Id { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public float Importe { get; set; }
        public DateTime Vencimiento { get; set; }
        public DateTime FechaPago { get; set; }
        public float Recargo { get; set; }
        public float Cobrado { get; set; }
        public int? CobradorId { get; set; }
        public Cobrador Cobrador { get; set; }
        public int SocioId { get; set; }
        public Socio Socio { get; set; }
    }
}
