using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framwork.Tables
{
	public class Voorkeuren_kijkwijzer_indicaties
	{
		[Required]
		[ForeignKey("Voorkeuren")]
		public int voorkeur_id { get; set; }
		public Voorkeuren voorkeuren { get; set; }
		[Required]
		[MaxLength(255)]
		public string indicatie { get; set; }

		public Voorkeuren_kijkwijzer_indicaties(int voorkeur_id, string indicatie)
		{
			this.voorkeur_id = voorkeur_id;
			this.indicatie = indicatie;
		}
	}
}
