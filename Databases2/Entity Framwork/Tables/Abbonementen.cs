using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framwork.Tables
{
	public class Abbonementen
	{
		[Required]
		[Key]
		public int abbonement_id { get; set; }
		[Required]
		[MaxLength(255)]
		public string naam { get; set; }
		[Required]
		public int prijs_in_centen { get; set; }

		public ICollection<Gebruikers_abbonementen> Gebruikers_Abbonementen;
		public ICollection<Abbonementen_kwaliteiten> Abbonementen_Kwaliteiten;

		public Abbonementen(string naam, int prijs_in_centen)
		{
			this.naam = naam;
			this.prijs_in_centen = prijs_in_centen;
		}
	}
}
