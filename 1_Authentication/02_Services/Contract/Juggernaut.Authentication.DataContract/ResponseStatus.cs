using System;
using System.Runtime.Serialization;

namespace Juggernaut.Authentication.DataContract
{
    [DataContract]
    public enum ResponseStatus
    {
        [EnumMember]
        Unknown = 0,
        [EnumMember]
        Success = 1,
        [EnumMember]
        Error = 2,
        [EnumMember]
        Warning = 3
    }
}
