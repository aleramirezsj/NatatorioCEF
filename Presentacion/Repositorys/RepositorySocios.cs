using Microsoft.EntityFrameworkCore;
using NatatorioCEF.Interfaces;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatatorioCEF.AdminData
{
    public class RepositorySocios : IRepository
    {
        public DbNatatorioContext db;

        public RepositorySocios(DbNatatorioContext BBDD)
        {
            db = BBDD;
        }
        public RepositorySocios()
        {
            db = new DbNatatorioContext();
        }


        public IEnumerable<object> GetAll()
        {
            using var db = new DbNatatorioContext();
            return db.Socios.Include(s=>s.Localidad).ToList();
        }
        public IEnumerable<object> GetAll(string busqueda)
        {
            using var db = new DbNatatorioContext();
            return db.Socios.Where(c => c.Apellido.Contains(busqueda) || c.Nombre.Contains(busqueda) || c.DNI.ToString().Contains(busqueda)).Include(s=>s.Localidad).ToList();
        }

        public void Delete(int idAEliminar)
        {
            using var db = new DbNatatorioContext();
            Socio socioABorrar = db.Socios.Find(idAEliminar);
            db.Socios.Remove(socioABorrar);
            db.SaveChanges();
        }

        public void Add(object socio)
        {
            using var db = new DbNatatorioContext();
            db.Socios.Add((Socio)socio);
            db.SaveChanges();
        }

        public void Update(object socio)
        {
            using var db = new DbNatatorioContext();
            db.Entry((Socio)socio).State = EntityState.Modified;
            db.SaveChanges();
        }

        public object GetById(int id)
        {
            using var db = new DbNatatorioContext();
            var socio = db.Socios.Include(s=>s.Localidad).FirstOrDefault(s=>s.Id==id);
            return socio;
        }
    }
}

