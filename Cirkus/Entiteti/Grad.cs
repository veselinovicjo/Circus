using Cirkus.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Grad
    {
        public virtual int poštanski_broj { get; set; }
        public virtual string naziv { get; set; }
        public virtual string zemlja { get; set; }
        public virtual string opis { get; set; }

        public virtual IList<Cirkuska_predstava> Predstave { get; set; }

        public virtual IList<Izvodi_se> Izvodi_se_u { get; set; }
        public Grad()
        {
            Predstave = new List<Cirkuska_predstava>();

            Izvodi_se_u = new List<Izvodi_se>();
        }
    }
}
