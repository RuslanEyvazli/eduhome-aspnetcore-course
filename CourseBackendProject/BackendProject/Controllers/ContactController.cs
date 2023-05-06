using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public async Task<IActionResult> CreateReply(ContactVM _message)
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