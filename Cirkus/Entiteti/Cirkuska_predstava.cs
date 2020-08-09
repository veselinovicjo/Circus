using Cirkus.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
     public class Cirkuska_predstava
    {
        public virtual int id_predstave { get; set; }
        public virtual int broj_prodatih_karata { get; set; }
        public virtual string vreme_predstave { get; set; }

        //public virtual Specijalna Specijalne { get; set; }

        public virtual IList<Grad> Gradovi { get; set; }
        public virtual IList<Izvodi_se> Predstava_u_gradu { get; set; }
        public virtual IList<Cirkuska_tačka> Tačke { get; set; }

        public virtual IList<Sastoji_se> Sastoji_se_predstava { get; set; }


        public Cirkuska_predstava()
        {
            Tačke = new List<Cirkuska_tačka>();
            Gradovi = new List<Grad>();
            Sastoji_se_predstava = new List<Sastoji_se>();
            Predstava_u_gradu = new List<Izvodi_se>();
        }
    }
}
