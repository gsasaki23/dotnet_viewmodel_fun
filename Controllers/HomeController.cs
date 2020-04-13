using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewmodel_fun.Models;

namespace viewmodel_fun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string message = "Lorem ipsum abra kadabra alakazam";
            return View("Index",message);
        }
        
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] nums = new int[]{1,2,3,10,43,5};
            return View(nums);
        }
        
        [HttpGet("users")]
        public IActionResult Users()
        {
            User[] users = new User[]{
                new User(){FirstName = "Moose",LastName = "Phillips"},
                new User(){FirstName = "Sarah",LastName = ""},
                new User(){FirstName = "Jerry",LastName = ""},
                new User(){FirstName = "Rene",LastName = "Ricky"},
                new User(){FirstName = "Barbarah",LastName = ""}
            };
            return View("Users",users);
        }
        
        [HttpGet("user")]
        public IActionResult User()
        {
            User testUser = new User(){FirstName = "Moose",LastName = "Phillips"};
            return View("User",testUser);
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
