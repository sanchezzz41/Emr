using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Метрики пациента
    /// </summary>
    public class Metric
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid MetricGuid { get; set; }

        [ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }

        [ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public int WaistCircumference { get; set; }

        [Required]
        [MaxLength(100)]
        public int BodyTemperature { get; set; }

        [Required]
        [MaxLength(100)]
        public int RespiratoryRate { get; set; }

        [Required]
        [MaxLength(100)]
        public int Growth { get; set; }

        [Required]
        [MaxLength(100)]
        public int Mass { get; set; }

        [Required]
        [MaxLength(100)]
        public int SystolicPressure { get; set; }

        [Required]
        [MaxLength(100)]
        public int DiastolicPressure { get; set; }

        [Required]
        [MaxLength(100)]
        public int Pulse { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Medic Medic { get; set; }
    }
}
