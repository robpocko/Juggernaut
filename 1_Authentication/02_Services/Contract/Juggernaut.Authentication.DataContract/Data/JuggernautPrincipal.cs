using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Principal;
using Juggernaut.Authentication.Common;

namespace Juggernaut.Authentication.DataContract.Data
{
    [Serializable]
    [DataContract(Name="JuggernautPrincipal", Namespace=Constants.ServiceNamespace)]
    [KnownType(typeof(JuggernautIdentity))]
    public class JuggernautPrincipal : IJuggernautPrincipal, IPrincipal
    {
        public JuggernautPrincipal(Authority authority)
        {
            
        }

        [DataMember(Name = "Identity", IsRequired = true, Order = 1)]
        public IIdentity Identity { get; set; }
        public IList<string> Rights { get { throw new NotFiniteNumberException("nie 3"); } }
        public IList<string> Roles { get { throw new NotFiniteNumberException("nie 4"); } }
        public string SignableData { get { throw new NotFiniteNumberException("nie 5"); } }
        public byte[] Signature { get; set; }

        public bool HasRight(string right) { return false; }
        public bool HasRights(IList<string> rights) { return false; }
        public bool HasRole(string role) { return false; }
        public bool HasRoles(IList<string> roles) { return false; }
        public bool IsInRole(string role) { return false; }
    }
}
