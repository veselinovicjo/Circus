using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Klovnovi : Artisti
    {

        public virtual string tip { get; set; }
        public virtual string čime_zabavlja { get; set; }

		public Klovnovi()
		{

		}


    }
}
