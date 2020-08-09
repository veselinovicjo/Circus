using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Pomoćno_osoblje
    {
		public virtual long matični_broj { get; set; }
		public virtual string ime { get; set; }
		public virtual string prezime { get; set; }
        public virtual char pol { get; set; }
        public virtual DateTime datum_rođenja { get; set; }
		public virtual string mesto_rođenja { get; set; }


		public virtual IList<Cirkuska_tačka> Tačke { get; set; }
		public virtual IList<Zadužuje> Zadužuje_osoblje { get; set; }

		public Pomoćno_osoblje()
		{
			Tačke = new List<Cirkuska_tačka>();
			Zadužuje_osoblje = new List<Zadužuje>();
		}
	}
}
