using Cirkus.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Cirkuska_tačka
    {
        public virtual int broj_tačke { get; set; }
        public virtual string naziv_tačke { get; set; }
        public virtual string tip { get; set; }
        public virtual string efekti { get; set; }
        public virtual string uzrast { get; set; }

        public virtual IList<Cirkuska_predstava> Predstave { get; set; }
        public virtual IList<Sastoji_se> Sastoji_se_tačke { get; set; }

		public virtual IList<Pomoćno_osoblje> Osoblje { get; set; }
		public virtual IList<Zadužuje> Zadužuje_tačke { get; set; }

		public virtual IList<Artisti> Artist { get; set; }
		public virtual IList<Angažuje> Angažuje_tačka { get; set; }

		public Cirkuska_tačka()
        {
			Artist = new List<Artisti>();
			Angažuje_tačka = new List<Angažuje>();
			Predstave = new List<Cirkuska_predstava>();
            Sastoji_se_tačke = new List<Sastoji_se>();
            Osoblje = new List<Pomoćno_osoblje>();
			Zadužuje_tačke = new List<Zadužuje>();

        }
    }
}
