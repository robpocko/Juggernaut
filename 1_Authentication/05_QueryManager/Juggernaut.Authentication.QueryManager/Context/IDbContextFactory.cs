using System.Data.Entity;

namespace Juggernaut.Authentication.QueryManager.Context
{
    public interface IDbContextFactory
    {
        DbContext Get();
    }
}
