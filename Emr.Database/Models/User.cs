using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid UserGuid { get; set; }

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Login { get; set; }

        [Required]
        [MaxLength(200)]
        public string Password{get; set; }

        public DateTime BirthDay { get; set; }

        public virtual Role Role { get; set; }
    }
}
