using BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class AboutVM
    {
        public Information Information { get; set; }
        public List<Teacher> Teachers { get; set; }
        public Student Student { get; set; }
        public List<Notice> Notices { get; set; }
        public Video Video { get; set; }

    }
}
