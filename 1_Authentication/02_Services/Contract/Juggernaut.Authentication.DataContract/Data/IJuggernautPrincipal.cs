using System;
using System.Collections.Generic;

namespace Juggernaut.Authentication.DataContract.Data
{
    public interface IJuggernautPrincipal
    {
        IList<string> Rights { get; }
        IList<string> Roles { get; }
        string SignableData { get; }
        byte[] Signature { get; set; }

        bool HasRight(string right);
        bool HasRights(IList<string> rights);
        bool HasRole(string role);
        bool HasRoles(IList<string> roles);
    }
}
