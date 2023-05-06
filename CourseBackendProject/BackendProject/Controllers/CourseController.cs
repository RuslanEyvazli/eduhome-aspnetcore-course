using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _db;
        public CourseController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Course> courses = _db.Courses.ToList();
            return View(courses);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.Include(c => c.CourseContent).Include(c => c.CourseFeature).FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();
            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                Courses = _db.Courses.OrderByDescending(c=>c.Id).Take(6).ToList()
            };
            //Course course = await _db.Courses.Include(c => c.CourseContent).Include(c => c.CourseFeature).FirstOrDefaultAsync(c=>c.Id==id);
            return View(courseVM);
        }
        public IActionResult Search(string search)
        {
            var model = _db.Courses.Where(c => c.CourseName.Contains(search)).OrderByDescending(c => c.Id).Take(10).ToList();
            return PartialView("_SearchCoursePartial", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Detail")]
        public async Task<IActionResult> CreateReply(CourseVM _message)
        {
            //if (blog.Replyy == null) return NotFound();
            Reply reply1 = new Reply
            {
                Name = _message.Name,
                Email = _message.Email,
                Message = _message.Message,
                Subject = _message.Subject
            };
            await _db.Replies.AddAsync(reply1);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}