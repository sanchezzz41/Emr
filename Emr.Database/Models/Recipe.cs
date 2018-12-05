using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Рецепт
    /// </summary>
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid RecipeGuid { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<RecieptDrags> RecieptDragses { get; set; }

        public Recipe()
        {
            
        }
    }
}
