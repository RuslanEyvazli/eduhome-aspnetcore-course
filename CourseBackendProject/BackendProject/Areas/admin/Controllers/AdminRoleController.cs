using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Areas.admin.ViewModels;
using BackendProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "Admin")]
    public class AdminRoleController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AdminRoleController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = _userManager.Users.ToList();
            List<UserVM> userVM = new List<UserVM>();
            foreach (AppUser user in users)
            {
                UserVM userVM1 = new UserVM
                {
                    Username = user.UserName,
                    Email = user.Email,
                    Fullname = user.Fullname,
                    Role = (await _userManager.GetRolesAsync(user))[0],
                    IsDeletedet = user.IsDeleted
                };
                userVM.Add(userVM1);
            }
            return View(userVM);
        }
        public async Task<IActionResult> DeleteUser(string email)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            user.IsDeleted = true;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }
        public IActionResult MakeAdmin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MakeAdmin(string email, string rolename)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            string oldRole = (await _userManager.GetRolesAsync(user))[0];
            if (oldRole != rolename)
            {
                await _userManager.RemoveFromRoleAsync(user, oldRole);
                await _userManager.AddToRoleAsync(user, rolename);
            }

            return RedirectToAction("Index");
        }
    }
}