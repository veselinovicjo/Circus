using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Zadužuje
    {
		public virtual Zadužuje_id id { get; set; }


		public Zadužuje()
		{

			id = new Zadužuje_id();
		}
	}
}
