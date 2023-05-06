using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Facebook { get; set; }
        [Required]
        public string Pinterest { get; set; }
        [Required]
        public string Vimeo { get; set; }
        [Required]
        public string Twitter { get; set; }
        [Required, StringLength(70)]
        public string FullName { get; set; }
        [Required, StringLength(70)]
        public string Profession { get; set; }
        [Required, MinLength(15), MaxLength(400)]
        public string About { get; set; }
        [Required, StringLength(60)]
        public string Degree { get; set; }
        [Required, StringLength(50)]
        public string Experience { get; set; }
        [Required, StringLength(70)]
        public string Email { get; set; }
        public string SkypeAddress { get; set; }
        [Required, StringLength(50)]
        public string Hobbies { get; set; }
        [Required, StringLength(100)]
        public string Faculity { get; set; }
        [Required, StringLength(50)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Image { get; set; }
        public int SkillId { get; set; }
        [NotMapped]
        public IFormFile  Photo { get; set; }
        public Skill Skill { get; set; }
    }
}
