using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Juggernaut.Authentication.Repositories;
using Juggernaut.Authentication.EntityModel;

namespace Juggernaut.Authentication.QueryManager
{
    public class JuggernautUserQM : IJuggernautUserQM
    {
        private readonly IJuggernautUserRepository _repository;

        public JuggernautUserQM(IJuggernautUserRepository repository)
        {
            _repository = repository;
        }

        public JuggernautUser GetJuggernautUser(string userName)
        {
            return _repository.Get(u => u.UserName == userName).FirstOrDefault();
        }
    }
}
