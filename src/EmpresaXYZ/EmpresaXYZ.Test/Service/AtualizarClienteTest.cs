using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EmpresaXYZ.Repository;
using EmpresaXYZ.Domain.Clientes;
using EmpresaXYZ.Service.Spec;
using EmpresaXYZ.Service.Impl;

namespace EmpresaXYZ.Test.Service
{
    [TestFixture(Category = UnitTestCategory.SERVICE)]
    public class AtualizarClienteTest
    {
        IClienteRepository clienteRepository;
        IAtualizarCliente atualizarCliente;
        [SetUp]
        public void Inicializar()
        {
            clienteRepository = new ClienteMemoryRepository();
            atualizarCliente = new AtualizarCliente(clienteRepository);
        }

        [Test]
        public void DeveAtualizarClienteComInformacoesValidas()
        {            
            clienteRepository.ApagarTodos();
            clienteRepository.Incluir(new Cliente("nome", "telefone", "endereco"));

            atualizarCliente.Atualizar(1, new DateTime(1981, 11,11), "(31)XXXX-XXXX");

            var cliente = clienteRepository.ObterClientePorId(1);
            Assert.AreEqual(new DateTime(1981, 11, 11), cliente.DataNascimento);
            Assert.AreEqual("(31)XXXX-XXXX", cliente.NumeroCelular);
        }

        [Test]
        public void DeveRetornarUsuarioNaoEncontradaExceptionComUsuarioInvalido()
        {
            clienteRepository.ApagarTodos();
            Assert.Throws<ClienteNaoEncontradoException>(
                ()=> atualizarCliente.Atualizar(1, new DateTime(1981, 11, 11), "(31)XXXX-XXXX"));
        }
    }
}
