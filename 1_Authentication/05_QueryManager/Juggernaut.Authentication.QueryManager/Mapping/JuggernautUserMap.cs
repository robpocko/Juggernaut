using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Juggernaut.Authentication.EntityModel;

namespace Juggernaut.Authentication.QueryManager.Mapping
{
    public class JuggernautUserMap : EntityTypeConfiguration<JuggernautUser>
    {
        public JuggernautUserMap()
        {
            //  Primary Key
            this.HasKey(j => j.ID);

            //  Properties
            this.Property(j => j.GivenName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(j => j.Surname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(j => j.UserName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(j => j.PasswordSaltedHash)
                .IsRequired();

            this.Property(j => j.ActiveFrom)
                .IsRequired();

            this.Property(j => j.ActiveUntil);

            //  Table & Column Mappings
            this.ToTable("JuggernautUser");
            this.Property(j => j.ID).HasColumnName("JuggernautUserId");
            this.Property(j => j.GivenName).HasColumnName("GivenName");
            this.Property(j => j.Surname).HasColumnName("Surname");
            this.Property(j => j.UserName).HasColumnName("UserName");
            this.Property(j => j.PasswordSaltedHash).HasColumnName("PasswordSaltedHash");
            this.Property(j => j.ActiveFrom).HasColumnName("ActiveFrom");
            this.Property(j => j.ActiveUntil).HasColumnName("ActiveUntil");

            //  Relationships
            this.HasRequired(j => j.Applications);

        }
    }
}
