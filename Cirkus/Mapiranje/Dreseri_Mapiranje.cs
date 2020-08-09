using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Dreseri_Mapiranje : SubclassMap<Dreseri>
    {
		public Dreseri_Mapiranje()
		{
            DiscriminatorValue("DRESERI");
            KeyColumn("MATIČNI_BROJ");
            HasMany(x => x.Životinja).KeyColumn("MATIČNI_BROJ").LazyLoad().Cascade.All().Inverse();
        }
    }
}
