using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Films_kijkwijzer_indicaties
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Films")]
		public int film_id { get; set; }
		public Films films { get; set; }
		[Required]
		[MaxLength(255)]
		public string indicatie { get; set; }

		public Films_kijkwijzer_indicaties(int film_id, string indicatie)
		{
			this.film_id = film_id;
			this.indicatie = indicatie;
		}
	}
}
