using System;
using System.Runtime.Serialization;


namespace Juggernaut.Authentication.DataContract
{
    [DataContract]
    public class RequestHeader
    {
        public RequestHeader() { }

        [DataMember(IsRequired = false)]
        public string CallerApplication { get; set; }

        [DataMember(IsRequired = false)]
        public string CallerRefNo { get; set; }
    }
}
