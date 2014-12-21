using System;

namespace Juggernaut.Authentication.DataContract.Data
{
    public sealed class WindowsCredentials : Credentials
    {
        public WindowsCredentials()
        { }

        public string SID { get; set; }

        public override sealed string ToString()
        {
            return base.ToString();
        }

        public override sealed bool TryValidate(out string error, out AuthenticationResult result)
        {
            error = "";
            result = AuthenticationResult.Authenticated;

            return false;
        }

        public override sealed void Validate()
        {

        }
    }
}
