using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmpresaXYZ.Service.Spec
{
    public interface IAtualizarCliente
    {
        void Atualizar(int id, DateTime dataNascimento, string numeroCelular);
    }
}
