using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Juggernaut.Authentication.DataContract
{
    [Serializable]
    [DataContract]
    [KnownType(typeof(JuggernautAuthenticationServiceFault))]
    public class JuggernautAuthenticationServiceFault
    {
        [DataMember]
        public List<Message> Messages { get; set; }
    }

    [Serializable]
    [DataContract]
    [KnownType(typeof(JuggernautAuthenticationServiceSecurityFault))]
    public class JuggernautAuthenticationServiceSecurityFault
    {
        [DataMember]
        public List<Message> Messages { get; set; }
    }
}
