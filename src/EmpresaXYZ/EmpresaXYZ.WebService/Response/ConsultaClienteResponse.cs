using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace EmpresaXYZ.WebService.Response
{
    [DataContract()]
    public class ConsultaClienteResponse
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string TelefoneResidencial { get; set; }

        [DataMember]
        public string Endereco { get; set; }

        [DataMember]
        public string DataNascimento { get; set; }

        [DataMember]
        public string NumeroCelular { get; set; }

        [DataMember]
        public string Nome { get; set; }
    }
}