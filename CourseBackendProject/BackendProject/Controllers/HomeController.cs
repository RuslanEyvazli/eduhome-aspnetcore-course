using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Sliders = _db.Sliders.ToList(),
                Courses = _db.Courses.OrderByDescending(c => c.Id).Take(3).ToList(),
                Blogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3).ToList(),
                Events = _db.Events.OrderByDescending(e => e.Id).Take(4).ToList(),
                Information = _db.Informations.FirstOrDefault(),
                Notices = _db.Notices.OrderByDescending(n => n.Id).Take(6).ToList(),
                Student = _db.Students.FirstOrDefault(),
                Bio = _db.Bios.FirstOrDefault()
            };
            return View(homeVM);
        }
    }
}