using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juggernaut.Authentication.EntityModel;
using Juggernaut.Authentication.Repositories;
using Juggernaut.Authentication.QueryManager.Context;

namespace Juggernaut.Authentication.QueryManager
{
    public class JuggernautUserRepository : RepositoryBase<JuggernautUser>, IJuggernautUserRepository
    {
        public JuggernautUserRepository(IDbContextFactory contextFactory)
            : base(contextFactory)
        { }
    }
}
