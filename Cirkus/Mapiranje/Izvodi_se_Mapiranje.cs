using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranje
{
     class Izvodi_se_Mapiranje : ClassMap<Izvodi_se>
    {
		public Izvodi_se_Mapiranje()
		{
			Table("IZVODI_SE");

			CompositeId(x => x.Id)
				 .KeyReference(x => x.Predstava_u_gradu, "ID_PREDSTAVE")
				 .KeyReference(x => x.Izvodi_se_u, "POŠTANSKI_BROJ");


			Map(x => x.Od).Column("OD");
			Map(x => x.Do).Column("DO");

		}
	}
}
