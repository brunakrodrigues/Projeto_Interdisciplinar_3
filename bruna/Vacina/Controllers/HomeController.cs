using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Vacina.Controllers
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vacinacao()
        {
            return View();
        }

        public IActionResult UBS()
        {
            return View();
        }

        public IActionResult SUS()
        {
            return View();
        }

        public IActionResult Remedio()
        {
            return View();
        }

        public IActionResult UPA()
        {
            return View();
        }

        public IActionResult Agenda()
        {
            return View();
        }

        public IActionResult Teste()
        {
            return Json("Teste teste");
        }
    }
}
