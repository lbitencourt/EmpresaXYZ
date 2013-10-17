using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace EmpresaXYZ.WebService.Response
{
    [DataContract]
    public abstract class ResponseBase
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Message { get; set; }

        public ResponseBase(string status, string message)
        {
            Status = status;
            Message = message;
        }    
    }
}
