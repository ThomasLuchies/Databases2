using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Series_kijklijst_items
	{
		public int kijklijst_item_id { get; set; }
		public int serie_id { get; set; }

		public Series_kijklijst_items(int kijklijst_item_id, int serie_id)
		{
			this.kijklijst_item_id = kijklijst_item_id;
			this.serie_id = serie_id;
		}
	}
}
