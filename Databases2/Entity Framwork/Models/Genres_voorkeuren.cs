using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Framwork.Models
{
	public class Genres_voorkeuren
	{
		[Required]
		[Key]
		public int genre_voorkeur_id { get; set; }
		[Required]
		[ForeignKey("Voorkeuren")]
		public int voorkeur_id { get; set; }
		public Voorkeuren voorkeuren { get; set; }
		[Required]
		[MaxLength(255)]
		public string genre { get; set; }

		public Genres_voorkeuren(int genre_voorkeur_id, int voorkeur_id, string genre)
		{
			this.genre_voorkeur_id = genre_voorkeur_id;
			this.voorkeur_id = voorkeur_id;
			this.genre = genre;
		}
	}
}
