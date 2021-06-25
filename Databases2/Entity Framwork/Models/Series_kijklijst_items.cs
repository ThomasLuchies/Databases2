using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Series_kijklijst_items
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Kijklijst_items")]
		public int kijklijst_item_id { get; set; }
		public Kijklijst_items kijklijst_Items { get; set; }
		[Required]
		[ForeignKey("Series")]
		public int serie_id { get; set; }
		public Series series { get; set; }

		public Series_kijklijst_items(int kijklijst_item_id, int serie_id)
		{
			this.kijklijst_item_id = kijklijst_item_id;
			this.serie_id = serie_id;
		}
	}
}
