using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public string EventDurationTime { get; set; }
        [Required]
        public string Venue { get; set; }
        [Required]
        public string Explain { get; set; }
        [NotMapped]
        public IFormFile  Photo { get; set; }
        public string  Date { get; set; }
        public ICollection<EventSpiker> EventSpikers { get; set; }

    }
}
