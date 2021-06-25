using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Kijk_histories
	{
		[Required]
		[Key]
		public int kijk_historie_id { get; set; }
		[Required]
		[ForeignKey("Profielen")]
		public int profiel_id { get; set; }
		public Profielen profielen { get; set; }
		[Required]
		public int tijdstip_in_seconden { get; set; }
		[Required]
		public DateTime gekeken_op { get; set; }
		[Required]
		[MaxLength(40)]
		public string taal { get; set; }
		[Required]
		public bool ondertiteling { get; set; }

		public ICollection<Films_kijk_histories> Films_Kijk_Histories;
		public Kijk_histories(int kijk_historie_id, int profiel_id, int tijdstip_in_seconden, DateTime gekeken_op, string taal, bool ondertiteling)
		{
			this.kijk_historie_id = kijk_historie_id;
			this.profiel_id = profiel_id;
			this.tijdstip_in_seconden = tijdstip_in_seconden;
			this.gekeken_op = gekeken_op;
			this.taal = taal;
			this.ondertiteling = ondertiteling;
		}
	}
}
