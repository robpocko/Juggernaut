using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Juggernaut.Authentication.DataContract
{
    [DataContract]
    public class ResponseHeader
    {
        public ResponseHeader() { }

        [DataMember]
        public List<Message> Errors { get; set; }

        [DataMember]
        public ResponseStatus Status { get; set; }

        [DataMember]
        public List<Message> Warnings { get; set; }
    }
}
