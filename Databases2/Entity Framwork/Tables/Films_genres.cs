using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Films_genres
	{
		[Required]
		[ForeignKey("Films")]
		public int film_id { get; set; }
		public Films films { get; set; }
		[Required]
		public string genre { get; set; }

		public Films_genres(int film_id, string genre)
		{
			this.film_id = film_id;
			this.genre = genre;
		}
	}
}
