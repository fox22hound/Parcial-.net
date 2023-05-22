using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
    }
}
