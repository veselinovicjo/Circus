using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Zadužuje_Mapiranje : ClassMap<Zadužuje>
    {
		public Zadužuje_Mapiranje()
		{
			Table("ZADUŽUJE");

			CompositeId(x => x.id)
				.KeyReference(x => x.zaduženo_Osoblje, "MATIČNI_BROJ")
				.KeyReference(x => x.zaduženo_Tačka, "BROJ_TAČKE");

		}
	}
}
