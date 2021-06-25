using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Gebruikers_abbonementen
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Gebruikers")]
		public int gebruiker_id { get; set; }
		public Gebruikers gebruikers { get; set; }
		[Required]
		[ForeignKey("Abbonementen")]
		public int abbonement_id { get; set; }
		public Abbonementen Abonnementen { get; set; }
		[Required]
		public DateTime verloopt_op { get; set; }
		[Required]
		public int korting_in_centen { get; set; }

		public Gebruikers_abbonementen(int gebruiker_id, int abbonement_id, DateTime verloopt_op, int korting_in_centen)
		{
			this.gebruiker_id = gebruiker_id;
			this.abbonement_id = abbonement_id;
			this.verloopt_op = verloopt_op;
			this.korting_in_centen = korting_in_centen;
		}
	}
}
