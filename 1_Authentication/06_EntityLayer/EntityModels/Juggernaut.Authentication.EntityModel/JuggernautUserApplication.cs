using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Juggernaut.Authentication.EntityModel
{
    public class JuggernautUserApplication
    {
        public JuggernautUserApplication()
        {
            this.UserRoles = new List<JuggernautUserApplicatonRole>();
        }

        [Key]
        public int ID { get; set; }

        //[Required]
        //public int JuggernautUserID { get; set; }

        //[Required]
        //public int JuggernautApplicationID { get; set; }

        public virtual JuggernautUser User { get; set; }
        public virtual JuggernautApplication Application { get; set; }

        public virtual ICollection<JuggernautUserApplicatonRole> UserRoles { get; set; }
    }
}
