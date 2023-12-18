using Microsoft.AspNetCore.Mvc;
using Passwort2.Models;
using System.Diagnostics;

namespace Passwort2.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Passwort());
        }
        [HttpPost]
        public IActionResult Index(Passwort wort)
        {
            string passwort = wort.PasswortGenerator();
            ViewBag.Message = passwort;

            List<string> passwörter = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                passwörter.Add(wort.PasswortGenerator());
            }
            ViewData["Passwörter"] = passwörter;

            return View(wort);
        }
        
    }
}
