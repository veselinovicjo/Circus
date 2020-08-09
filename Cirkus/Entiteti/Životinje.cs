using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Životinje 
    {
        public virtual int broj_kaveza { get; set; }
        public virtual string nadimak { get; set; }
        public virtual string vrsta { get; set; }
        public virtual char pol { get; set; }
        public virtual string starost { get; set; }
        public virtual float težina { get; set; }
        public virtual DateTime datum_dolaska { get; set; }
		public virtual DateTime veterinarski_pregled { get; set; }

		public virtual Dreseri Dreser { get; set; }
		public virtual IList<Dresira> Dresira_životinje { get; set; }
		public virtual IList<Cirkuska_tačka> Tačke { get; set; }

		public Životinje()
		{
			Dresira_životinje = new List<Dresira>();
			Tačke = new List<Cirkuska_tačka>();

		}

	}
}
