using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Films_kijk_histories
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Kijk_histories")]
		public int kijk_historie_id { get; set; }
		public Kijk_histories kijk_Histories { get; set; }
		[Required]
		[ForeignKey("Films")]
		public int film_id { get; set; }
		public Films films { get; set; }

		public Films_kijk_histories(int kijk_historie_id, int film_id)
		{
			this.kijk_historie_id = kijk_historie_id;
			this.film_id = film_id;
		}
	}
}
