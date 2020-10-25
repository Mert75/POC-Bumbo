﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rooster.web.Models
{
	public class Dienst
	{
		public DateTime begintijd { get; set; }
		public DateTime eindtijd { get; set; }
		public Afdeling afdeling { get; set; }
		public String medewerker { get; set; }

		public enum Afdeling
		{
			Alle,
			Vers,
			Kassa,
			Vakkenvullen
		}
	}
}
