using System;
using System.Security.Principal;

namespace Juggernaut.Authentication.DataContract.Data
{
    [Serializable]
    public class JuggernautIdentity : IIdentity
    {
        public JuggernautIdentity() { }

        public string AuthenticationType { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Name { get; set; }
        public string SubscriberKey { get; set; }
        public int UserID { get; set; }
        public string UserKey { get; set; }
    }
}
