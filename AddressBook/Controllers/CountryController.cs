﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}