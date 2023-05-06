using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Image { get; set; }
        public string Profession { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public ICollection<EventSpiker> EventSpikers { get; set; }
    }
}
