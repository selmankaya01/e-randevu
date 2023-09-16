using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Randevu_Yonetim_Sistemi.Data.Entity;
using Randevu_Yonetim_Sistemi.Models;

namespace Randevu_Yonetim_Sistemi.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInUser;
        private RoleManager<AppRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInUser, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInUser = signInUser;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AppUser user = new AppUser()
            {
                UserName = model.UserName,
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                Color = model.Color,
                IsDentist= model.IsDentist
            };

            IdentityResult result = _userManager.CreateAsync(user, model.Password).Result;

            if (result.Succeeded)
            {
                bool roleCheck = model.IsDentist ? AddRole("Dentist") : AddRole("Secretary");
                if (!roleCheck)
                {
                    return View("Error");
                }
                _userManager.AddToRoleAsync(user, model.IsDentist ? "Dentist" : "Secretary").Wait();
                return RedirectToAction("Index", "Home");
            }

            return View("Error");
        }

        private bool AddRole(string roleName)
        {
            if (!_roleManager.RoleExistsAsync(roleName).Result)
            {
                AppRole role = new AppRole()
                {
                    Name = roleName,
                };

                IdentityResult result = _roleManager.CreateAsync(role).Result;
                return result.Succeeded;
            }
            return true;
        }
    }
}
