using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Afleveringen_ondertitelingen
	{
		[Required]
		[ForeignKey("Afleveringen")]
		public int aflevering_id { get; set; }
		public Afleveringen afleveringen { get; set; }
		[Required]
		public string taal { get; set; }

		public Afleveringen_ondertitelingen(int aflevering_id, string taal)
		{
			this.aflevering_id = aflevering_id;
			this.taal = taal;
		}
	}
}
