using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Afleveringen_kwaliteiten
	{
		public int aflevering_id { get; set; }
		public string kwaliteit { get; set; }

		public Afleveringen_kwaliteiten(int aflevering_id, string kwaliteit)
		{
			this.aflevering_id = aflevering_id;
			this.kwaliteit = kwaliteit;
		}
	}
}
