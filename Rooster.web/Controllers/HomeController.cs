using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rooster.web.Models;

namespace Rooster.web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private List<Dienst> diensten;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
			this.initialize();
		}

		public IActionResult Index()
		{
			var DFL = new DienstenFilteredList(diensten, DateTime.Now.Date);
			return View(DFL);
		}

		public IActionResult Next(DateTime datum)
		{
			var DFL = new DienstenFilteredList(diensten, datum.AddDays(1));
			return View("Index", DFL);
		}
		public IActionResult Previous(DateTime datum)
		{
			var DFL = new DienstenFilteredList(diensten, datum.AddDays(-1));
			return View("Index", DFL);
		}

		public IActionResult SelectAfdeling(DateTime datum, Dienst.Afdeling afdeling)
		{
			var DFL = new DienstenFilteredList(diensten, datum, afdeling);
			return View("Index", DFL);
		}

		public void initialize()
		{
			diensten = new List<Dienst>();

			#region 20 october
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 20, 7, 45, 00),
				eindtijd = new DateTime(2020, 10, 20, 16, 00, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Ard den Vogel"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 20, 11, 00, 00),
				eindtijd = new DateTime(2020, 10, 20, 17, 15, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Bas Bahco"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 20, 15, 0, 00),
				eindtijd = new DateTime(2020, 10, 20, 21, 30, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Mert Polat"
			});
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 20, 8, 0, 00),
				eindtijd = new DateTime(2020, 10, 20, 13, 15, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Alex Waarts"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 20, 10, 30, 00),
				eindtijd = new DateTime(2020, 10, 20, 16, 15, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Joris Koevoets"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 20, 14, 0, 00),
				eindtijd = new DateTime(2020, 10, 20, 21, 30, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Remco van de Broek"
			});
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 20, 8, 0, 00),
				eindtijd = new DateTime(2020, 10, 20, 14, 0, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Marijn Kieboom"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 20, 11, 0, 00),
				eindtijd = new DateTime(2020, 10, 20, 16, 15, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Johannes Vermeer"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 20, 14, 0, 00),
				eindtijd = new DateTime(2020, 10, 20, 20, 30, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Gregorius van der Eijck"
			});
			#endregion
			#region 21 october
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 21, 7, 45, 00),
				eindtijd = new DateTime(2020, 10, 21, 16, 00, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Piet Heijn"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 21, 11, 00, 00),
				eindtijd = new DateTime(2020, 10, 21, 17, 15, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Sinterklaas"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 21, 15, 0, 00),
				eindtijd = new DateTime(2020, 10, 21, 21, 30, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Marijn Kieboom"
			});
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 21, 8, 0, 00),
				eindtijd = new DateTime(2020, 10, 21, 13, 15, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Joris Koevoets"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 21, 10, 30, 00),
				eindtijd = new DateTime(2020, 10, 21, 16, 15, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Remco van den Broek"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 21, 14, 0, 00),
				eindtijd = new DateTime(2020, 10, 21, 21, 30, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Mert Polat"
			});
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 21, 8, 0, 00),
				eindtijd = new DateTime(2020, 10, 21, 14, 0, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Alex Waarts"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 21, 11, 0, 00),
				eindtijd = new DateTime(2020, 10, 21, 16, 15, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Harry Jekkers"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 21, 14, 0, 00),
				eindtijd = new DateTime(2020, 10, 21, 20, 30, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Voornaam Achternaam"
			});
			#endregion
			#region 22 october
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 22, 7, 45, 00),
				eindtijd = new DateTime(2020, 10, 22, 16, 00, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Ard den Vogel"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 22, 11, 00, 00),
				eindtijd = new DateTime(2020, 10, 22, 17, 15, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Bas Bahco"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 22, 15, 0, 00),
				eindtijd = new DateTime(2020, 10, 22, 21, 30, 00),
				afdeling = Dienst.Afdeling.Kassa,
				medewerker = "Mert Polat"
			});
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 22, 8, 0, 00),
				eindtijd = new DateTime(2020, 10, 22, 13, 15, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Alex Waarts"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 22, 10, 30, 00),
				eindtijd = new DateTime(2020, 10, 22, 16, 15, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Joris Koevoets"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 22, 14, 0, 00),
				eindtijd = new DateTime(2020, 10, 22, 21, 30, 00),
				afdeling = Dienst.Afdeling.Vers,
				medewerker = "Remco van de Broek"
			});
			diensten.Add(new Dienst
			{ // year, month, day, hour, minute, second
				begintijd = new DateTime(2020, 10, 22, 8, 0, 00),
				eindtijd = new DateTime(2020, 10, 22, 14, 0, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Marijn Kieboom"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 22, 11, 0, 00),
				eindtijd = new DateTime(2020, 10, 22, 16, 15, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Johannes Vermeer"
			});
			diensten.Add(new Dienst
			{
				begintijd = new DateTime(2020, 10, 22, 14, 0, 00),
				eindtijd = new DateTime(2020, 10, 22, 20, 30, 00),
				afdeling = Dienst.Afdeling.Vakkenvullen,
				medewerker = "Gregorius van der Eijck"
			});
			#endregion

			diensten = diensten.OrderBy(d => d.begintijd).ToList();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
