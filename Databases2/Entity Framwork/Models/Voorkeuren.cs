using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Framwork.Models
{
	public class Voorkeuren
	{
		[Required]
		[Key]
		public int voorkeur_id { get; set; }
		[Required]
		[ForeignKey("Profielen")]
		public int profiel_id { get; set; }
		public Profielen profielen { get; set; }
		[Required]
		public bool film_interesse { get; set; }
		[Required]
		public bool serie_interesse { get; set; }

		public ICollection<Voorkeuren_kijkwijzer_indicaties> Voorkeuren_Kijkwijzer_Indicaties;
		public ICollection<Genres_voorkeuren> Genres_Voorkeurens;

		public Voorkeuren(int voorkeur_id, int profiel_id, bool film_interesse, bool serie_interesse)
		{
			this.voorkeur_id = voorkeur_id;
			this.profiel_id = profiel_id;
			this.film_interesse = film_interesse;
			this.serie_interesse = serie_interesse;
		}
	}
}
