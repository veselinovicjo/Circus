using Cirkus.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Specijalna : Cirkuska_predstava
    {

        public virtual Cirkuska_predstava CirkuskaPredstava { get; set; }

        public Specijalna()
        {
            CirkuskaPredstava = new Cirkuska_predstava();
        }
    }

}
