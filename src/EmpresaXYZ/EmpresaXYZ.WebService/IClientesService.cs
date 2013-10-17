using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using EmpresaXYZ.WebService.Response;
using EmpresaXYZ.WebService.Request;

namespace EmpresaXYZ.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClientes" in both code and config file together.
    [ServiceContract]

    public interface IClientesService
    {
        [OperationContract]
        [WebGet(UriTemplate = "Clientes", ResponseFormat = WebMessageFormat.Xml)]
        List<ConsultaClienteResponse> Consulta();


        [WebInvoke(Method = "POST", UriTemplate="Atualizar", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        EditarClienteResponse Atualizar(EditarClienteRequest request);

    }
}
