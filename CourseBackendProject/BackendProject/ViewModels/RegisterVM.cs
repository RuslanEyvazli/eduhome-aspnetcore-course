using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Fullname { get; set; }
        [Required,StringLength(30)]
        public string UserName { get; set; }
        [Required,EmailAddress,DataType(DataType.EmailAddress)]
        public string  Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,Compare(nameof(Password)), DataType(DataType.Password)]
        public string CheckPassword { get; set; }

    }
}
