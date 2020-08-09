using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Grad_Mapiranje : ClassMap<Grad>
    {
        public Grad_Mapiranje()
        {
            Table("GRAD");

            Id(x => x.poštanski_broj, "POŠTANSKI_BROJ").GeneratedBy.Assigned();


            Map(x => x.naziv, "NAZIV");
            Map(x => x.zemlja, "ZEMLJA");
            Map(x => x.opis, "OPIS");

			HasManyToMany(x => x.Predstave)
				.Table("IZVODI_SE")
				.ParentKeyColumn("POŠTANSKI_BROJ")
				.ChildKeyColumn("ID_PREDSTAVE")
				.LazyLoad()
				.Cascade.All();

			HasMany(x => x.Izvodi_se_u).KeyColumn("POŠTANSKI_BROJ");
			
		}
    }
}
