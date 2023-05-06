using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class AppUser:IdentityUser
    {
        [Required]
        public bool IsDeleted { get; set; } = false;
        [Required,StringLength(150)]
        public string Fullname { get; set; }
    }
}
