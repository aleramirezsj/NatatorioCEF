using Microsoft.EntityFrameworkCore;
using NatatorioCEF.Modelos;
using NatatorioCEF.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Presentacion.Modelos
{
    public class DbNatatorioContext: DbContext
    {
        static int cantidadInstancias=0;
        public DbNatatorioContext(DbContextOptions<DbNatatorioContext> options)
            : base(options)
        {
            cantidadInstancias++;
            Debug.Print(">>>>>>>>>>>>>>> CREANDO INSTANCIAS DEL DBCONTEXT=" + cantidadInstancias);
        }
        private void Destroy()
        {
            cantidadInstancias--;
            Debug.Print(">>>>>>>>>>>>>>> ELIMINANDO INSTANCIAS DEL DBCONTEXT=" + cantidadInstancias);

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source = 192.168.1.100; Initial Catalog = VacunWebContext; User Id = sa; Password = 123; MultipleActiveResultSets = True");
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=DbNatatorioContext; Integrated Security=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Carga de socios
            var pedro = new Socio { Id = 3, Apellido = "Rodriguez", Nombre = "Pedro", DNI = 56565656, Teléfono = "45454545", Dirección="San Martin 2435", SocioGaranteId=1, LocalidadId = 2 };

            modelBuilder.Entity<Socio>().HasData(
                 new Socio  { Id=1, Apellido="Perez", Nombre="Juan", DNI=12121212, Teléfono="34343434", Dirección="9 de julio 1232", SocioGaranteId=1, LocalidadId=1},
                 new Socio { Id = 2, Apellido = "Gomez", Nombre = "Adrian", DNI = 12787878, Teléfono = "98989898", Dirección="Pedro Millán 1212", SocioGaranteId= 1,LocalidadId = 1 }, pedro
            );
            #endregion
            #region Carga de cobradores
             modelBuilder.Entity<Cobrador>().HasData(
                 new Cobrador { Id = 1, Apellido = "Fernandez", Nombre = "José" },
                 new Cobrador { Id = 2, Apellido = "Gonzalez", Nombre = "Gustavo" }
            );
            #endregion
            #region Carga de localidades
            modelBuilder.Entity<Localidad>().HasData(
                new Localidad { Id = 1,  Nombre = "San Justo" },
                new Localidad { Id = 2, Nombre = "Gobernador Crespo" },
                new Localidad { Id = 3, Nombre = "Llambi Campbell" },
                new Localidad { Id = 4, Nombre = "Ramayón" }
           );
            #endregion
            #region Carga de Usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nombre = "Administrador", User="admin",Password=Helper.ObtenerHashSha256("1234"),TipoUsuario=TipoUsuarioEnum.Administrador },
                new Usuario { Id=2, Nombre="empleado", User="empleado", Password=Helper.ObtenerHashSha256("1234"),TipoUsuario=TipoUsuarioEnum.Empleado}
           );
            #endregion

            modelBuilder.Entity<Socio>()
            .HasOne(p => p.SocioGarante)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Cobrador> Cobradores { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuota> Cuotas { get; set; }


        public DbNatatorioContext()
        {
            cantidadInstancias++;
            Debug.Print(">>>>>>>>>>>>>>> CREANDO INSTANCIAS DEL DBCONTEXT=" + cantidadInstancias);
        }
    }
}
