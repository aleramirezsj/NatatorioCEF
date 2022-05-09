using NatatorioCEF.AdminData;
using NUnit.Framework;
using Presentacion.Modelos;
using System.Collections.Generic;
using System.Linq;

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
    }
}