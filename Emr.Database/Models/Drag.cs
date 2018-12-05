using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Препарат
    /// </summary>
    public class Drag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid DragGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string NameDrug { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<RecieptDrags> RecieptDragses { get; set; }

        public Drag()
        {
            DragGuid = Guid.NewGuid();
        }
    }
}
