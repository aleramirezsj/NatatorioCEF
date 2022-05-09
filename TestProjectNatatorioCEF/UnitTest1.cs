using NatatorioCEF.AdminData;
using NUnit.Framework;
using Presentacion.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TestProjectNatatorioCEF
{
    public class TestRepositoryCobradores
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetAll()
        {
            var _repository = new RepositoryCobradores();
            IEnumerable<Cobrador> cobradores = _repository.GetAll();
            Assert.AreNotEqual(cobradores.Count(), 0);
        }

        [Test]
        public void TestGetAllConFiltro()
        {
            var _repository = new RepositoryCobradores();
            IEnumerable<Cobrador> cobradoresFiltro = _repository.GetAll("josé");
            Assert.AreEqual(cobradoresFiltro.Count(), 1);
        }

        [Test]
        public void TestAdd()
        {
            DbNatatorioContext db = new DbNatatorioContext();      
            var _repository = new RepositoryCobradores( db);
            var cobrador = new Cobrador()
            {
                Nombre = "Cobrador",
                Apellido = "Testeo"
            };
            _repository.Add(cobrador);
            MessageBox.Show($"{cobrador.Id}");
            Assert.NotZero(cobrador.Id);

            db.Cobradores.Remove(cobrador);
            db.SaveChanges();
        }
        [Test]
        public void TestDelete()
        {
            DbNatatorioContext db = new DbNatatorioContext();
           
            var _repository = new RepositoryCobradores(db);            
            var cobrador = new Cobrador()
            {
                Nombre = "Cobrador",
                Apellido = "Testeo"               
            };
            db.Cobradores.Add(cobrador);
            db.SaveChanges();
            _repository.Delete(cobrador.Id);
            var verificacionCobrador = db.Cobradores.Find(cobrador.Id);
            //MessageBox.Show($"{verificacionCobrador.Nombre}");

            Assert.IsNull(verificacionCobrador);

        }

    }
}