using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Films
	{
		[Required]
		[Key]
		public int film_id { get; set; }
		[Required]
		[MaxLength(255)]
		public string naam { get; set; }
		[Required]
		public int tijdsduur_in_seconden { get; set; }
		[Required]
		public int aftiteling_tijdstip_in_seconden { get; set; }

		public ICollection<Films_kijk_histories> Films_Kijk_Histories;
		public ICollection<Films_kijklijst_items> films_Kijklijst_Items;
		public ICollection<Films_kijkwijzer_indicaties> Films_Kijkwijzer_Indicaties;
		public ICollection<Films_genres> Films_Genres;
		public ICollection<Films_kwaliteiten> Films_Kwaliteitens;

		public Films(int film_id, string naam, int tijdsduur_in_seconden, int aftiteling_tijdstip_in_seconden)
		{
			this.film_id = film_id;
			this.naam = naam;
			this.tijdsduur_in_seconden = tijdsduur_in_seconden;
			this.aftiteling_tijdstip_in_seconden = aftiteling_tijdstip_in_seconden;
		}
	}
}
