using System.Runtime.Serialization;
using Juggernaut.Authentication.DataContract.Data;
using Juggernaut.Authentication.Common;

namespace Juggernaut.Authentication.DataContract
{
    [DataContract(Namespace = Constants.ServiceNamespace, Name = "ResponseLogout")]
    public class ResponseLogout : ResponseJuggernautService
    {
        [DataMember(Name = "Principal", IsRequired = true)]
        public JuggernautPrincipal Principal { get; set; }
    }
}
