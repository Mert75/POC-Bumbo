﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rooster.web.Models;

namespace Rooster.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Dienst> diensten;
        public int offset = 0;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            this.initialize();
        }

        public IActionResult Index()
        {
            ViewBag.datum = DateTime.Now.Date;
            return View(diensten);
        }

        public void initialize()
        {
            diensten = new List<Dienst>();

            diensten.Add(new Dienst
            { // year, month, day, hour, minute, second
                begintijd = new DateTime(2020, 10, 19, 13, 00, 00),
                eindtijd = new DateTime(2020, 10, 19, 18, 00, 00),
                afdeling = "Kassa",
                medewerker = "Ard den Vogel"
            });
            diensten.Add(new Dienst
            {
                begintijd = new DateTime(2020, 10, 19, 13, 00, 00),
                eindtijd = new DateTime(2020, 10, 19, 21, 00, 00),
                afdeling = "Vers",
                medewerker = "Bas Bahco"
            });

            diensten.Add(new Dienst
            {
                begintijd = new DateTime(2020, 10, 19, 19, 15, 00),
                eindtijd = new DateTime(2020, 10, 19, 22, 00, 00),
                afdeling = "Vers",
                medewerker = "Mert Polat"
            });

            diensten.Add(new Dienst
            {
                begintijd = new DateTime(2020, 10, 20, 21, 15, 00),
                eindtijd = new DateTime(2020, 10, 20, 22, 00, 00),
                afdeling = "Vers",
                medewerker = "Mert Polat"
            });
            
            diensten.Add(new Dienst
            {
                begintijd = new DateTime(2020, 10, 21, 18, 15, 00),
                eindtijd = new DateTime(2020, 10, 21, 22, 00, 00),
                afdeling = "Vers",
                medewerker = "xd"
            });
        }
        public IActionResult addDay()
        {
            offset++;
            ViewBag.datum = DateTime.Now.Date.AddDays(offset);
            return View("Index", diensten);
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}