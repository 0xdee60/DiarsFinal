using DiarsFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Controllers
{
    public class EtiquetaNotaController : Controller
    {
        public DiarsContext cnx { get; set; }

        public EtiquetaNotaController(DiarsContext cnx)
        {
            this.cnx = cnx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2(int idEtiqueta)
        {
            ViewBag.Notas = cnx.EtiquetaNotas.Include(o => o.nota).Include(o => o.etiqueta).Where(o => o.idEtiqueta == idEtiqueta).ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Create(int id)
        {

            ViewBag.idNota = id;
            ViewBag.Etiquetas = cnx.Etiquetas.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(int idEtiquetaNombre, int idEtiqueta)
        {
            EtiquetaNota en = new EtiquetaNota();
            en.idNota = idEtiquetaNombre;
            en.idEtiqueta = idEtiqueta;
            cnx.EtiquetaNotas.Add(en);

            cnx.SaveChanges();

            return RedirectToAction("Index","Home");
        }




    }



}
