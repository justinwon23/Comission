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
        public IActionResult Dashboard()
        {
            return View("Dashboard");
        }

        [HttpGet("message/{ReceiverId}")]
        public IActionResult NewChat(int ReceiverId)
        {
            ViewBag.ReceiverId = ReceiverId;
            return View("NewChat");
        }

        [HttpGet("inbox/{UserId}")]
        public IActionResult Inbox(int UserId)
        {
            return View("Inbox");
        }

        [HttpPost("createmessage")]
        public IActionResult CreateMessage(Message newMessage)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.ReceiverId = newMessage.ReceiverId;
                return View("NewChat");
            }

            db.Messages.Add(newMessage);
            db.SaveChanges();

            return RedirectToAction("Inbox");
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
