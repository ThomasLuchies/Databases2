using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Afleveringen_kwaliteiten
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Afleveringen")]
		public int aflevering_id { get; set; }
		public Afleveringen afleveringen { get; set; }
		[Required]
		[MaxLength(40)]
		public string kwaliteit { get; set; }

		public Afleveringen_kwaliteiten(int aflevering_id, string kwaliteit)
		{
			this.aflevering_id = aflevering_id;
			this.kwaliteit = kwaliteit;
		}
	}
}
