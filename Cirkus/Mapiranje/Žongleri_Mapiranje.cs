using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Žongleri_Mapiranje  : SubclassMap<Žongleri>
    {
        public Žongleri_Mapiranje()
        {

            DiscriminatorValue("ŽONGLERI");

			KeyColumn("MATIČNI_BROJ");
            Map(x => x.predmet, "PREDMET");
            Map(x => x.maksimalni_broj, "MAKSIMALNI_BROJ");

        }
    }
}
