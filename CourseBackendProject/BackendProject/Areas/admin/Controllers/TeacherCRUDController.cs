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
    [Area("admin")]
    public class TeacherCRUDController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public TeacherCRUDController(AppDbContext db, IHostingEnvironment env)
        {
            _db=db;
            _env = env;
        }
        public IActionResult Index()
        {
            
            return View(_db.Teachers.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherCRUDVM teacherVM)
        {
            if (teacherVM.Photo == null)
            {
                ModelState.AddModelError("Photo", "Shekil sech");
                return View();
            }
            if (!teacherVM.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil formatinda file sech");
                return View();
            }
            if (teacherVM.Photo.MaxLength(1400))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1400 kb ola biler");
                return View();
            }
            Skill skill = new Skill()
            {
                Communication = teacherVM.Communication,
                Language=teacherVM.Language,
                TeamLeader=teacherVM.TeamLeader,
                Design=teacherVM.Design,
                Development=teacherVM.Development,
                Innovation=teacherVM.Innovation
            };
            Teacher teacher = new Teacher()
            {
                Facebook=teacherVM.Facebook,
                Pinterest=teacherVM.Pinterest,
                Twitter=teacherVM.Twitter,
                Vimeo=teacherVM.Vimeo,
                About=teacherVM.About,
                Degree=teacherVM.Degree,
                Experience=teacherVM.Experience,
                Hobbies=teacherVM.Hobbies,
                Faculity=teacherVM.Faculity,
                Email=teacherVM.Email,
                PhoneNumber=teacherVM.PhoneNumber,
                SkypeAddress=teacherVM.SkypeAddress,
                FullName=teacherVM.FullName,
                Profession=teacherVM.Profession
            };
            teacher.Skill = skill;
            teacher.Image = await teacherVM.Photo.SaveImage(_env.WebRootPath, "img/teacher");
            await _db.Teachers.AddAsync(teacher);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _db.Teachers.Find(id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _db.Teachers.FindAsync(id);
            if (teacher == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/teacher", teacher.Image);
            _db.Skills.Remove(_db.Skills.FirstOrDefault(s => s.Id == teacher.SkillId));
            _db.Teachers.Remove(teacher);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _db.Teachers.Include(t => t.Skill).FirstOrDefaultAsync(t => t.Id == id);
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Teacher teacher)
        {
            if (id == null) return NotFound();
            Teacher dbTeacher = _db.Teachers.Include(t => t.Skill).FirstOrDefault(t => t.Id == id);
            if (dbTeacher == null) return NotFound();
            if (teacher.Photo != null)
            {
                if (!teacher.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Shekil sechin");
                    return View();
                }
                if (teacher.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("Photo", "Shekilin olchusu maksimum 1400 kb ola biler");
                    return View();
                }
                Helper.DeleteImg(_env.WebRootPath, "img/teacher", dbTeacher.Image);
                dbTeacher.Image = await teacher.Photo.SaveImage(_env.WebRootPath, "img/teacher");
                dbTeacher.FullName = teacher.FullName;
                dbTeacher.Profession = teacher.Profession;
                dbTeacher.About = teacher.About;
                dbTeacher.Degree = teacher.Degree;
                dbTeacher.Hobbies = teacher.Hobbies;
                dbTeacher.Faculity = teacher.Faculity;
                dbTeacher.Email = teacher.Email;
                dbTeacher.PhoneNumber = teacher.PhoneNumber;
                dbTeacher.SkypeAddress = teacher.SkypeAddress;
                dbTeacher.Skill.Language = teacher.Skill.Language;
                dbTeacher.Skill.TeamLeader = teacher.Skill.TeamLeader;
                dbTeacher.Skill.Development = teacher.Skill.Development;
                dbTeacher.Skill.Design = teacher.Skill.Design;
                dbTeacher.Skill.Innovation = teacher.Skill.Innovation;
                dbTeacher.Skill.Communication = teacher.Skill.Communication;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                dbTeacher.FullName = teacher.FullName;
                dbTeacher.Profession = teacher.Profession;
                dbTeacher.About = teacher.About;
                dbTeacher.Degree = teacher.Degree;
                dbTeacher.Hobbies = teacher.Hobbies;
                dbTeacher.Faculity = teacher.Faculity;
                dbTeacher.Email = teacher.Email;
                dbTeacher.PhoneNumber = teacher.PhoneNumber;
                dbTeacher.SkypeAddress = teacher.SkypeAddress;
                dbTeacher.Skill.Language = teacher.Skill.Language;
                dbTeacher.Skill.TeamLeader = teacher.Skill.TeamLeader;
                dbTeacher.Skill.Development = teacher.Skill.Development;
                dbTeacher.Skill.Design = teacher.Skill.Design;
                dbTeacher.Skill.Innovation = teacher.Skill.Innovation;
                dbTeacher.Skill.Communication = teacher.Skill.Communication;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
        
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = _db.Teachers.Include(t => t.Skill).FirstOrDefault(t => t.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }
    }
}