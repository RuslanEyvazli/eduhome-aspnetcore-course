using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page)
        {
            
            ViewBag.Page = page;
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Count() / 6);
            if (page == null)
            {
                List<Blog> blogs = _db.Blogs.Take(6).ToList();

                return View(blogs);
            }
            else
            {
                List<Blog> blogs = _db.Blogs.Skip(((int)page-1)*6).Take(6).ToList();
                return View(blogs);
            }
           
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            BlogVM blogVM = new BlogVM()
            {
                Blogg = blog,
                Courses = _db.Courses.OrderByDescending(c => c.Id).Take(6).ToList(),
                Blogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3).ToList()
            };
           
            return View(blogVM);
        }
        public IActionResult Search(string search)
        {
            var model = _db.Blogs.Where(b => b.Explain.Contains(search)).OrderByDescending(b => b.Id).Take(10).ToList();
            return PartialView("SearchBlogPartial", model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Detail")]
        public async Task<IActionResult> CreateReply(BlogVM _message)
        {
            //if (blog.Replyy == null) return NotFound();
            Reply reply1 = new Reply
            {
                Name=_message.Name,
                Email= _message.Email,
                Message= _message.Message,
                Subject= _message.Subject
            };
            await _db.Replies.AddAsync(reply1);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}