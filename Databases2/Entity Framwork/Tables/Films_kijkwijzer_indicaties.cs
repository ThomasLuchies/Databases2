using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Films_kijkwijzer_indicaties
	{
		public int film_id { get; set; }
		public string indicatie { get; set; }

		public Films_kijkwijzer_indicaties(int film_id, string indicatie)
		{
			this.film_id = film_id;
			this.indicatie = indicatie;
		}
	}
}
