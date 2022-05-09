using Microsoft.EntityFrameworkCore;
using NatatorioCEF.Interfaces;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatatorioCEF.AdminData
{
    public class RepositoryCobradores
    {

        DbNatatorioContext db = new DbNatatorioContext();

        public IEnumerable<Cobrador> GetAll()
        {
            return db.Cobradores.ToList();
        }
        public IEnumerable<Cobrador> GetAll(string busqueda)
        {
            return db.Cobradores.Where(c => c.Apellido.Contains(busqueda) || c.Nombre.Contains(busqueda)).ToList();
        }

        public void Delete(int idAEliminar)
        {
            Cobrador cobradorABorrar = db.Cobradores.Find(idAEliminar);
            db.Cobradores.Remove(cobradorABorrar);
            db.SaveChanges();
        }

        public void Add(Cobrador cobrador)
        {
            db.Cobradores.Add(cobrador);
            db.SaveChanges();
        }

        public void Update(Cobrador cobrador)
        {
            db.Entry(cobrador).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}

