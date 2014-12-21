using System;
using System.Runtime.Serialization;

namespace Juggernaut.Authentication.DataContract
{
    [DataContract]
    public class Message
    {
        public Message() { }

        [DataMember(IsRequired = false)]
        public string Description { get; set; }

        [DataMember(IsRequired = false)]
        public int MessageCode { get; set; }
    }
}
