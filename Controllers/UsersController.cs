using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

using Comission.Models;

namespace Comission.Controllers
{
    public class UsersController : Controller
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
        public UsersController(ComissionContext context, ILogger<HomeController> logger)
        {
            db = context;
            _logger = logger;
        }
        [HttpGet("/user/dashboard")]
        public IActionResult UserDashboard()
        {
            return View("Dashboard");
        }

        [HttpGet("/user/bids")]
        public IActionResult UsersBids()
        {
            return View("UserBids");
        }
        [HttpGet("/user/newbid")]
        public IActionResult NewBid()
        {
            return View("NewBid");
        }

        [HttpPost("user/createbid")]
        public IActionResult CreateBid (Bid newBid)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewBid");
            }

            return RedirectToAction("UsersBids");
        }

        [HttpGet("message/{UserId}")]
        public IActionResult NewChat()
        {
            return View("NewChat");
        }

        [HttpGet("inbox/{UserId}")]
        public IActionResult Inbox()
        {
            return View("Inbox");
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
