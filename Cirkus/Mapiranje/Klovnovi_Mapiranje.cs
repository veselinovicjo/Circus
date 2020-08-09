using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Klovnovi_Mapiranje : SubclassMap<Klovnovi>
    {
		public Klovnovi_Mapiranje()
		{ 

			Table("KLOVNOVI");

			KeyColumn("MATIČNI_BROJ");

			Map(x => x.tip).Column("TIP");
			Map(x => x.čime_zabavlja).Column("ČIME_ZABAVLJA");


		}
	}
}
