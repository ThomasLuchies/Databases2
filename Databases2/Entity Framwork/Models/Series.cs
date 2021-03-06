using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Series
	{
		[Required]
		[Key]
		public int serie_id { get; set; }
		[Required]
		[MaxLength(255)]
		public string naam { get; set; }

		public ICollection<Seizoenen> Seizoenens;
		public ICollection<Series_kijk_histories> series_Kijk_Histories;
		public ICollection<Series_kijkwijzer_indicaties> series_Kijkwijzer_Indicaties;
		public ICollection<Series_genres> series_Genres;
	}
}
