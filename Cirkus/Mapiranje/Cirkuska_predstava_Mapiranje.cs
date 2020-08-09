using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Cirkuska_predstava_Mapiranje : ClassMap<Cirkuska_predstava>
    {
        public Cirkuska_predstava_Mapiranje()
        {
            Table("CIRKUSKA_PREDSTAVA");

            Id(x => x.id_predstave, "ID_PREDSTAVE").GeneratedBy.Increment();
            Map(x => x.broj_prodatih_karata, "BROJ_PRODATIH_KARATA");
            Map(x => x.vreme_predstave, "VREME_PREDSTAVE");

			HasManyToMany(x => x.Gradovi)
			   .Table("IZVODI_SE")
			   .ParentKeyColumn("ID_PREDSTAVE")
			   .ChildKeyColumn("POŠTANSKI_BROJ")
			   .Inverse()
			   .Cascade.All();

			HasMany(x => x.Predstava_u_gradu).KeyColumn("ID_PREDSTAVE").LazyLoad().Cascade.All().Inverse();

			HasManyToMany(x => x.Tačke)
			   .Table("SASTOJI_SE")
			   .ParentKeyColumn("ID_PREDSTAVE")
			   .ChildKeyColumn("BROJ_TAČKE")
				.Inverse()
			   .Cascade.All();

			HasMany(x => x.Sastoji_se_predstava).KeyColumn("ID_PREDSTAVE").LazyLoad().Cascade.All().Inverse();

		}

    }
}
