using System;

namespace Juggernaut.Authentication.DataContract.Data
{
    public enum AuthenticationResult
    {
        Unknown = 0,
        AccountDeleted = 1,
        AccountLocked = 2,
        InvalidIPAddress = 3,
        InvalidContract = 4,
        ContractExpired = 5,
        Authenticated = 6,
        InvalidCredentials = 7,
        SystemError = 8,
        Authenticated_PasswordExpiry = 9,
        PasswordExpired = 10,
        MustChangePassword = 11
    }
}
