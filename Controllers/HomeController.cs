using Sarim_CC_Lab12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sarim_CC_Lab12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult ResponseOfUser(UserReply userReply)
        {
            if (userReply.SelectedImage == null)
            {
                TempData["message"] = "Please select an image to proceed!";
            }
            else if (userReply.SelectedImage == "image1")
            {
                TempData["message"] = "The person has a very calm nature and loves peaceful environment";
            }
            else if (userReply.SelectedImage == "image2")
            {
                TempData["message"] = "The person is comfortable in noisy environment and has a very limited environment.\r\n\r\n";
            }
            else if (userReply.SelectedImage == "image3")
            {
                TempData["message"] = "The person has an evil and cruel mindset";
            }
            return RedirectToAction("Index");
        }
    }
}