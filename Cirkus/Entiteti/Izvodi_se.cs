using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Izvodi_se
    {
		public virtual Izvodi_se_id Id { get; set; }
		public virtual DateTime Od { get; set; }
		public virtual DateTime? Do { get; set; }

		public Izvodi_se()
		{
			Id = new Izvodi_se_id();
		}
	}
}
