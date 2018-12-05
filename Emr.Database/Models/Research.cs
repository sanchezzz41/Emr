using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Исследование
    /// </summary>
    public class Research
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ResearchGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameResearch { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
