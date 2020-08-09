using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Artisti
    {
		public virtual long matični_broj { get; set; }
		public virtual string ime { get; set; }
		public virtual string prezime { get; set; }
		public virtual string ime_roditelja { get; set; }
		public virtual string nadimak { get; set; }
		public virtual DateTime datum_rođenja { get; set; }
		public virtual string mesto_rođenja { get; set; }
		public virtual char pol { get; set; }
		public virtual string asistenti { get; set; }
		public virtual DateTime datum_dolaska { get; set; }

		public virtual Cirkuska_tačka Tačka { get; set; }
		public virtual IList<Angažuje> Angažuje_artisti { get; set; }




		public Artisti()
		{
			Tačka = new Cirkuska_tačka();
			Angažuje_artisti = new List<Angažuje>();

		}

		//public virtual Akrobate Akrobate { get; set; }
		//public virtual Dreseri Dreseri { get; set; }
		//public virtual Žongleri Žongleri { get; set; }
		//public virtual Klovnovi Klovnovi { get; set; }
		//public virtual Gutači_plamena gutači_plamena { get; set; }
		//public virtual Bacači_noževa Bacači_noževa { get; set; }



		//public Artisti()
		//{
		//	//Akrobate = new Akrobate();
		//	Dreseri = new Dreseri();
		//	//Žongleri = new Žongleri();
		//	//Klovnovi = new Klovnovi();
		//}
	}
}
