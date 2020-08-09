using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Po_narudžbini_Mapiranje //: SubclassMap<Po_narudžbini>
    {
        public Po_narudžbini_Mapiranje()
        {

            //Table("PO_NARUDŽBINI");

            //KeyColumn("ID_PREDSTAVE");

            //Map(x => x.naziv).Column("NAZIV");
            //Map(x => x.adresa).Column("ADRESA");
            //Map(x => x.broj_telefona).Column("BROJ_TELEFONA");

        }
    }
}
