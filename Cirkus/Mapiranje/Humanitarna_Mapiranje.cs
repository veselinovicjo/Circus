using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Cirkus.Entiteti;

namespace Cirkus.Mapiranje
{
    class Humanitarna_Mapiranje : SubclassMap<Humanitarna>
    {
        public Humanitarna_Mapiranje()
        {

            Table("HUMANITARNA");

            KeyColumn("ID_PREDSTAVE");

            Map(x => x.prihod).Column("PRIHOD");
            Map(x => x.namena).Column("NAMENA");

        }
    }
}
