using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Pomoćno_osoblje_Mapiranje : ClassMap<Pomoćno_osoblje>
    {
		public Pomoćno_osoblje_Mapiranje()
		{
			Table("POMOĆNO_OSOBLJE");

			Id(x => x.matični_broj, "MATIČNI_BROJ").GeneratedBy.Assigned();
			Map(x => x.ime, "IME");
			Map(x => x.prezime, "PREZIME");
			Map(x => x.datum_rođenja, "DATUM_ROĐENJA");
			Map(x => x.pol, "POL");
			Map(x => x.mesto_rođenja, "MESTO_ROĐENJA");

			HasManyToMany(x => x.Tačke)
			 .Table("ZADUŽUJE")
			 .ParentKeyColumn("MATIČNI_BROJ")
			 .ChildKeyColumn("BROJ_TAČKE")
			 .LazyLoad()
			 .Cascade.All();

			HasMany(x => x.Zadužuje_osoblje).KeyColumn("MATIČNI_BROJ");



		}
	}
}
