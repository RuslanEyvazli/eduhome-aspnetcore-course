using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public List<Blog> Blogs { get; set; }
        public Information Information { get; set; }
        public List<Notice> Notices { get; set; }
        public Student Student { get; set; }
        public Bio Bio { get; set; }


    }
}
