using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
	public class Dresira
	{
		public virtual Dreseri Dresira_dreseri { get; set; }
		public virtual Životinje Dresira_životinje { get; set; }


		public override bool Equals(object obj)
		{
			if (Object.ReferenceEquals(this, obj))
				return true;

			if (obj.GetType() != typeof(Dresira))
				return false;

			Dresira recievedObject = (Dresira)obj;

			if ((Dresira_dreseri.matični_broj == recievedObject.Dresira_dreseri.matični_broj) &&
				(Dresira_životinje.broj_kaveza == recievedObject.Dresira_životinje.broj_kaveza)) 
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
