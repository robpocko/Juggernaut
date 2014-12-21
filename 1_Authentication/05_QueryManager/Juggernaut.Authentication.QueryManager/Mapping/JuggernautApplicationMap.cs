using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Juggernaut.Authentication.EntityModel;

namespace Juggernaut.Authentication.QueryManager.Mapping
{
    public class JuggernautApplicationMap : EntityTypeConfiguration<JuggernautApplication>
    {
        public JuggernautApplicationMap()
        {
            //  Primary key
            this.HasKey(j => j.ID);

            //  Properties
            this.Property(j => j.ApplicationName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(j => j.ActiveFrom)
                .IsRequired();

            this.Property(j => j.ActiveUntil);

            //  Table & Column Mappings
            this.ToTable("JuggernautUser");
            this.Property(j => j.ID).HasColumnName("JuggernautUserId");
            this.Property(j => j.ApplicationName).HasColumnName("ApplicationName");
            //this.Property(j => j.ActiveFrom).HasColumnName("ActiveFrom");
            //this.Property(j => j.ActiveUntil).HasColumnName("ActiveUntil");

            //  Relationships
            this.HasRequired(j => j.Users).WithRequiredPrincipal();
        }
    }
}
