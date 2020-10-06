using Practica5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica5.Services
{
    public class EspeciesService
    {
        public List<Clase> Especies { get; set; }

        public EspeciesService()
        {
            using (animalesContext context = new animalesContext())
                Especies = context.Clase.OrderBy(x => x.Nombre).ToList();
        }
    }
}
