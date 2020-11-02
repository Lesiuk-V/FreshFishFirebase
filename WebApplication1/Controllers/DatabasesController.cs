using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DatabasesController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Workers()
        {
            return View();
        }
        public IActionResult Vehicles()
        {
            return View();
        }
    }
}
