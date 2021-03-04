using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp5EMVC.Helpers;
using WebApp5EMVC.Models.Entity;
using WebApp5EMVC.Models.View;
namespace WebApp5EMVC.Controllers
{
    public class AreaRisrvataController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
           return View();
        }
    }
}
