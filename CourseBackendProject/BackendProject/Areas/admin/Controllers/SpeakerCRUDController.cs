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
    public class SpeakerCRUDController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SpeakerCRUDController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Speaker> speaker = _db.Speakers.ToList();
            return View(speaker);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Speaker speaker)
        {
            if (speaker == null) return NotFound();
            if (speaker.Photo == null)
            {
                ModelState.AddModelError("Photo", "Shekil sechin");
                return View();
            }
            if (!speaker.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil formatini sechin");
                return View();
            }
            if (speaker.Photo.MaxLength(1400))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu maksimum 1400Kb ola biler");
                return View();
            }
            Speaker newSpeaker = new Speaker
            {
                Fullname = speaker.Fullname,
                Profession = speaker.Profession
            };
            newSpeaker.Image = await speaker.Photo.SaveImage(_env.WebRootPath, "img/event");
            await _db.Speakers.AddAsync(newSpeaker);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Speaker speaker = await _db.Speakers.FindAsync(id);
            if (speaker == null) return NotFound();
            return View(speaker);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Speaker speaker = await _db.Speakers.FindAsync(id);
            if (speaker == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/event", speaker.Image);
            _db.Speakers.Remove(speaker);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Speaker speaker = await _db.Speakers.FindAsync(id);
            if (speaker == null) return NotFound();
            return View(speaker);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Speaker speaker)
        {
            if (id == null) return NotFound();
            Speaker dbSpeaker =await _db.Speakers.FindAsync(id);
            if (dbSpeaker == null) return NotFound();
            if (speaker.Photo != null)
            {
                if (!speaker.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Shekil formetinda file sechin");
                    return View(dbSpeaker);
                }
                if (speaker.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("Photo", "Shekilin olchusu maksimum 1400KB olmalidir");
                    return View(dbSpeaker);
                }
                Helper.DeleteImg(_env.WebRootPath, "img/event", dbSpeaker.Image);
                dbSpeaker.Image = await speaker.Photo.SaveImage(_env.WebRootPath, "img/event");
                dbSpeaker.Fullname = speaker.Fullname;
                dbSpeaker.Profession = speaker.Profession;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            dbSpeaker.Fullname = speaker.Fullname;
            dbSpeaker.Profession = speaker.Profession;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}