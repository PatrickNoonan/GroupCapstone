﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace BeerQuest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private UserManager<ApplicationUser> _userManager;
        //private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //why is user null????????
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var currentUser = this.User.Identity.Name;
            //var user = _context.Users.Where(u => u.Id == currentUserId).FirstOrDefault();
            var user = _context.Users.Where(u => u.Id == currentUserId).FirstOrDefault();
            if(user == null)
            {
                return View();
            }
            if (user.RoleString == "Business")
            {
                return RedirectToAction("Index", "Businesses");
            }
            if (user.RoleString == "Member")
            {
                return RedirectToAction("Index", "Members");
            }
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

        public async Task<IActionResult> AccountRedirect()
        {
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Where(u => u.Id == currentUserId).FirstOrDefault();
            if (user.RoleString == "Business")
            {
                return RedirectToAction("Create", "Businesses");
            }
            else
            {
                return RedirectToAction("Create", "Members");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Domain.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
