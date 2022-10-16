using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OnThiGK.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string NameStudent { get; set; }
        [Required]

        public int Age {get ; set;}
        public bool Sex { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]

        [ForeignKey("Class")]
        public int ClassId {get;set;}
        public Class Class { get; set; }
    }
}