using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Helpers;
using BackendProject.Models;
using BackendProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);
            AppUser newUser = new AppUser()
            {
                Fullname=register.Fullname,
                Email=register.Email,
                UserName=register.UserName, 
            };
            IdentityResult identityResult =await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);

            }
            await _userManager.AddToRoleAsync(newUser, Helper.UserRoles.Members.ToString());
            await _signInManager.SignInAsync(newUser,true);
            return RedirectToAction("Index","Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);
            AppUser loginUser = await _userManager.FindByEmailAsync(login.Email);
            if (loginUser == null)
            {
                ModelState.AddModelError("", "Email or password is not valid");
                return View(login);
            }
            if (!loginUser.IsDeleted)
            {
                Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(loginUser, login.Password, false, true);
                if (!signInResult.Succeeded)
                {
                    ModelState.AddModelError("", "Email or password is not valid");
                    return View(login);
                }
                string role = (await _userManager.GetRolesAsync(loginUser))[0];
                if (role == Helper.UserRoles.Admin.ToString())
                {
                    return RedirectToAction("Index", "AdminRole", new { area = "admin" });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Your account is blocked");
                return View(login);
            }
        }
        
        public async Task CreateRole()
        {
            if (!await _roleManager.RoleExistsAsync(Helper.UserRoles.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.UserRoles.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Helper.UserRoles.Members.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.UserRoles.Members.ToString()));
            }
        }
    }
}