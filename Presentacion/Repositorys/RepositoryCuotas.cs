using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NatatorioCEF.Repositorys
{
    public class RepositoryCuotas
    {
        public IEnumerable<object> ObtenerCuotasAdeudadas(int idSocio)
        {
            DbNatatorioContext db = new DbNatatorioContext();
            var listaCuotasAdeudadas = from cuota in db.Cuotas
                                       join socio in db.Socios
                                       on cuota.SocioId equals socio.Id
                                       where cuota.SocioId == idSocio && cuota.FechaPago == null
                                       select new { Id = cuota.Id, Año = cuota.Año, Mes = cuota.Mes, Importe = cuota.Importe };
            return listaCuotasAdeudadas.ToList();
        }

        public IEnumerable<object> ObtenerCuotasPagadas(int idSocio)
        {
            DbNatatorioContext db = new DbNatatorioContext();
            var listaCuotasPagas = from cuota in db.Cuotas
                                   join socio in db.Socios
                                   on cuota.SocioId equals socio.Id
                                   where cuota.SocioId == idSocio && cuota.FechaPago != null
                                   select new { Id = cuota.Id, Año = cuota.Año, Mes = cuota.Mes, Cobrado = cuota.Cobrado, FechaPago = cuota.FechaPago };
            return listaCuotasPagas.ToList();
        }

    }
}
