using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Cirkuska_tačka_Mapiranje : ClassMap<Cirkuska_tačka>
    {
        public Cirkuska_tačka_Mapiranje()
        {
            Table("CIRKUSKA_TAČKA");

            Id(x => x.broj_tačke).Column("BROJ_TAČKE").GeneratedBy.Increment();


            Map(x => x.efekti, "EFEKTI");
            Map(x => x.uzrast, "UZRAST");
            Map(x => x.naziv_tačke, "NAZIV_TAČKE");
            Map(x => x.tip, "TIP");

            HasManyToMany(x => x.Predstave)
             .Table("SASTOJI_SE")
             .ParentKeyColumn("BROJ_TAČKE")
             .ChildKeyColumn("ID_PREDSTAVE")
             .LazyLoad()
             .Cascade.All();

            HasMany(x => x.Sastoji_se_tačke).KeyColumn("BROJ_TAČKE");//.LazyLoad().Cascade.All().Inverse(); 

            HasManyToMany(x => x.Osoblje)
             .Table("ZADUŽUJE")
             .ParentKeyColumn("BROJ_TAČKE")
             .ChildKeyColumn("MATIČNI_BROJ")
             .Inverse()
             .Cascade.All();

            HasMany(x => x.Zadužuje_tačke).KeyColumn("BROJ_TAČKE").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.Angažuje_tačka).KeyColumn("BROJ_TAČKE").LazyLoad().Cascade.All().Inverse();


        }


    }
}
