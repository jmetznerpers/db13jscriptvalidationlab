using jsdemo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace jsdemo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.myname = DALcs.GetEmployeeName();
            return View();
        }

        public IActionResult GetForm()
        {
            return View();
        }
        public IActionResult UseForm(string nametext, string cattext, string pass, string cpass)
        {
            return Content($"Name Field:{nametext}\nCategory Field: {cattext}\nPassword Field: {pass}\nConfirm Password Field: {cpass}");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
