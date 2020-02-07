using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace C_Sharp_TimeDisplay.Controllers
{
    public class TimeController : Controller  
    {
        [HttpGet("")]
        public IActionResult Time()
        {

            DateTime aDate = DateTime.Now;
            ViewBag.DateDisplay = aDate.ToString("dd MMMM yyyy");
            ViewBag.DayDisplay = aDate.ToString("dddd");
            ViewBag.TimeDisplay = aDate.ToString("hh:mm tt");

            ViewBag.DateDisplay2 = aDate.ToString("MMM dd, yyyy");
            ViewBag.DayDisplay2 = aDate.ToString("ddd");
            ViewBag.TimeDisplay2 = aDate.ToString("HH:mm");


            return View();
        }

        // [HttpGet("projects")]
        // public IActionResult Projects()
        // {
        //     ViewBag.Projects =  "This is my projects!";
        //     return View();
        // }

        // [HttpGet("contact")]
        // public IActionResult Contact()
        // {
        //     ViewBag.Contact = "This is my contact!";
        //     return View();
        // }

    }
}
