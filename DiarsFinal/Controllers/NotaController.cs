using DiarsFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Controllers
{
    public class NotaController : Controller
    {

        public DiarsContext cnx { get; set; }

        public NotaController(DiarsContext cnx)
        {
            this.cnx = cnx;
        }

        public IActionResult Index()
        {
            ViewBag.Notas = cnx.Notas.ToList();

            return View();
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(string titulo, string contenido)
        {
            Nota nota = new Nota();
            nota.titulo = titulo;
            nota.contenido = contenido;
            nota.fechaMod = DateTime.Now;
     
            cnx.Notas.Add(nota);
            cnx.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]

        public IActionResult Edit(int id)
        {
            ViewBag.NotaComoTal = cnx.Notas.Where(o => o.idNota == id).FirstOrDefault();
            return View();
        }

        [HttpPost]

        public IActionResult Edit(string titulo, string contenido, int idNo)
        {
            Nota nota = cnx.Notas.Where(o => o.idNota == idNo).FirstOrDefault();
            nota.titulo = titulo;
            nota.contenido = contenido;
            nota.fechaMod = DateTime.Now;

            cnx.SaveChanges();

            return RedirectToAction("Index","Home");
        }

        public IActionResult Borrar(int id)
        {
            var nota = cnx.Notas.Where(o => o.idNota == id).FirstOrDefault();

            cnx.Remove(nota);
            cnx.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

    }
}
