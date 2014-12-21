using Juggernaut.Authentication.EntityModel;

namespace Juggernaut.Authentication.Repositories
{
    public interface IJuggernautUserQM
    {
        JuggernautUser GetJuggernautUser(string userName);
    }
}
