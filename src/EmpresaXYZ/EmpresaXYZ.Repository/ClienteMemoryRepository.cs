using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmpresaXYZ.Domain.Clientes;

namespace EmpresaXYZ.Repository
{
    public class ClienteMemoryRepository : IClienteRepository
    {
        private static HashSet<Cliente> clientes = new HashSet<Cliente>();

        public ClienteMemoryRepository()
        {
            for (int i = 0; i < 40; i++)
            {

                Incluir(new Cliente(
                    string.Format("Fulano {0}", i),
                    string.Format("(31)3333-44{0}", i.ToString("00")),
                    string.Format("Rua da casa {0}", i)));
            }
        }

        public int Incluir(Cliente cliente)
        {
            cliente.GetType().GetProperty("Id").SetValue(cliente, ObterChaveCliente(), null);
            clientes.Add(cliente);

            return cliente.Id;
        }

        private int ObterChaveCliente()
        {
            var id = 0;

            if (clientes.Count != 0)
                id = clientes.Max(c => c.Id);

            return id + 1;
        }

        public Cliente ObterClientePorId(int id)
        {
            return clientes.Where(c => c.Id == id).SingleOrDefault();
        }

        public IList<Cliente> ListarTodos()
        {
            return clientes.ToList();
        }

        public void ApagarTodos()
        {
            clientes = new HashSet<Cliente>();
        }

        public void Atualizar(Cliente cliente)
        {
            clientes.RemoveWhere(c => c.Id == cliente.Id);
            clientes.Add(cliente);
        }
    }
}
