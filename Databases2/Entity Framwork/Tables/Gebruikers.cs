using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_Framwork.Tables
{
	public class Gebruikers
	{
		[Required]
		[Key]
		public int gebruiker_id { get; set; }
		[Required]
		[MaxLength(255)]
		public string emailadres { get; set; }
		[Required]
		[MaxLength(1000)]
		public string wachtwoord { get; set; }
		[Required]
		public bool actief { get; set; }
		[Required]
		public bool geblokkeerd { get; set; }
		[Required]
		public DateTime geblokkeerd_tot { get; set; }
		[Required]
		public short foutieve_inlogpogingen { get; set; }
		[Required]
		[MaxLength(40)]
		public string reset_token { get; set; }

		public ICollection<Gebruikers_abbonementen> Gebruikers_Abbonementens;
		public ICollection<Profielen> Profielens;

		public Gebruikers(int gebruiker_id, string emailadres, string wachtwoord, bool actief, bool geblokkeerd, DateTime geblokkeerd_tot, short foutieve_inlogpogingen, string reset_token)
		{
			this.gebruiker_id = gebruiker_id;
			this.emailadres = emailadres;
			this.wachtwoord = wachtwoord;
			this.actief = actief;
			this.geblokkeerd = geblokkeerd;
			this.geblokkeerd_tot = geblokkeerd_tot;
			this.foutieve_inlogpogingen = foutieve_inlogpogingen;
			this.reset_token = reset_token;
		}
	}
}
