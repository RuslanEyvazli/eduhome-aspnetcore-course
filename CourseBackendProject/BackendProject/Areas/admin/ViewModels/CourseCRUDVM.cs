using BackendProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Areas.admin.ViewModels
{
    public class CourseCRUDVM
    {
        public Course Coursee { get; set; }
        public List<Course> Courses { get; set; }
        public CourseContent CourseContentt { get; set; }
        public CourseFeature CourseFeaturee { get; set; }
        public IFormFile PhotoVM { get; set; }
    }
}
