using Microsoft.AspNetCore.Mvc;
using System;
namespace Home
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime.ToString("MMMM dd, yyyy hh:mm tt");
            return View();
        }
    }
}