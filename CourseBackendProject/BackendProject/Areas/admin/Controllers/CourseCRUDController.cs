using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.admin.ViewModels;
using BackendProject.DAL;
using BackendProject.Extentions;
using BackendProject.Helpers;
using BackendProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.Areas.admin.Controllers
{
    [Area("Admin")]
    public class CourseCRUDController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public CourseCRUDController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            CourseCRUDVM cRUDVM = new CourseCRUDVM()
            {
                Courses = _db.Courses.ToList()
            };
            return View(cRUDVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Course course =await _db.Courses.Include(c=>c.CourseContent).Include(c=>c.CourseFeature).FirstOrDefaultAsync(c=>c.Id==id);
            return View(course);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BackendProject.Areas.admin.ViewModels.CourseCRUDVM courseVM)
        {
            //if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            //{
            //    return View();
            //}
            if (courseVM.Coursee.Photo == null)
            {
                ModelState.AddModelError("Photo", "Qaqi şəkil seç ginən");
                return View();
            }
            if (!courseVM.Coursee.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Şəkil formatı seç ginən qaqi");
                return View();
            }
            if (courseVM.Coursee.Photo.MaxLength(1400))
            {
                ModelState.AddModelError("Photo", $"Şəkilin ölçüsü max 1400kb ola bilər");
                return View();
            }
            Course course = courseVM.Coursee;
            course.CourseContent = courseVM.CourseContentt;
            course.CourseFeature = courseVM.CourseFeaturee;
            course.Image = await courseVM.Coursee.Photo.SaveImage(_env.WebRootPath, "img/course");
            await _db.Courses.AddAsync(course);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FindAsync(id);
            if (course == null) return NotFound();
            
            
            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FindAsync(id);
            if (course == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/course", course.Image);
            _db.CourseContents.Remove(_db.CourseContents.FirstOrDefault(c=>c.Id==course.CourseContentId));
            _db.CourseFeatures.Remove(_db.CourseFeatures.FirstOrDefault(c => c.Id == course.CourseFeatureId));
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.Include(c => c.CourseContent).Include(c => c.CourseFeature).FirstOrDefaultAsync(c => c.Id == id);
            if (course == null) return NotFound();
            //CourseContent content = _db.CourseContents.FirstOrDefault(c => c.Id == course.CourseContentId);
            //CourseFeature feature = _db.CourseFeatures.FirstOrDefault(c => c.Id == course.CourseFeatureId);
            //CourseCRUDVM crudVM = new CourseCRUDVM()
            //{
            //    Coursee = course,
            //    CourseContentt = content,
            //    CourseFeaturee = feature
            //};
           
            return View(course);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Course course)
        {
            Course dbCourse = _db.Courses.Include(c => c.CourseContent).Include(c => c.CourseFeature).FirstOrDefault(c => c.Id == id);
            if (id == null) return NotFound();
            if (course.Photo != null)
            {
                if (!course.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Shekil sechin");
                    return View();

                }
                if (course.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("Photo", "Shekilin olchusu maksimum 1400kb ola biler");
                    return View();
                }
                
                Helper.DeleteImg(_env.WebRootPath, "img/course", dbCourse.Image);
                dbCourse.Image = await course.Photo.SaveImage(_env.WebRootPath, "img/course");
                dbCourse.CourseFeature.Assement = course.CourseFeature.Assement;
                dbCourse.CourseFeature.ClassDuration = course.CourseFeature.ClassDuration;
                dbCourse.CourseFeature.CourseFee = course.CourseFeature.CourseFee;
                dbCourse.CourseFeature.Duration = course.CourseFeature.Duration;
                dbCourse.CourseFeature.Language = course.CourseFeature.Language;
                dbCourse.CourseFeature.Sarts = course.CourseFeature.Sarts;
                dbCourse.CourseFeature.SkillLevel = course.CourseFeature.SkillLevel;
                dbCourse.CourseFeature.StudentCount = course.CourseFeature.StudentCount;
                dbCourse.CourseContent.About = course.CourseContent.About;
                dbCourse.CourseContent.Certification = course.CourseContent.Certification;
                dbCourse.CourseContent.HowToApply = course.CourseContent.HowToApply;

                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else{
                dbCourse.CourseFeature.Assement = course.CourseFeature.Assement;
                dbCourse.CourseFeature.ClassDuration = course.CourseFeature.ClassDuration;
                dbCourse.CourseFeature.CourseFee = course.CourseFeature.CourseFee;
                dbCourse.CourseFeature.Duration = course.CourseFeature.Duration;
                dbCourse.CourseFeature.Language = course.CourseFeature.Language;
                dbCourse.CourseFeature.Sarts = course.CourseFeature.Sarts;
                dbCourse.CourseFeature.SkillLevel = course.CourseFeature.SkillLevel;
                dbCourse.CourseFeature.StudentCount = course.CourseFeature.StudentCount;
                dbCourse.CourseContent.About = course.CourseContent.About;
                dbCourse.CourseContent.Certification = course.CourseContent.Certification;
                dbCourse.CourseContent.HowToApply = course.CourseContent.HowToApply;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

           


            
            }
    }
}