using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Controllers
{
    
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            List<Teacher> teachers = _db.Teachers.ToList();
            return View(teachers);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Teacher Teacher = await _db.Teachers.Include(t=>t.Skill).FirstOrDefaultAsync(t=>t.Id==id);
            if (Teacher == null) return NotFound();
            return View(Teacher);
        }
        public IActionResult Search(string search)
        {
            var model = _db.Teachers.Where(t => t.FullName.Contains(search)).OrderByDescending(t => t.Id).Take(5).ToList();
            return PartialView("_SearchPartial", model);
        }
    }
}