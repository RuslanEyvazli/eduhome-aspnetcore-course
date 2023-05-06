using BackendProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Areas.admin.ViewModels
{
    public class EventCRUDVM
    {
        public string Image { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public string EventDurationTime { get; set; }
        [Required]
        public string Venue { get; set; }
        [Required]
        public string Explain { get; set; }
        public string Date { get; set; }
        public Speaker Speaker { get; set; }
        public List<Speaker> Speakers { get; set; }
        public ICollection<EventSpiker> EventSpikers { get; set; }
        public List<Event> Events { get; set; }
        public Event Eventt { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        
    }
}
