using Microsoft.EntityFrameworkCore;
using NatatorioCEF.Interfaces;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatatorioCEF.AdminData
{
    public class RepositoryCobradores : IRepository
    {
        public DbNatatorioContext db;

        public RepositoryCobradores(DbNatatorioContext BBDD)
        {
            db = BBDD;
        }

        public RepositoryCobradores()
        {
            db = new DbNatatorioContext();
        }

        public IEnumerable<object> GetAll()
        {
            return db.Cobradores.ToList();
        }
        public IEnumerable<object> GetAll(string busqueda)
        {
            return db.Cobradores.Where(c => c.Apellido.Contains(busqueda) || c.Nombre.Contains(busqueda)).ToList();
        }

        public void Delete(int idAEliminar)
        {
            Cobrador cobradorABorrar = db.Cobradores.Find(idAEliminar);
            db.Cobradores.Remove(cobradorABorrar);
            db.SaveChanges();
        }

        public void Add(object cobrador)
        {
            db.Cobradores.Add((Cobrador)cobrador);
            db.SaveChanges();
        }

        public void Update(object cobrador)
        {
            db.Entry((Cobrador)cobrador).State = EntityState.Modified;
            db.SaveChanges();
        }

        public object GetById(int id)
        {
            var cobrador = db.Cobradores.Find(id);
            return cobrador;
        }
    }
}

