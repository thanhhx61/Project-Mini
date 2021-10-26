using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studentmana.Entities
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        [MaxLength(250)]
        public string GradeName { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
