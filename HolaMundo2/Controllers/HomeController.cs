using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HolaMundo2.Models;

namespace HolaMundo2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Sitio principal del sistema.";
            return View();
        }

        [Route("/Home/Calendar/{anio=2018}/{mes=8}")]
        public IActionResult Calendar(int anio, int mes)
        {
            ViewData["anio"] = anio;
            ViewData["mes"] = mes;
            return View();
        }

        [Route("/Home/Day/{anio=2018}/{mes=8}/{dia=25}")]
        public IActionResult Day(int anio, int mes, int dia)
        {
            ViewData["anio"] = anio;
            ViewData["mes"] = mes;
            ViewData["dia"] = dia;
            return View();
        }

        [Route("/Home/EventDetail/{id=1}")]
        public IActionResult EventDetail(int idEvent)
        {
            ViewData["idEvent"] = idEvent;
            return View();
        }
        [Route("/Home/EventList/")]
        public IActionResult EventList()
        {
            ViewData["Message"] = "Esta es la lista de los eventos cargados.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
