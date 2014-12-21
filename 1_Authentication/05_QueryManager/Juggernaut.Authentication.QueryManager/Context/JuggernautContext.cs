using System.Data.Entity;
using Juggernaut.Authentication.EntityModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using Juggernaut.Authentication.QueryManager.Mapping;

namespace Juggernaut.Authentication.QueryManager.Context
{
    public class JuggernautContext : DbContext
    {
        static JuggernautContext()
        {
            Database.SetInitializer<JuggernautContext>(null);
        }

        public JuggernautContext()
            : base("Name=JuggernautContext")
        { }

        public IDbSet<JuggernautUser> JuggernautUsers { get; set; }
        public IDbSet<JuggernautApplication> JuggernautApplications { get; set; }
        public IDbSet<JuggernautRole> JuggernautRoles { get; set; }
        public IDbSet<JuggernautUserApplication> JuggernautUserApplications { get; set; }
        public IDbSet<JuggernautUserApplicatonRole> JuggernautUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            //modelBuilder.Configurations.Add(new JuggernautUserMap());
            //modelBuilder.Configurations.Add(new JuggernautApplicationMap());
        }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}
