using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRecaptcha.Models;
using CaptchaMvc.HtmlHelpers; //Import library for captcha

namespace TestRecaptcha.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ShowLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginUser model)
        {
            //Check captcha first
            if (!this.IsCaptchaValid("Captcha is not valid"))
            {
                ViewBag.errorCaptcha = "Captcha is not valid";
                return View("ShowLogin");
            }
            List<LoginUser> ls = new List<LoginUser>();
            ls.Add(model);
            return View(ls);

        }
    }
}