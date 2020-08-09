using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
	class Angažuje_Mapiranje : ClassMap<Angažuje>
	{
		public Angažuje_Mapiranje()
		{
			////Mapiranje tabele

			Table("ANGAŽUJE");

			CompositeId()
			.KeyReference(x => x.Angažuje_artisti, "MATIČNI_BROJ")
			.KeyReference(x => x.Angažuje_tačka, "BROJ_TAČKE");

		}
	}
}
