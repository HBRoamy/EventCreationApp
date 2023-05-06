using Book_reading_app.Core.Domain.Entities;
using Book_reading_app.Core.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_reading_app.Core.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        RoleManager<IdentityRole> _roleManager;
        

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> _roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this._roleManager = _roleManager;
        }

        

        // GET: AccountsController


        public ActionResult Index()
        {
            return View();
        }

        
        // GET: AccountsController/Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // POST: AccountsController/Register
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel newUserDetails)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { FullName = newUserDetails.FullName, UserName = newUserDetails.EmailAddress.ToLower(),
                    Email = newUserDetails.EmailAddress.ToLower() };

                var result = await _userManager.CreateAsync(user, newUserDetails.Password);//password added here so that its hashing happens
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "BookEvent");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(newUserDetails); // it will re render the view if unsuccessfull
        }

   

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "BookEvent");
        }

       

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false); //model.email is matching it to username (PasswordsigninAsync requires username and not email so I copied username to email and added a new Full Name property)
                if(result.Succeeded)
                {
                    if(!string.IsNullOrEmpty(returnUrl))
                    {
                        
                        return LocalRedirect(returnUrl);
                    }
                    else { 
                    return RedirectToAction("Index", "BookEvent");
                    }
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(model);
        }
    }
}
