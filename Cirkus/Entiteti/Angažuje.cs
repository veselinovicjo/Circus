using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
	public class Angažuje
	{
		public virtual Cirkuska_tačka Angažuje_tačka { get; set; }
		public virtual Artisti Angažuje_artisti { get; set; }


		public override bool Equals(object obj)
		{
			if (Object.ReferenceEquals(this, obj))
				return true;

			if (obj.GetType() != typeof(Angažuje))
				return false;

			Angažuje recievedObject = (Angažuje)obj;

			if ((Angažuje_artisti.matični_broj == recievedObject.Angažuje_artisti.matični_broj) &&
				(Angažuje_tačka.broj_tačke == recievedObject.Angažuje_tačka.broj_tačke))
			{
				return true;
			}

			return false;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
