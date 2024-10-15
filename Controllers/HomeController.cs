using System;
using Microsoft.AspNetCore.Mvc;
using projectOne.Models;

namespace projectOne.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {
            return View();
        }

    }
}
