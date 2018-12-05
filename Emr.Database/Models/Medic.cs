using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Emr.Database.Models
{
    /// <summary>
    /// Врач
    /// </summary>
    public class Medic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid MedicGuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(100)]
        public string Patronymic { get; set; }

        [Required]
        [MaxLength(100)]
        public int Snils { get; set; }

        //Дата рождения
        [Required]
        [MaxLength(100)]
        public DateTime Dob { get; set; }

        //Место рождения
        [Required]
        [MaxLength(100)]
        public string Pob { get; set; }

        [Required]
        [MaxLength(100)]
        public string Age { get; set; }

        [Required]
        [MaxLength(100)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(100)]
        public string Passport { get; set; }
    }
}
