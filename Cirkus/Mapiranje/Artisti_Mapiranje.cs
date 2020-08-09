using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Artisti_Mapiranje : ClassMap<Artisti>
    {
		public Artisti_Mapiranje()
		{
			Table("ARTISTI");


			Id(x => x.matični_broj, "MATIČNI_BROJ").GeneratedBy.Assigned();

			Map(x => x.ime, "LIME");
			Map(x => x.ime_roditelja, "IME_RODITELJA");
			Map(x => x.prezime, "PREZIME");
			Map(x => x.nadimak, "NADIMAK");
			Map(x => x.mesto_rođenja, "MESTO_ROĐENJA");
			Map(x => x.datum_rođenja, "DATUM_ROĐENJA");
			Map(x => x.datum_dolaska, "DATUM_DOLASKA");
			Map(x => x.pol, "POL");
			Map(x => x.asistenti, "ASISTENTI");
            //Map(x => x.tip, "TIP");

            //HasManyToMany(x => x.Tačke)
            // .Table("ANGAŽUJE")
            // .ParentKeyColumn("MATIČNI_BROJ")
            // .ChildKeyColumn("BROJ_TAČKE")
            // .LazyLoad()
            // .Cascade.All();

            References(x => x.Tačka).Column("BROJ_TAČKE").LazyLoad();
            //HasMany(x => x.Angažuje_artisti).KeyColumn("MATIČNI_BROJ");

        }


    }
}
