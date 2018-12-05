using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Препораты для рецепта
    /// </summary>
    public class RecieptDrags
    {
        [ForeignKey(nameof(Drag))]
        public Guid DragGuid { get; set; }

        [ForeignKey(nameof(Recipe))]

        public Guid RecipeGuid { get; set; }

        public virtual Drag Drag { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
