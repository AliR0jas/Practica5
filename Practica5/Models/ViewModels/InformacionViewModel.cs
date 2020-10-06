using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica5.Models.ViewModels
{
    public class InformacionViewModel
    {
        public string Nombre { get; set; }
        public ICollection<Models.Especies> Especies { get; set; }
    }
}
