using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Venezia.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("Connexion", Name = "LoginUrl")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
