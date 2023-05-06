using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Areas.admin.ViewModels
{
    public class TeacherCRUDVM
    {
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
        [Required, StringLength(70),EmailAddress,DataType(DataType.EmailAddress)]
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
        [Required]
        public int Language { get; set; }
        [Required]
        public int TeamLeader { get; set; }
        [Required]
        public int Development { get; set; }
        [Required]
        public int Design { get; set; }
        [Required]
        public int Innovation { get; set; }
        [Required]
        public int Communication { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
