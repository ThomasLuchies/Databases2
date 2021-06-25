using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Series_genres
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Series")]
		public int serie_id { get; set; }
		public Series series { get; set; }
		[Required]
		[MaxLength(255)]
		public string genre { get; set; }

		public Series_genres(int serie_id, string genre)
		{
			this.serie_id = serie_id;
			this.genre = genre;
		}
	}
}
