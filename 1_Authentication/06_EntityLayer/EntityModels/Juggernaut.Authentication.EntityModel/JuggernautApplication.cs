using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Juggernaut.Authentication.EntityModel
{
    public class JuggernautApplication
    {
        public JuggernautApplication()
        {
            this.Users = new List<JuggernautUserApplication>();
            this.Roles = new List<JuggernautRole>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage="Application Name must not be longer than 40 characters")]
        public string ApplicationName { get; set; }
        [Required]
        public DateTime ActiveFrom { get; set; }
        public Nullable<DateTime> ActiveUntil { get; set; }

        public virtual ICollection<JuggernautUserApplication> Users { get; set; }
        public virtual ICollection<JuggernautRole> Roles { get; set; }
    }
}
