using System;
using Juggernaut.Authentication.QueryManager.Context;
using Juggernaut.Authentication.Repositories;

namespace Juggernaut.Authentication.QueryManager
{
    public class JuggernautUnitOfWork : IUnitOfWork
    {
        private readonly IDbContextFactory _contextFactory;
        private JuggernautContext _context;

        public JuggernautUnitOfWork(IDbContextFactory contextFactory)
        {
            if (contextFactory == null)
            {
                throw new ArgumentNullException("contextFactory");
            }

            _contextFactory = contextFactory;
        }

        protected JuggernautContext Context
        {
            get { return _context ?? (_context = (JuggernautContext)_contextFactory.Get()); }
        }

        public void SaveChanges()
        {
            Context.Commit();
        }
    }
}
