using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core.Controllers
{
    public class SchoolController : Controller
    {

        public IActionResult Index()
        {
            var school = new Escuela();
            school.UniqueId = Guid.NewGuid().ToString();
            school.AñoDeCreacion = 2005;
            school.Nombre = "Khasiri School";

            ViewBag.CosaDinamica = "La monja";

            return View(school);
        }
    }
}