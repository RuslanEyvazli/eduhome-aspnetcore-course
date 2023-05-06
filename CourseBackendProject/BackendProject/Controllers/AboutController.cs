using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        public AboutController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            AboutVM aboutVM = new AboutVM()
            {
                Information = _db.Informations.FirstOrDefault(),
                Teachers = _db.Teachers.OrderBy(t => t.Experience).Take(4).ToList(),
                Student = _db.Students.FirstOrDefault(),
                Notices = _db.Notices.OrderByDescending(n => n.Id).Take(6).ToList(),
                Video = _db.Videos.FirstOrDefault()
            };
            return View(aboutVM);
        }
    }
}