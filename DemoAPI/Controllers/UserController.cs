using Microsoft.AspNetCore.Mvc;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Controllers
{
    public class UserController : Controller
    {
        SocialNetworkContext Context;
        public UserController(SocialNetworkContext context)
        {
            Context = context;
        }
        [HttpGet]
        public IActionResult All()
        {
            ViewData["users"] = Context.Users.ToArray();
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(User user)
        {
            Context.Entry(user).State = EntityState.Modified;
            Context.SaveChanges();

            return View();
        }
    }
}
