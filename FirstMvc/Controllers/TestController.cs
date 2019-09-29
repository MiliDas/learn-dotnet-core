using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstMvc.Models;

namespace FirstMvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit()
        {
             return View(new Submit
            {
                Name = "Name",
                Gender = "Female",
                Age = 21,
                
            }
                );
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}