using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Framwork.Tables
{
	public class Series_kijkwijzer_indicaties
	{
		[Required]
		[ForeignKey("Series")]
		public int serie_id { get; set; }
		public Series series { get; set; }
		[Required]
		public string indicatie { get; set; }

		public Series_kijkwijzer_indicaties(int serie_id, string indicatie)
		{
			this.serie_id = serie_id;
			this.indicatie = indicatie;
		}
	}
}
