using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Abbonementen_kwaliteiten
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Abbonementen")]
		public int abbonement_id { get; set; }
		public Abbonementen abbonementen { get; set; }
		[Required]
		[MaxLength(40)]
		public string kwaliteit { get; set; }

		public Abbonementen_kwaliteiten(int abbonement_id, string kwaliteit)
		{
			this.abbonement_id = abbonement_id;
			this.kwaliteit = kwaliteit;
		}
	}
}
