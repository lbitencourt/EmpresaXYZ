using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EmpresaXYZ.Domain.Clientes;
using EmpresaXYZ.Repository;

namespace EmpresaXYZ.Test.Repository
{
    [TestFixture(Category = UnitTestCategory.REPOSITORY)]
    public class ClienteMemoryRepositoryTest
    {
        private Cliente CriaCliente()
        {
            return new Cliente("Leandro Bitencourt", "(31)XXXX-XXXX", "Av. Rua - Betim - Minas Gerais");
        }

        [Test]
        public void DeveIncluirUmClienteNoRepository()
        {
            IClienteRepository repository = new ClienteMemoryRepository();

            repository.ApagarTodos();

            var cliente = CriaCliente();
            var id = repository.Incluir(cliente);
            var clienteSalvo = repository.ObterClientePorId(id);

            Assert.IsNotNull(clienteSalvo);
        }

        [Test]
        public void DeveRetornarListaDeClienteComUmCliente()
        {
            IClienteRepository repository = new ClienteMemoryRepository();
            repository.ApagarTodos();

            var cliente = CriaCliente();
            repository.Incluir(cliente);

            var clientes = repository.ListarTodos();
            Assert.AreEqual(1, clientes.Count);
        }

        [Test]
        public void DeveAtualizarInformacoesDoCliente()
        {
            IClienteRepository repository = new ClienteMemoryRepository();
            repository.ApagarTodos();
            var cliente = CriaCliente();
            var id = repository.Incluir(cliente);
            cliente.Editar(new DateTime(1981, 11, 11), "(31)XXXX-XXXX");

            repository.Atualizar(cliente);

            var clienteAtualizado = repository.ObterClientePorId(id);
            Assert.AreEqual(new DateTime(1981, 11, 11), cliente.DataNascimento );
            Assert.AreEqual("(31)XXXX-XXXX", cliente.NumeroCelular);
        }
    }
}
