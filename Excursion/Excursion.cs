using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion
{
	public class Excursion
	{
		public string Country { get; set; }
		public string Guide { get; set; }
		public int Price { get; set; }
		public int Duration { get; set; }

		public Excursion(string country = "", string guide = "", int price = 0, int duration =0)
		{
			this.Guide = guide;
			this.Country = country;
			this.Price = price;
			this.Duration = duration;
		}

		public static Excursion Parse(string bookText)
		{
			var bookProps = bookText.Split(' ');
			return new Excursion(bookProps[0], bookProps[1], Int32.Parse(bookProps[2]), Int32.Parse(bookProps[3]));
		}

		public override string ToString()
		{
			return $"{this.Country} {this.Guide} {this.Price} {this.Duration}";
		}

		public static bool operator == (Excursion a, Excursion b)
		{
			return a.Country == b.Country && a.Price == b.Price && a.Duration == b.Duration && a.Guide == b.Guide;
		}

		public static bool operator !=(Excursion a, Excursion b)
		{
			return a.Country != b.Country || a.Price != b.Price || a.Duration != b.Duration || a.Guide != b.Guide;
		}
	}	
}
