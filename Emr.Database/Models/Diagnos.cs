using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Диагноз
    /// </summary>
    public class Diagnos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DiagnosGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameDiagnos { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
