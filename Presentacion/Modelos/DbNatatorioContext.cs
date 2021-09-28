using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentacion.Modelos
{
    public class DbNatatorioContext: DbContext
    {
        public DbNatatorioContext(DbContextOptions<DbNatatorioContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source = 192.168.1.100; Initial Catalog = VacunWebContext; User Id = sa; Password = 123; MultipleActiveResultSets = True");
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=DbNatatorioContext; User Id = sa; Password = 123; MultipleActiveResultSets = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Cobrador> Cobradores { get; set; }

        public DbNatatorioContext()
        {
        }
    }
}
