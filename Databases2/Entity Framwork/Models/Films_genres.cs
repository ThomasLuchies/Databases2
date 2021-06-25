using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Films_genres
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Films")]
		public int film_id { get; set; }
		public Films films { get; set; }
		[Required]
		[MaxLength(255)]
		public string genre { get; set; }

		public Films_genres(int film_id, string genre)
		{
			this.film_id = film_id;
			this.genre = genre;
		}
	}
}
