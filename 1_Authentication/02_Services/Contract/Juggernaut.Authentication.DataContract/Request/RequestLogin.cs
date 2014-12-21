using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Juggernaut.Authentication.DataContract.Data;
using Juggernaut.Authentication.Common;

namespace Juggernaut.Authentication.DataContract
{
    [ServiceKnownTypeAttribute(typeof(WindowsCredentials))]
    [ServiceKnownTypeAttribute(typeof(UserCredentials))]
    [ServiceKnownTypeAttribute(typeof(SubscriberCredentials))]
    [ServiceKnownTypeAttribute(typeof(Credentials))]
    [DataContract(Namespace = Constants.ServiceNamespace, Name = "RequestLogin")]
    public class RequestLogin : RequestJuggernautService
    {
        [DataMember(Name = "Credentials", IsRequired = true)]
        public Credentials Credentials { get; set; }
    }
}
