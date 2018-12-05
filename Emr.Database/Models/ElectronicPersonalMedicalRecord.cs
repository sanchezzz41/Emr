using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emr.Database.Models
{
    /// <summary>
    /// Электронная персональная медицинская запись
    /// </summary>
    public class ElectronicPersonalMedicalRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid EpmrGuid { get; set; }

        [ForeignKey(nameof(Patient))]
        public Guid PatientGuid { get; set; }

        [ForeignKey(nameof(Medic))]
        public Guid MedicGuid { get; set; }

        //Дата открытия
        [Required]
        public DateTime Date { get; set; }

        //Дата подписания
        [Required]
        public DateTime Signing { get; set; }

        [Required]
        [MaxLength(100)]
        public string TextEpmr { get; set; }

        //Тут файл должен быть, а не string. Поменяй млез на что-то нормальное
        [Required]
        [MaxLength(100)]
        public string FileEpmr { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Medic Medic { get; set; }
    }
}
