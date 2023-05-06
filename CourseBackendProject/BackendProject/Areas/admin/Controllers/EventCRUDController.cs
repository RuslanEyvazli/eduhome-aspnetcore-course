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
    public class EventCRUDController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public EventCRUDController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            EventCRUDVM eventCRUDVM = new EventCRUDVM()
            {
                Events = _db.Events.ToList()
            };
            return View(eventCRUDVM);
        }
        public IActionResult Create()
        {
            EventCRUDVM cRUDVM = new EventCRUDVM
            {
                Speakers = _db.Speakers.ToList()
            };
            return View(cRUDVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BackendProject.Areas.admin.ViewModels.EventCRUDVM eventCRUDVM)
        {
            EventCRUDVM cRUDVM = new EventCRUDVM
            {
                Speakers = _db.Speakers.ToList()
            };
            if (eventCRUDVM.Photo == null)
            {
                ModelState.AddModelError("Photo", "Shekil sechiin");
                return View(cRUDVM);
            }
            if (!eventCRUDVM.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekil formatinda bir file sechin");
                return View(cRUDVM);
            }

            if (eventCRUDVM.Photo.MaxLength(1400))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusi maksimum 1400KB olmalidir");
                return View(cRUDVM);
            }

            Event newEventt = new Event
            {
                Date = eventCRUDVM.Date,
                EventDurationTime = eventCRUDVM.EventDurationTime,
                EventName = eventCRUDVM.EventName,
                Explain = eventCRUDVM.Explain,
                Venue = eventCRUDVM.Venue
            };

            newEventt.Image = await eventCRUDVM.Photo.SaveImage(_env.WebRootPath, "img/event");
            List<EventSpiker> Eventspikers = new List<EventSpiker>();
            string test = Request.Form["states[]"];
            if (test == null)
            {
                ModelState.AddModelError("", "abcakhbskxkajsx");
                return View();
            }
            string[] arr = test.Split(",");
            if (arr.Length == 0)
            {
                ModelState.AddModelError("", "Minimum bir nefer sechin");
                return View(cRUDVM);
            }
            List<int> ids = new List<int>(); 
            foreach (string item in arr)
            {

                ids.Add(Int32.Parse(item));
            }

            foreach (int id in ids)
            {
                Eventspikers.Add(new EventSpiker { EventId = newEventt.Id,SpeakerId=id });
            }
            
            newEventt.EventSpikers = Eventspikers;
            await _db.Events.AddAsync(newEventt);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

            }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Event eventt = _db.Events.Find(id);
            if (eventt == null) return NotFound();
            return View(eventt);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Event eventt = _db.Events.Find(id);
            if (eventt == null) return NotFound();
            Helper.DeleteImg(_env.WebRootPath, "img/event", eventt.Image);
             _db.Events.Remove(eventt);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Event eventt = await _db.Events.Include(e => e.EventSpikers).FirstOrDefaultAsync(e => e.Id == id);
            EventCRUDVM eventCRUDVM = new EventCRUDVM
            {
                Eventt = eventt,
                EventSpikers = _db.EventSpikers.Where(e => e.EventId == eventt.Id).ToList(),
                Speakers=_db.Speakers.ToList()
            };
            if (eventCRUDVM == null) return NotFound();
            return View(eventCRUDVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,EventCRUDVM eventVM)
        {
            Event eventt = await _db.Events.Include(e => e.EventSpikers).FirstOrDefaultAsync(e => e.Id == id);
            EventCRUDVM eventCRUDVM = new EventCRUDVM
            {
                Eventt = eventt,
                EventSpikers = _db.EventSpikers.Where(e => e.EventId == eventt.Id).ToList(),
                Speakers = _db.Speakers.ToList()
            };
            if (eventt == null) return NotFound();
            if (eventCRUDVM == null) return NotFound();
            if (id == null) return NotFound();
            if (eventVM.Photo != null)
            {
                if (!eventVM.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Shekil formatinda sech");
                    return View(eventCRUDVM);
                }
                if (eventVM.Photo.MaxLength(1400))
                {
                    ModelState.AddModelError("Photo", "Shekilin olchusu maksimum 1400KB olmalidir");
                    return View(eventCRUDVM);
                }
               
                List<EventSpiker> newEventSpeaker = new List<EventSpiker>();
                string test = Request.Form["states[]"];
                if (test != null)
                {
                    string[] arr = test.Split(",");
                    List<int> ids = new List<int>();
                    foreach (string item in arr)
                    {
                        ids.Add(Int32.Parse(item));
                    }
                    foreach (int item in ids)
                    {
                        newEventSpeaker.Add(new EventSpiker { EventId = eventt.Id, SpeakerId = item });
                    }

                }
                Helper.DeleteImg(_env.WebRootPath, "img/event", eventt.Image);
                eventt.Image = await eventVM.Photo.SaveImage(_env.WebRootPath, "img/event");
                eventt.Date = eventVM.Eventt.Date;
                eventt.EventName = eventVM.Eventt.EventName;
                eventt.Explain = eventVM.Eventt.Explain;
                eventt.Venue = eventVM.Eventt.Venue;
                eventt.EventDurationTime = eventVM.Eventt.EventDurationTime;
                eventt.EventSpikers = newEventSpeaker;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
                
            }

            List<EventSpiker> newEventSpeakers = new List<EventSpiker>();
            string tests = Request.Form["states[]"];
            if (tests != null)
            {
                string[] arr = tests.Split(",");
                List<int> ids = new List<int>();
                foreach (string item in arr)
                {
                    ids.Add(Int32.Parse(item));
                }
                foreach (int item in ids)
                {
                    newEventSpeakers.Add(new EventSpiker { EventId = eventt.Id, SpeakerId = item });
                }

            }
            eventt.Date = eventVM.Eventt.Date;
            eventt.EventName = eventVM.Eventt.EventName;
            eventt.Explain = eventVM.Eventt.Explain;
            eventt.Venue = eventVM.Eventt.Venue;
            eventt.EventDurationTime = eventVM.Eventt.EventDurationTime;
            eventt.EventSpikers = newEventSpeakers;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
 }