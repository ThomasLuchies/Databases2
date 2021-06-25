using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Series_kijk_histories
	{
		[Required]
		[ForeignKey("Kijk_histories")]
		public int kijk_historie_id { get; set; }
		public Kijk_histories kijk_Histories { get; set; }
		[Required]
		[ForeignKey("Afleveringen")]
		public int aflevering_id { get; set; }
		public Afleveringen afleveringen { get; set; }

		public Series_kijk_histories(int kijk_historie_id, int aflevering_id)
		{
			this.kijk_historie_id = kijk_historie_id;
			this.aflevering_id = aflevering_id;
		}
	}
}
