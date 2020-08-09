using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Žongleri : Artisti
    {

		public virtual string predmet { get; set; }
        public virtual int maksimalni_broj { get; set; }


    }
}
