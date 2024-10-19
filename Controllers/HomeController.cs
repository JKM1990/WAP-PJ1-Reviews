using System;
using Microsoft.AspNetCore.Mvc;
using projectOne.Models;

namespace projectOne.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {
            Reviews reviews = new Reviews();
            reviews.setMeUp();
            return View(reviews);
        }

        [HttpPost]
        public IActionResult ReviewSubmit(Reviews review)
        {
            review.AddReview();
            return RedirectToAction("Index");
        }

    }
}
