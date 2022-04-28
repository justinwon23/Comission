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
using Microsoft.EntityFrameworkCore;

namespace Comission.Controllers
{
    public class ArtistsController : Controller
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
        public ArtistsController(ComissionContext context, ILogger<HomeController> logger)
        {
            db = context;
            _logger = logger;
        }
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet("allPieces")]
        public IActionResult AllPieces()
        {
            
            // User tempUser = new User();
            User User = db.Users.Include(u => u.UserHasArt).ThenInclude(artConnection => artConnection.Piece).FirstOrDefault(u => u.UserId == uid);

            Dictionary<string, float> userStyleDict = User.StyleOverView(User);

            ViewBag.userStyleDict = userStyleDict;


            return View(User);
        }

        [HttpGet("testNewPiece")]
        public IActionResult TestNewPiece()
        {
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            
            return View();
        }
        [HttpPost("/testAddPiece")]
        public IActionResult TestAddPiece(Piece newPiece)
        {
            ViewBag.UserId = HttpContext.Session.GetInt32("UserId");
            db.Pieces.Add(newPiece);
            db.SaveChanges();
            UserArtConnection newConnection = new UserArtConnection();
            newConnection.UserId = (int)HttpContext.Session.GetInt32("UserId");
            newConnection.PieceId = newPiece.PieceId;
            db.UserArtConnection.Add(newConnection);
            db.SaveChanges();

            
            return RedirectToAction("AllPieces");
        }

        [HttpGet("/artist/contracts/")]

        public IActionResult ArtistsContracts()
        {

            return View("ArtistsContracts");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
