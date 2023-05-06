using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class CourseContent
    {
        public int Id { get; set; }
        public string About { get; set; }
        public string HowToApply { get; set; }
        public string Certification { get; set; }
        public virtual Course Course { get; set; }

    }
}
