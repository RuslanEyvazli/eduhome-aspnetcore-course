using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.DAL;
using BackendProject.Extentions;
using BackendProject.Helpers;
using BackendProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Areas.admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {


            return View(_db.Sliders.OrderByDescending(s=>s.Id).Take(5).ToList());
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            //if (slider.Slider.Photo == null)
            //{
            //    ModelState.AddModelError("Photo", "Qaqi şəkil seç ginən");
            //    return View();
            //}
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();  
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkil formatı seç ginən qaqi");
                return View();
            }
            if (slider.Photo.MaxLength(1400))
            {
                ModelState.AddModelError("Photo", $"Şəkilin ölçüsü max 300kb ola bilər");
                return View();
            }
            int count = _db.Sliders.Count();
            if (count > 5)
            {
                ModelState.AddModelError("", "Slider da maksimum 5 şəkil ola bilər");
                return View();
            }

            slider.Image = await slider.Photo.SaveImage(_env.WebRootPath,"img/slider");
            
            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/slider", slider.Image);
            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Slider slider)
        {
            if (id == null) return NotFound();
            if (slider.Photo != null)
            {
                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Şəkil formatı seç ginən qaqi");
                    return View();
                }
                if (slider.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("Photo", $"Şəkilin ölçüsü max 300kb ola bilər");
                    return View();
                }

                Slider dbSlider = await _db.Sliders.FindAsync(id);
                Helper.DeleteImg(_env.WebRootPath, "img/slider", dbSlider.Image);
                dbSlider.Image = await slider.Photo.SaveImage(_env.WebRootPath, "img/slider");

                await _db.SaveChangesAsync();
            }
           
            
            return RedirectToAction("Index");
           
        }
    }
}