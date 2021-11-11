using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AM4_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AM4_MVC.ViewComponents
{
    public class AboutViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var About = new List<About>()
            {
                new About(1,"امیرمهدی","مشهد","امیرمهدی امینی علاقه مند به برنامه نویسی",
                    "امیدوارم بتونم همکاری خوبی با شما داشته باشم","1   ","1.jpg")
            };
            return View("_About",About);
        }
    }
}
