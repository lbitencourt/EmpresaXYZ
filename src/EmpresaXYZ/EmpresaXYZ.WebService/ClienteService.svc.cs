using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EmpresaXYZ.Domain.Clientes;
using EmpresaXYZ.WebService.Response;
using EmpresaXYZ.WebService.Request;
using EmpresaXYZ.Service.Spec;
using EmpresaXYZ.Infra.Converters;
using System.ServiceModel.Activation;

namespace EmpresaXYZ.WebService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ClienteService : IClientesService
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IAtualizarCliente atualizarCliente;


        public ClienteService(IClienteRepository clienteRepository, IAtualizarCliente atualizarCliente)
        {
            this.clienteRepository = clienteRepository;
            this.atualizarCliente = atualizarCliente;
        }

        public List<ConsultaClienteResponse> Consulta()
        {
            return clienteRepository.ListarTodos()
                .Select(c => new ConsultaClienteResponse()
                {
                    DataNascimento = c.DataNascimento.HasValue ? c.DataNascimento.Value.ToString("dd/MM/yyyy") : null,
                    Endereco = c.Endereco,
                    Id = c.Id.ToString(),
                    NumeroCelular = c.NumeroCelular,
                    TelefoneResidencial = c.TelefoneResidencial,
                    Nome = c.Nome
                }).ToList();
        }

        public EditarClienteResponse Atualizar(EditarClienteRequest request)
        {            
            if (string.IsNullOrWhiteSpace(request.Id) || !request.Id.IsInteger())
                return EditarClienteResponse.Error("Por favor, informe um id válido.");

            if (string.IsNullOrWhiteSpace(request.DataNascimento) || !request.DataNascimento.IsDateTime())
                return EditarClienteResponse.Error("Por favor, informe uma data de nascimento válida");

            if (string.IsNullOrWhiteSpace(request.NumeroCelular))
                return EditarClienteResponse.Error("Por favor, informe um número celular válido");

            var id = request.Id.ToInt32();
            var dataNascimento = request.DataNascimento.ToDateTime();
            
            try
            {
                atualizarCliente.Atualizar(id, dataNascimento, request.NumeroCelular);
            }
            catch (ClienteNaoEncontradoException)
            {
                return EditarClienteResponse.Error("Não foi possivel realizar a alteração. Cliente não encontrado");
            }

            return EditarClienteResponse.Success();
        }

    }
}
