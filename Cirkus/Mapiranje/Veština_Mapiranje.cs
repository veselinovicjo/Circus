using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje 
{
    class Veština_Mapiranje : ClassMap<Veština>
    {
         public Veština_Mapiranje()
        {
            Id(x => x.id_veštine, "ID_VEŠTINE").GeneratedBy.Increment();
            Map(x => x.naziv, "NAZIV");
            Map(x => x.broj_godina_iskustva, "BROJ_GODINA_ISKUSTVA");
            
            References(x => x.Akrobata).Column("MATIČNI_BROJ").LazyLoad();

        }
    }
}
