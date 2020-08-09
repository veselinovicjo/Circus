using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Dreseri : Artisti
    {
		public virtual IList<Životinje> Životinja { get; set; }
		public virtual IList<Dresira> Dresira_dreseri { get; set; }

		public Dreseri()
		{
			Životinja = new List<Životinje>();
			Dresira_dreseri = new List<Dresira>();
		}
	}
}
