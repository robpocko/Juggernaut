using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Juggernaut.Authentication.EntityModel
{
    public class JuggernautUserApplicatonRole
    {
        [Key]
        public int ID { get; set; }

        //[Required]
        //public int RoleID { get; set; }

        public virtual JuggernautRole Role { get; set; }
    }
}
