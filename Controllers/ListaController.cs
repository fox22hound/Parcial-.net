using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial2.Models;

namespace Parcial2.Controllers
{
    public class ListaController : Controller
    {
        public IActionResult Lista()
        {
            var listListado = new List<Listado>();

            var List1 = new Listado
            {
                CondIva = "Resp. inscripto",
                Cuit = 273455945212,
                RazonSocial = "SA",
                Domicilio = "Franco 3359",
                Email = "Alejandro.Lamela@hotmail.com",
                CondVenta = "Cheque"
            };
            listListado.Add(List1);

            var List2 = new Listado
            {
                CondIva = "Monotributista",
                Cuit = 2834559452314,
                RazonSocial = "SA",
                Domicilio = "Cosquin 5162",
                Email = "JoseLopes@hotmail.com",
                CondVenta = "Ticket"
            };
            listListado.Add(List2);

            return View(listListado);
            
        }
    }
}


