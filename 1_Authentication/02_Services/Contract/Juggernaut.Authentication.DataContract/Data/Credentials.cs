using System;

namespace Juggernaut.Authentication.DataContract.Data
{
    public abstract class Credentials
    {
        protected Credentials(){}

        public string ApplicationName { get; set; }
        public string IPAddress { get; set; }

        public virtual bool TryValidate(out string error, out AuthenticationResult result)
        {
            error = "";
            result = AuthenticationResult.Authenticated;

            return false;
        }

        public virtual void Validate() { }
    }
}
