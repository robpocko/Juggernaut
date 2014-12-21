using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juggernaut.Authentication.DataContract.Data;
using Juggernaut.Authentication.Common;

namespace Juggernaut.Authentication.DataContract
{
    [DataContract(Namespace = Constants.ServiceNamespace, Name = "ResponseLogin")]
    public class ResponseLogin : ResponseJuggernautService
    {
        public ResponseLogin()
        {

        }

        [DataMember(Name = "Principal", IsRequired = false)]
        public JuggernautPrincipal Principal { get; set; }

        [DataMember(Name = "AuthResult", IsRequired = false)]
        public AuthenticationResult AuthResult { get; set; }

        [DataMember(Name = "AuthMessage", IsRequired = false)]
        public string AuthMessage { get; set; }
    }
}
