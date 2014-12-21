using System.Runtime.Serialization;

namespace Juggernaut.Authentication.DataContract
{
    [DataContract]
    [KnownType(typeof(ResponseJuggernautService))]
    public abstract class ResponseJuggernautService
    {
        protected ResponseJuggernautService() { }

        [DataMember(IsRequired = true)]
        public ResponseHeader ResponseHeader { get; set; }
    }
}
