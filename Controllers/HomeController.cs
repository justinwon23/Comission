﻿using System;
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
    public class HomeController : Controller
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
        public HomeController(ComissionContext context, ILogger<HomeController> logger)
        {
            db = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("create")]
        public IActionResult Create(User newUser)
        {
            
            if (ModelState.IsValid)
            {
                bool isEmailTaken = db.Users.Any(u => u.Email == newUser.Email);
                if (isEmailTaken)
                {
                    ModelState.AddModelError("Email", "is taken");
                }
                bool isUsernameTaken = db.Users.Any(u => u.Username == newUser.Username);
                if (isUsernameTaken)
                {
                    ModelState.AddModelError("Username", "is taken");
                }
            }

            if (ModelState.IsValid == false)
            {
                return View("Index");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            // User dbUser = db.Users.FirstOrDefault(u => u.Email == newUser.Email);
            // HttpContext.Session.SetInt32("UserId", dbUser.UserId);

            return RedirectToAction("Index");
        }

        [HttpPost("login")]

        public IActionResult Logging(LoginUser loginuser)
        {
            if (ModelState.IsValid == false)
            {
                return View("Index");
            }

            User dbUser = db.Users.FirstOrDefault(u => u.Email == loginuser.LoginEmail);

            if (dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", "not found.");
                return View("Index");
            }

            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginuser, dbUser.Password, loginuser.LoginPassword);

            if (pwCompareResult == 0)
            {
                ModelState.AddModelError("LoginPassword", "invalid");
            }

            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            HttpContext.Session.SetString("UName", dbUser.Username);
            
            if (dbUser.isArtist == true)
            {
                return RedirectToAction("Dashboard", "Artists");
            }
            else 
            {
                return RedirectToAction("UserDashboard", "Users");
            }  
        }

        [HttpPost("logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
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
