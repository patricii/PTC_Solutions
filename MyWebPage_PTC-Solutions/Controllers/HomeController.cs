using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebPage_PTC_Solutions.Models;

namespace MyWebPage_PTC_Solutions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A ADP Solution é uma empresa voltada para a área de Desenvolvimento e implementação de Softwares e Sistemas para gerenciamento e automatização de sua empresa.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Endereço / Contatos:";

            return View();
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
