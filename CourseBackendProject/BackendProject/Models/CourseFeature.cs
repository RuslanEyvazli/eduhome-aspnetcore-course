using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class CourseFeature
    {
        public int Id { get; set; }
        [Required]
        public string Sarts { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public int StudentCount { get; set; }
        [Required]
        public string Assement { get; set; }
        [Required]
        public decimal CourseFee { get; set; }
        public virtual Course Course { get; set; }


    }
}
