﻿using Microsoft.AspNetCore.Mvc;

namespace Task_3.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
