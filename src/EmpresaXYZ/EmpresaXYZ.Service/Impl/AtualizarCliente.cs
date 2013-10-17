using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmpresaXYZ.Service.Spec;
using EmpresaXYZ.Domain.Clientes;

namespace EmpresaXYZ.Service.Impl
{
    public class AtualizarCliente: IAtualizarCliente
    {
        private readonly IClienteRepository clienteRepository;

        public AtualizarCliente(IClienteRepository clienteRepository)
        { 
            this.clienteRepository = clienteRepository;
        }

        public void Atualizar(int id, DateTime dataNascimento, string numeroCelular)
        {
            var cliente = clienteRepository.ObterClientePorId(id);

            if (cliente == null)
                throw new ClienteNaoEncontradoException();

            cliente.Editar(dataNascimento, numeroCelular);
            clienteRepository.Atualizar(cliente);
        }
    }
}
