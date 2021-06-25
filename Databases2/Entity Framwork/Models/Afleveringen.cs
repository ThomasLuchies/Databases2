using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity_Framwork.Models
{
	public class Afleveringen
	{
		[Required]
		[Key]
		public int aflevering_id { get; set; }
		[Required]
		[ForeignKey("Seizoenen")]
		public int seizoen_id { get; set; }
		public Seizoenen seizoenen { get; set; }
		[Required]
		[ForeignKey("Afleveringen")]
		public int volgende_aflevering_id { get; set; }
		public Afleveringen afleveringen { get; set; }
		[Required]
		[MaxLength(255)]
		public string naam { get; set; }
		[Required]
		public int tijdsduur_in_seconden { get; set; }
		[Required]
		public int aftiteling_tijdstip_in_seconden { get; set; }

		public ICollection<Seizoenen> Seizoenens;
		public ICollection<Afleveringen> Afleveringens;
		public ICollection<Series_kijk_histories> Series_Kijk_Histories;
		public ICollection<Afleveringen_kwaliteiten> Afleveringen_Kwaliteitens;
		public ICollection<Afleveringen_ondertitelingen> Afleveringen_Ondertitelingens;

		public Afleveringen(int aflevering_id, int seizoen_id, int volgende_aflevering_id, string naam, int tijdsduur_in_seconden, int aftiteling_tijdstip_in_seconden)
		{
			this.aflevering_id = aflevering_id;
			this.seizoen_id = seizoen_id;
			this.volgende_aflevering_id = volgende_aflevering_id;
			this.naam = naam;
			this.tijdsduur_in_seconden = tijdsduur_in_seconden;
			this.aftiteling_tijdstip_in_seconden = aftiteling_tijdstip_in_seconden;
		}
	}
}
