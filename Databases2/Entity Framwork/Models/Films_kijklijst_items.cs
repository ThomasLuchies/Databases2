using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Films_kijklijst_items
	{
		public int id { get; set; }
		[Required]
		[ForeignKey("Kijklijst_items")]
		public int kijklijst_item_id { get; set; }
		public Kijklijst_items kijklijst_Items { get; set; }
		[Required]
		[ForeignKey("Films")]
		public int film_id { get; set; }
		public Films films { get; set; }

		public Films_kijklijst_items(int kijklijst_item_id, int film_id)
		{
			this.kijklijst_item_id = kijklijst_item_id;
			this.film_id = film_id;
		}
	}
}
