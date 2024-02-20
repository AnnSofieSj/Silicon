﻿using Microsoft.AspNetCore.Mvc;
using Silicon_AspNetMVC.Models.Sections;

namespace Silicon_AspNetMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Profile";
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Title"] = "Details";
            return View();
        }

        public IActionResult Security()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveDetails(AccountViewModel model)
        {
            return RedirectToAction("Details", "Account");
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Details", "Account");
        }
    }
}
