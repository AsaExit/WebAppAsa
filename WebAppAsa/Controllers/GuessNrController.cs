﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAsa.Controllers
{
    public class GuessNrController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
