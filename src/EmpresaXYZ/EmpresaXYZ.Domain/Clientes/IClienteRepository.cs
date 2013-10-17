using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpresaXYZ.Domain.Clientes
{
    public interface IClienteRepository
    {
        int Incluir(Cliente cliente);

        Cliente ObterClientePorId(int id);

        IList<Cliente> ListarTodos();

        void ApagarTodos();

        void Atualizar(Cliente cliente);
    }
}
