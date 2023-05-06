using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class CourseVM
    {
        public Course Course { get; set; }
        public List<Course> Courses { get; set; }
        public string Name { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required, MinLength(30)]
        public string Message { get; set; }
    }
}
