using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Sastoji_se
    {

        public virtual Cirkuska_predstava Sastoji_se_predstava { get; set; }
        public virtual Cirkuska_tačka Sastoji_se_tačka { get; set; }


		public override bool Equals(object obj)
		{
			if (Object.ReferenceEquals(this, obj))
				return true;

			if (obj.GetType() != typeof(Sastoji_se))
				return false;

			Sastoji_se recievedObject = (Sastoji_se)obj;

			if ((Sastoji_se_predstava.id_predstave == recievedObject.Sastoji_se_predstava.id_predstave) &&
				(Sastoji_se_tačka.broj_tačke == recievedObject.Sastoji_se_tačka.broj_tačke))
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
