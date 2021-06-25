using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Films_kwaliteiten
	{
		[Required]
		[ForeignKey("Films")]
		public int film_id { get; set; }
		public Films films { get; set; }
		[Required]
		[MaxLength(40)]
		public string kwaliteit { get; set; }

		public Films_kwaliteiten(int film_id, string kwaliteit)
		{
			this.film_id = film_id;
			this.kwaliteit = kwaliteit;
		}
	}
}
