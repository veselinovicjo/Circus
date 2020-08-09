using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirkus.Entiteti;
using FluentNHibernate.Mapping;

namespace Cirkus.Mapiranje
{
    class Poseduje_Mapiranje : ClassMap<Poseduje>
    {
        public Poseduje_Mapiranje()
        {
            Table("POSEDUJE");


            CompositeId()
            .KeyReference(x => x.Poseduje_akrobate, "MATIČNI_BROJ")
            .KeyReference(x => x.Poseduje_veština, "ID_VEŠTINE");
        }
       
    }
}
