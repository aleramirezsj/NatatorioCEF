using NUnit.Framework;
using NatatorioCEF.AdminData;
using System.Collections.Generic;
using Presentacion.Modelos;
using System.Linq;

namespace TestProjectNatatorio
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
            Assert.AreNotEqual(cobradores.Count(),0);
        }
    }
}