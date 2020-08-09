using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Specijalna_Mapiranje : SubclassMap<Specijalna>
    {
        public Specijalna_Mapiranje()
        {
            Table("SPECIJALNA");

            KeyColumn("ID_PREDSTAVE");
        }
    }
}
