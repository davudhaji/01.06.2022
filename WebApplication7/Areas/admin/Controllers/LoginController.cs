using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication7.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.ViewModels;
using WebApplication7.Models;

namespace WebApplication7.Areas.admin.Controllers
{
    [Area("admin")]
    public class LoginController : Controller
    {
        
        private readonly Data.AppContext _context;
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;


        public LoginController(Data.AppContext context, UserManager<CustomUser> userManager, SignInManager<CustomUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(VmUser model)
        {
            if (ModelState.IsValid && !_context.customUsers.Any(u => u.UserName == model.UserName))
            {
                CustomUser customUser = new CustomUser()
                {
                    FullName = model.FullName,
                    UserName = model.UserName,
                    Email = model.Email,
                };
                var result = await _userManager.CreateAsync(customUser, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(customUser, false);
                    return RedirectToAction("index", "home");
                }
                else
                {
                    foreach(var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                    return View(model);
                }

               



            }
            ModelState.AddModelError("", "This username is exsist");
            return View(model);
        }


        public IActionResult Login()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login (VmUser model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                else
                {
                    ModelState.AddModelError("", "Email or password is not valid");
                    return View(model);
                }
            }
            return View(model);
        }



        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("login");
        }

    }
}
