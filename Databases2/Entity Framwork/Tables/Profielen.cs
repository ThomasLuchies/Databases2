using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Profielen
	{
		[Required]
		[Key]
		public int profiel_id { get; set; }
		[Required]
		[ForeignKey("Gebruikers")]
		public int gebruiker_id { get; set; }
		public Gebruikers gebruikers { get; set; }
		[Required]
		[MaxLength(255)]
		public string naam { get; set; }
		[Required]
		[MaxLength(255)]
		public string profiel_foto_locatie { get; set; }
		[Required]
		public DateTime geboorte_datum { get; set; }
		[Required]
		[MaxLength(255)]
		public string taal { get; set; }

		public ICollection<Kijk_histories> Kijk_Histories;
		public Profielen(int profiel_id, int gebruiker_id, string naam, string profiel_foto_locatie, DateTime geboorte_datum, string taal)
		{
			this.profiel_id = profiel_id;
			this.gebruiker_id = gebruiker_id;
			this.naam = naam;
			this.profiel_foto_locatie = profiel_foto_locatie;
			this.geboorte_datum = geboorte_datum;
			this.taal = taal;
		}
	}
}
