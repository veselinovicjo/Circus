using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranje
{
	class Dresira_Mapiranje : ClassMap<Dresira>
	{

		public Dresira_Mapiranje()
		{
			////Mapiranje tabele

			Table("DRESIRA");


			CompositeId()
			.KeyReference(x => x.Dresira_dreseri, "MATIČNI_BROJ")
			.KeyReference(x => x.Dresira_životinje, "BROJ_KAVEZA");

		}
	}
}
