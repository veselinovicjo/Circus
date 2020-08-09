using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Akrobate_Mapiranje : SubclassMap<Akrobate>
    {
        public Akrobate_Mapiranje()
        {

            DiscriminatorValue("AKROBATA");
            KeyColumn("MATIČNI_BROJ");
            HasMany(x => x.Veštine).KeyColumn("ID_VEŠTINE").Inverse().Cascade.All();

        }
    }
}
