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
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Event> event1 = _db.Events.ToList();

            return View(event1);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Event eventt = await _db.Events.FindAsync(id);
            if (eventt == null) return NotFound();
            EventVM eventVM = new EventVM()
            {
                Eventt = eventt,
                Courses = _db.Courses.OrderByDescending(c => c.Id).Take(6).ToList(),
                Blogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3).ToList(),
                EventSpikers = _db.EventSpikers.Include(e => e.Speaker).Where(e=>e.EventId== eventt.Id).ToList()
            };
            return View(eventVM);
        }
        public IActionResult Search(string search)
        {
            var model = _db.Events.Where(e => e.EventName.ToLower().Contains(search.ToLower())).OrderByDescending(e => e.Id).Take(10).ToList();
            return PartialView("_SearchEventPartial",model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Detail")]
        public async Task<IActionResult> CreateReply(EventVM _message)
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