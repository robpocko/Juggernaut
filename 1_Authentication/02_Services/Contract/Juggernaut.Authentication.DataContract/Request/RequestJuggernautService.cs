using System.Runtime.Serialization;
using Juggernaut.Authentication.DataContract.Data;

namespace Juggernaut.Authentication.DataContract
{
    [DataContract]
    public abstract class RequestJuggernautService
    {
        [DataMember]
        public JuggernautPrincipal Principal { get; set; }

        [DataMember(IsRequired = true)]
        public RequestHeader RequestHeader { get; set; }

        public string InternalReference { get; set; }
        public int TransactionId { get; set; }
    }
}
