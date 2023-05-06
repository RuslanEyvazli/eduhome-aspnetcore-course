using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Areas.admin.Controllers
{
    [Area("admin")]
    public class BioCRUDController : Controller
    {
        private readonly AppDbContext _db;
        public BioCRUDController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Bios.FirstOrDefault());
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Bio dbBio = await _db.Bios.FindAsync(id);
            if (dbBio == null) return NotFound();
            return View(dbBio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Bio bio)
        {
            if (id == null) return NotFound();
            Bio dbBio = await _db.Bios.FindAsync(id);
            if (dbBio == null) return NotFound();
            dbBio.Address = bio.Address;
            dbBio.Facebook = bio.Facebook;
            dbBio.PhoneNumber = bio.PhoneNumber;
            dbBio.Pinterest = bio.Pinterest;
            dbBio.Site = bio.Site;
            dbBio.SliderDescription = bio.SliderDescription;
            dbBio.SliderTitle = bio.SliderTitle;
            dbBio.Twitter = bio.Twitter;
            dbBio.Vimeo = bio.Vimeo;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}