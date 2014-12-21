using System.Runtime.Serialization;
using Juggernaut.Authentication.Common;

namespace Juggernaut.Authentication.DataContract
{
    [DataContract(Namespace = Constants.ServiceNamespace, Name = "RequestLogout")]
    public class RequestLogout : RequestJuggernautService
    {
    }
}
