<<<<<<< HEAD:ImobiliariaCore/ImobiliariaCore/Controllers/HomeController.cs
﻿using System;
using System.Collections.Generic;
=======
﻿using Imobi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 8dbd9cd81360e0af75c24d638aec5d22b6b1661b:Imobi/Imobi/Controllers/HomeController.cs
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImobiliariaCore.Models;
using Microsoft.AspNetCore.Authorization;

namespace ImobiliariaCore.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
