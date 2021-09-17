using System;
using asp_net_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core.Controllers
{
    public class SchoolController : Controller
    {

        public IActionResult Index()
        {
            var school = new School();
            school.SchoolId = Guid.NewGuid().ToString();
            school.FoundationYear = 2005;
            school.Name = "Khasiri School";

            ViewBag.CosaDinamica = "La monja";

            return View(school);
        }
    }
}