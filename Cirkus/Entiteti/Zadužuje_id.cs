using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Zadužuje_id
    {
		public virtual Pomoćno_osoblje zaduženo_Osoblje { get; set; }
		public virtual Cirkuska_tačka zaduženo_Tačka { get; set; }

		public override bool Equals(object obj)
		{
			if (Object.ReferenceEquals(this, obj))
				return true;

			if (obj.GetType() != typeof(Zadužuje_id))
				return false;

			Zadužuje_id recievedObject = (Zadužuje_id)obj;

			if ((zaduženo_Osoblje.matični_broj == recievedObject.zaduženo_Osoblje.matični_broj) &&
				(zaduženo_Tačka.broj_tačke == recievedObject.zaduženo_Tačka.broj_tačke))
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

