using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Films_ondertitelingen
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Films")]
		public int film_id { get; set; }
		public Films films { get; set; }
		[Required]
		[MaxLength(40)]
		public string taal { get; set; }

		public Films_ondertitelingen(int film_id, string taal)
		{
			this.film_id = film_id;
			this.taal = taal;
		}
	}
}
