using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ProjName.Models;
using Comission.Models;

namespace BeltExam.Controllers
{
    public class UserController : Controller
    {
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
                
            }
        }
        private string FName
        {
            get
            {
                return HttpContext.Session.GetString("FName");

            }
        }
        private string UName
        {
            get
            {
                return HttpContext.Session.GetString("UName");

            }
        }
        private readonly ILogger<HomeController> _logger;

        private ComissionContext db;
        public UserController(ComissionContext context, ILogger<HomeController> logger)
        {
            db = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
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
