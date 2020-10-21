using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rooster.web.Models
{
	public class DienstenFilteredList
	{
		public List<Dienst> filteredDiensten;
		public DateTime datum;
		public Dienst.Afdeling afdeling;

		public DienstenFilteredList(List<Dienst> diensten, DateTime datum)
		{
			filteredDiensten = diensten.Where(dienst => dienst.begintijd.Date.Equals(datum)).ToList();
			this.datum = datum;
			this.afdeling = Dienst.Afdeling.Alle;
		}
		public DienstenFilteredList(List<Dienst> diensten, DateTime datum, Dienst.Afdeling afdeling)
		{
			filteredDiensten = diensten.Where(dienst =>
				dienst.begintijd.Date.Equals(datum) &&
				(dienst.afdeling.Equals(afdeling) || afdeling.Equals(Dienst.Afdeling.Alle)))
					.ToList();
			this.datum = datum;
			this.afdeling = afdeling;
		}
	}
}
