using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studentmana.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(500)]
        public string BookName { get; set; }
        [Required]
        [MaxLength(300)]
        public DateTime Dob { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public int GradeId { get; set; }
        public Grade grade { get; set; }

    }
}
