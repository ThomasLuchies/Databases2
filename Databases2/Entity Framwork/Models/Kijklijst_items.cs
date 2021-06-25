using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Kijklijst_items
	{
		[Required]
		[Key]
		public int kijklijst_item_id { get; set; }
		[Required]
		[ForeignKey("Profielen")]
		public int profiel_id { get; set; }
		public Profielen profielen { get; set; }
		[Required]
		public bool gekeken { get; set; }

		public ICollection<Series_kijklijst_items> Series_Kijklijst_Items;
		public ICollection<Films_kijklijst_items> films_Kijklijst_Items;

		public Kijklijst_items(int kijklijst_item_id, int profiel_id, bool gekeken)
		{
			this.kijklijst_item_id = kijklijst_item_id;
			this.profiel_id = profiel_id;
			this.gekeken = gekeken;
		}
	}
}
