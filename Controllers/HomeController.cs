using System;
using Microsoft.AspNetCore.Mvc;
using projectOne.Models;

namespace projectOne.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {
            Reviews reviews = new Reviews();
            reviews.getReviewData();
            return View();
        }

    }
}
