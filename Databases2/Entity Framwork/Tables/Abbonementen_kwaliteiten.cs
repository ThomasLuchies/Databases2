using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Abbonementen_kwaliteiten
	{
		public int abbonement_id { get; set; }
		public string kwaliteit { get; set; }

		public Abbonementen_kwaliteiten(int abbonement_id, string kwaliteit)
		{
			this.abbonement_id = abbonement_id;
			this.kwaliteit = kwaliteit;
		}
	}
}
