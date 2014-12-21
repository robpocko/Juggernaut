using System.Data.Entity;

namespace Juggernaut.Authentication.QueryManager.Context
{
    public class JuggernautContextFactory : IDbContextFactory
    {
        private JuggernautContext _juggernautContext;

        private void InitializeContext()
        {
            _juggernautContext = new JuggernautContext();
        }

        public DbContext Get()
        {
            if (_juggernautContext == null) InitializeContext();

            return _juggernautContext;
        }
    }
}
