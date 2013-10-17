using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace EmpresaXYZ.WebService.Request
{
    [DataContract(Name = "Cliente")]
    public class EditarClienteRequest
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string DataNascimento { get; set; }

        [DataMember]
        public string NumeroCelular { get; set; }
    }
}