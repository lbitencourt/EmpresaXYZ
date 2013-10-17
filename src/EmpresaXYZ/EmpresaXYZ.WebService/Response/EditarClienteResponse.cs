using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace EmpresaXYZ.WebService.Response
{
    [DataContract()]
    public class EditarClienteResponse
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string Message { get; set; }
        
        public EditarClienteResponse(string status, string message) 
        {
            Status = status;
            Message = message;
        }

        public static EditarClienteResponse Error(string message)
        {
            return new EditarClienteResponse(ResponseBaseStatus.ERROR, message);
        }

        public static EditarClienteResponse Success()
        {
            return new EditarClienteResponse(ResponseBaseStatus.SUCCESS, string.Empty);
        }
    }
}