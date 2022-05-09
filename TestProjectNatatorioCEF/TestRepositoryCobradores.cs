using NatatorioCEF.AdminData;
using NUnit.Framework;
using Presentacion.Modelos;
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
            var _repository = new RepositoryCobradores();
            var cobrador = new Cobrador()
            {
                Nombre = "Cobrador",
                Apellido = "Testeo"
            };

            _repository.Add(cobrador);
            Assert.AreNotEqual(cobrador.Id, 0);
            _repository.Delete(cobrador.Id);

        }

    }
}