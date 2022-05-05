using NatatorioCEF.Interfaces;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatatorioCEF.AdminData
{
    internal class RepositoryCobradores
    {
        public IEnumerable<Cobrador> GetAll()
        {
            using DbNatatorioContext db = new DbNatatorioContext();
            return db.Cobradores.ToList();
        }
        public IEnumerable<Cobrador> GetAll(string busqueda)
        {
            using DbNatatorioContext db = new DbNatatorioContext();
            return db.Cobradores.Where(c=>c.Apellido.Contains(busqueda)||c.Nombre.Contains(busqueda)).ToList();
        }
    }
}
