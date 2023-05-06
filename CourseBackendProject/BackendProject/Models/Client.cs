using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Client
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        [Required(ErrorMessage ="Emailinizi daxil edin"),EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required,MinLength(20)]
        public string Message { get; set; }

    }
}
