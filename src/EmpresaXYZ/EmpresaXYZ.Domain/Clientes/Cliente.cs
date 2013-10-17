using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpresaXYZ.Domain.Clientes
{
    public class Cliente
    {
        protected Cliente() { }

        public Cliente(string nome, string telefoneResidencial, string endereco)
        {
            this.Nome = nome;
            this.TelefoneResidencial = telefoneResidencial;
            this.Endereco = endereco;
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string TelefoneResidencial { get; private set; }

        public string Endereco { get; private set; }

        public DateTime? DataNascimento { get; private set; }

        public string NumeroCelular { get; private set; }

        public void Editar(DateTime dataNascimento, string numeroCelular)
        {
            this.DataNascimento = dataNascimento;
            this.NumeroCelular = numeroCelular;
        }
    }
}
