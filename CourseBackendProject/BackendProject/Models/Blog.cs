using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Explain { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string BlogBody { get; set; }
        [Required]
        public string Image { get; set; }
        public string PreTitle { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
