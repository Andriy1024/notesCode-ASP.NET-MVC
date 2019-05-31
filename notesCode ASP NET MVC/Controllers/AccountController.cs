using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using notesCode_ASP_NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace notesCode_ASP_NET_MVC.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public ActionResult Register(string Layout)
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            if (Layout == "ajax")
            {
                ViewBag.Layout = null;
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.UserName, Email = model.Email,Age = model.Age, Name = model.Name, Secondname = model.Secondname, RightAnswers_of_CpluplusTest = 0 };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // если создание прошло успешно, то добавляем роль пользователя
                    await UserManager.AddToRoleAsync(user.Id, "user");
                    //await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            string jsondata;
            if (ModelState.IsValid)
            {

                ApplicationUser user = await UserManager.FindAsync(model.UserName, model.Password);
                if (user == null)
                {
                    jsondata = "Неправильний логін або пароль";
                    ModelState.AddModelError("", "Неправильний логін або пароль");
                }
                else
                {
                    ClaimsIdentity claim = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationManager.SignOut();// Чистим попередні кукі
                    AuthenticationManager.SignIn(new AuthenticationProperties{ IsPersistent = true }, claim);
                    //return RedirectToAction("Index", "Home");
                    jsondata = "ok";
                }
            }
            else
            {
                jsondata = "Помилка валідації";
            }
            return Json(jsondata);
            //return View(model);
        }
       
        public ActionResult Logout(string returnUrl)
        {
            AuthenticationManager.SignOut();
            string str = "ok";
            if (string.IsNullOrEmpty(returnUrl))
            {
                return Json(str, JsonRequestBehavior.AllowGet);
            }
            return RedirectToAction(returnUrl,"Home");
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(ResetPasswordModel model)
        {
            string jsondata = "";
            if (ModelState.IsValid)
            {
                ApplicationUser user = await UserManager.FindAsync(model.UserName, model.Password);
                if(user == null)
                {
                    jsondata = "Неправильний пароль";
                }
                else
                {
                   var result =  await UserManager.ChangePasswordAsync(user.Id,model.Password, model.NewPassword);
                   if (result.Succeeded) { jsondata = "Пароль успішно змінено";  }
                   else { jsondata = "Неможливо змінити на цей пароль"; }
                }
            }
            else
            {
                jsondata = "Помилка валідації";
            }
            return Json(jsondata);
        }


    }
}