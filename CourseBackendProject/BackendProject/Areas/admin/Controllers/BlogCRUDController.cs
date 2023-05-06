using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.Extentions;
using BackendProject.Helpers;
using BackendProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogCRUDController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public BlogCRUDController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Blog> blog = _db.Blogs.ToList();
            return View(blog);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = _db.Blogs.Find(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (blog == null) return NotFound();
            if (blog.Photo == null)
            {
                ModelState.AddModelError("Photo", "Shekil sechin");
                return View();
            }
            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil formatinda file sechin");
                return View();
            }
            if (blog.Photo.MaxLength(1400))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu maksimum 1400KB ola biler");
                return View();
            }
            Blog blog1 = blog;
            blog1.Image = await blog.Photo.SaveImage(_env.WebRootPath, "img/blog");
            await _db.Blogs.AddAsync(blog1);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog blog =await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/blog", blog.Image);
            _db.Blogs.Remove(blog);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Blog blog = await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Blog blog)
        {
            if (id == null) return View();
            Blog dbBlog = _db.Blogs.Find(id);
            if (dbBlog == null) return NotFound();
            if (blog.Photo != null)
            {
                if (!blog.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Shekil formati sechin");
                    return View();
                }
                if (blog.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("Photo", "Shekilin olchusu maksimum 1400KB ola biler");
                    return View();
                }
                Helper.DeleteImg(_env.WebRootPath, "img/blog", dbBlog.Image);
                dbBlog.Image = await blog.Photo.SaveImage(_env.WebRootPath, "img/blog");
                dbBlog.AuthorName = blog.AuthorName;
                dbBlog.BlogBody = blog.BlogBody;
                dbBlog.Explain = blog.Explain;
                dbBlog.Date = blog.Date;
                dbBlog.PreTitle = blog.PreTitle;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            dbBlog.AuthorName = blog.AuthorName;
            dbBlog.BlogBody = blog.BlogBody;
            dbBlog.Date = blog.Date;
            dbBlog.Explain = blog.Explain;
            dbBlog.PreTitle = blog.PreTitle;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
       
    }
}