using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranje
{
    class Sastoji_se_Mapiranje : ClassMap<Sastoji_se>
    {
        public Sastoji_se_Mapiranje()
        {
			////Mapiranje tabele

			Table("SASTOJI_SE");

			CompositeId()
			.KeyReference(x => x.Sastoji_se_predstava, "ID_PREDSTAVE")
			.KeyReference(x => x.Sastoji_se_tačka, "BROJ_TAČKE");

		}
    }

}
