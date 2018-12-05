using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Медицинский осмотр
    /// </summary>
    public class MedicalExamination
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid MeGuid { get; set; }

        [ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }

        [ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }

        [ForeignKey(nameof(Diagnos))]
        public Guid DiagnosGuid { get; set; }

        [ForeignKey(nameof(Recipe))]
        public Guid RecipeGuid { get; set; }

        //Дата осмотра
        [Required]
        public DateTime InspectionDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Symptom { get; set; }

        [Required]
        [MaxLength(100)]
        public string Comment { get; set; }

        [Required]
        [MaxLength(100)]
        public string InspectionResult { get; set; }



        public virtual Patient Patient { get; set; }

        public virtual Medic  Medic { get; set; }

        public virtual Diagnos Diagnos { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
