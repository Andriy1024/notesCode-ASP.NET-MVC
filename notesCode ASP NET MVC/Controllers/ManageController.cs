using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using notesCode_ASP_NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace notesCode_ASP_NET_MVC.Controllers
{
    public class ManageController : Controller
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

        [Authorize]
        public ActionResult UserProfile(string Layout)
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            if (Layout == "ajax")
            {
                ViewBag.Layout = null;
            }

            ApplicationUser user = UserManager.FindByName(User.Identity.Name);
            if (user != null)
                return View(user);
            return HttpNotFound();
        }
        [HttpPost]
        public async Task<string> UpdateRating(int answers)
        {
            if (User.Identity.IsAuthenticated)
            {
                ApplicationUser user = await UserManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    user.RightAnswers_of_CpluplusTest = answers;
                    await UserManager.UpdateAsync(user);
                }
            }
            return "ok";
        }

    }
}