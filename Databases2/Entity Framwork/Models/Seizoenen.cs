using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Seizoenen
	{
		[Required]
		[Key]
		public int seizoen_id { get; set; }
		[Required]
		[ForeignKey("Series")]
		public int serie_id { get; set; }
		public Series series { get; set; }
		[Required]
		[MaxLength(255)]
		public string naam { get; set; }

		public Seizoenen(int seizoen_id, int serie_id, string naam)
		{
			this.seizoen_id = seizoen_id;
			this.serie_id = serie_id;
			this.naam = naam;
		}
	}
}
