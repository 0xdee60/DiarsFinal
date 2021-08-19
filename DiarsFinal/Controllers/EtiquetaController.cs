using DiarsFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Controllers
{
    public class EtiquetaController : Controller
    {

        public DiarsContext cnx { get; set; }

        public EtiquetaController(DiarsContext cnx)
        {
            this.cnx = cnx;
        }


        public IActionResult Index()
        {
            ViewBag.Etiquetas = cnx.Etiquetas.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(string nombre, string descripcion)
        {
            Etiqueta etiqueta = new Etiqueta();
            etiqueta.nombre = nombre;
            etiqueta.descripcion = descripcion;

            cnx.Add(etiqueta);

            cnx.SaveChanges();

            return RedirectToAction("Index","Etiqueta");
        }

    }
}
