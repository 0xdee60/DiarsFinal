using DiarsFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public DiarsContext cnx { get; set; }
        public HomeController(ILogger<HomeController> logger, DiarsContext cnx)
        {
            _logger = logger;
            this.cnx = cnx;
        }

        public IActionResult Index()
        {

            ViewBag.Etiquetas = cnx.Etiquetas.ToList();
            ViewBag.Notas = cnx.Notas.ToList();
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
