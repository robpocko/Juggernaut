using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Juggernaut.Authentication.EntityModel
{
    public class JuggernautRole
    {
        public JuggernautRole()
        {
            Applications = new List<JuggernautApplication>();
        }

        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage="Role must not be longer than 30 characters")]
        public string Role { get; set; }

        public virtual ICollection<JuggernautApplication> Applications { get; set; }
    }
}
