using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Emr.Database.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public Role()
        {
            
        }
    }
}
