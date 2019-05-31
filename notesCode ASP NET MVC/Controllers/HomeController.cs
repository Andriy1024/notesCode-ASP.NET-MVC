using notesCode_ASP_NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace notesCode_ASP_NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult HeaderTopPartial()
        {
            return PartialView("~/Views/Shared/_HeaderTopPartial.cshtml");
        }
        public ActionResult About(string Layout)
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            if (Layout == "ajax")
            {
                ViewBag.Layout = null;
            }
            return PartialView();
        }

        public async Task<ActionResult> Lessons(string[] name)
        {
            if (name != null)
            {
                List<Course> view = new List<Course>();
                await Task.Run(()=> {
                    for (int i = 0; i < name.Length; i++)
                    {
                        string temp = name[i];
                        Course course = db.Courses.Where(x => x.Name == temp).FirstOrDefault();
                        if (course != null)
                        {
                            view.Add(course);
                        }
                    }
                });
                return PartialView(view);
            }
            return HttpNotFound();  
        }

        //public ActionResult UpdateLesson(string path = "main.html")
        //{
        //    string content = null;
        //    if (!string.IsNullOrEmpty(path))
        //    {
        //        path = "~/Lessons/" + path;
        //        try
        //        {
        //            using (StreamReader sr = new StreamReader(Server.MapPath(path)))
        //            {
        //                content = sr.ReadToEnd();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            content = e.Message;
        //        }
        //    }
        //    return Content(content);
        //}
        public ActionResult Tests(string Layout)
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            if (Layout == "ajax")
            {
                ViewBag.Layout = null;
            }
            
            return View();
        }
        public ActionResult Articles(string Layout)
        {
            ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
            if (Layout == "ajax")
            {
                ViewBag.Layout = null;
            }

            List<Article> articles =  db.Articles.ToList();
            return View(articles);
        }
        public async Task<ActionResult> ReadFile(string path)
        {
            string content = null;
            if (!string.IsNullOrEmpty(path))
            {
                //path = "~/Articles/" + path;
                try
                {
                    using (StreamReader sr = new StreamReader(Server.MapPath(path)))
                    {
                        content = await sr.ReadToEndAsync();
                    }
                }
                catch (Exception e)
                {
                    content = e.Message;
                }
            } else { content = "notFound"; }
            return Content(content);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        
        public ActionResult TEST()
        {
            return View();
        }
    }
}