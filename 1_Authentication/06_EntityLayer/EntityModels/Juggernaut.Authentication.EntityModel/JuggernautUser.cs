using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Juggernaut.Authentication.EntityModel
{
    public class JuggernautUser
    {
        public JuggernautUser()
        {
            this.Applications = new List<JuggernautUserApplication>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Given Name must be no longer than 30 characters")]
        public string GivenName { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage="Surname must be no longer than 30 charactrers")]
        public string Surname { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage="UserName must be no longer than 15 characters")]
        public string UserName { get; set; }
        [Required]
        public string PasswordSaltedHash { get; set; }
        [Required]
        public DateTime ActiveFrom { get; set; }
        public Nullable<DateTime> ActiveUntil { get; set; }

        public virtual ICollection<JuggernautUserApplication> Applications { get; set; }
    }
}
