using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studentmana.Models
{
    public class CreateGrade
    {
        [Required(ErrorMessage = "The category name is required")]
        [MaxLength(500)]
        public string GradeName { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
    }
}
