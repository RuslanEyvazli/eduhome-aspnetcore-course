using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class EventSpiker
    {
        public int Id { get; set; }
        public int SpeakerId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public Speaker Speaker { get; set; }
    }
}
