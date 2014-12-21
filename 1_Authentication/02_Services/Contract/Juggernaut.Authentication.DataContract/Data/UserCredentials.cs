using System.Threading.Tasks;

namespace Juggernaut.Authentication.DataContract.Data
{
    public sealed class UserCredentials : Credentials
    {
        public UserCredentials() { }

        public string Password { get; set; }
        public string Username { get; set; }

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

        public override sealed void Validate() { }
    }
}
