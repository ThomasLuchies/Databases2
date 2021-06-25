using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Films_ondertitelingen
	{
		[Required]
		[ForeignKey("Films")]
		public int film_id { get; set; }
		public Films films { get; set; }
		[Required]
		public string taal { get; set; }

		public Films_ondertitelingen(int film_id, string taal)
		{
			this.film_id = film_id;
			this.taal = taal;
		}
	}
}
