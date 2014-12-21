using System;
using System.Collections.Generic;

namespace Juggernaut.Authentication.DataContract.Data
{
    [Serializable]
    public class Authority
    {
        public Authority() { }

        public bool Expired
        {
            get { throw new NotImplementedException("nie 2"); }
        }
        public DateTime Expiry { get; set; }
        public string[] Rights { get; set; }
        public string[] Roles { get; set; }

        public bool HasRight(string right) { return false; }
        public bool HasRights(IList<string> rights) { return false; }
        public bool HasRole(string role) { return false; }
        public bool HasRoles(IList<string> roles) { return false; }
    }
}
