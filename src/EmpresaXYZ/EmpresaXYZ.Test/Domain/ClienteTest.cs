using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EmpresaXYZ.Domain.Clientes;

namespace EmpresaXYZ.Test.Domain
{
    [TestFixture(Category = UnitTestCategory.DOMAIN)]
    public class ClienteTest
    {
        [Test]
        public void DeveCriarUmCliente()
        {
            var cliente = new Cliente("nome", "telefone", "endereco");

            Assert.AreEqual("nome", cliente.Nome);
            Assert.AreEqual("telefone", cliente.TelefoneResidencial);
            Assert.AreEqual("endereco", cliente.Endereco);
        }

        [Test]
        public void DeveAlterarDataNascimenteENumeroCelularDoCliente()
        {
            var cliente = new Cliente("nome", "telefone", "endereco");

            cliente.Editar(new DateTime(1981, 11, 11), "(31)XXXX-XXXX");

            Assert.AreEqual(new DateTime(1981, 11, 11), cliente.DataNascimento);
            Assert.AreEqual("(31)XXXX-XXXX", cliente.NumeroCelular);
        }
    }
}
