using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica5.Models;
using Practica5.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Practica5.Services;
using Microsoft.AspNetCore.Routing;

namespace Practica5.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            animalesContext context = new animalesContext();
            var animales = context.Clase.OrderBy(x => x.Nombre);
            Random r = new Random();
            return View(animales);
        }
        [Route("/Especie")]
        public IActionResult Informacion()
        {

            animalesContext context = new animalesContext();

            var especies = context.Clase.Include(x => x.Especies).OrderBy(x=>x.Nombre).
                Select(x => new InformacionViewModel { Nombre=x.Nombre, Especies=x.Especies });

            return View(especies);
        }
    }
}
