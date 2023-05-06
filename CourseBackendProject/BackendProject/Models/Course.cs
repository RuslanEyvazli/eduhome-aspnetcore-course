using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,StringLength(50)]
        public string  CourseName { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int CourseFeatureId { get; set; }
        public virtual CourseFeature CourseFeature { get; set; }
        public int CourseContentId { get; set; }
        public virtual CourseContent CourseContent { get; set; }

    }
}
