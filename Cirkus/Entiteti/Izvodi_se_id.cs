using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Izvodi_se_id
    {
		public virtual Cirkuska_predstava Predstava_u_gradu { get; set; }
		public virtual Grad Izvodi_se_u { get; set; }

		public override bool Equals(object obj)
		{
			if (Object.ReferenceEquals(this, obj))
				return true;

			if (obj.GetType() != typeof(Izvodi_se_id))
				return false;

			Izvodi_se_id recievedObject = (Izvodi_se_id)obj;

			if ((Predstava_u_gradu.id_predstave == recievedObject.Predstava_u_gradu.id_predstave) &&
				(Izvodi_se_u.poštanski_broj == recievedObject.Izvodi_se_u.poštanski_broj))
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
