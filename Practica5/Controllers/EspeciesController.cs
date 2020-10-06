using Microsoft.AspNetCore.Mvc;
using Practica5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica5.Controllers
{
    public class EspeciesController:Controller
    {
        [Route("/Especies/{Id}")]
        public IActionResult Index(string id)
        {
            animalesContext context = new animalesContext();
            var nombre = id.Replace("-", " ").ToLower();
            var especies = context.Especies.Where(x => x.IdClaseNavigation.Nombre.ToLower() == id.ToLower()).
                OrderBy(x => x.Especie);
            if (especies==null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(especies);
            }
        }
    }
}
