using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Životinje_Mapiranje : ClassMap<Životinje>
    {
        public Životinje_Mapiranje()
        {
			Table("ŽIVOTINJE");


			Id(x => x.broj_kaveza, "BROJ_KAVEZA").GeneratedBy.Assigned();

			Map(x => x.nadimak, "NADIMAK");
			Map(x => x.datum_dolaska, "DATUM_DOLASKA");
			Map(x => x.težina, "TEŽINA");
			Map(x => x.pol, "POL");
			Map(x => x.vrsta, "VRSTA");
			Map(x => x.starost, "STAROST");
			Map(x => x.veterinarski_pregled, "VETERINARSKI_PREGLED");



           // References(x => x.Dreser).Column("MATIČNI_BROJ"); //.LazyLoad();


		}
	}
}
