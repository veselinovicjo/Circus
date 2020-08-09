using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Poseduje
    {
        public virtual Veština Poseduje_veština { get; set; }
        public virtual Akrobate Poseduje_akrobate { get; set; }


        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(Poseduje))
                return false;

            Poseduje recievedObject = (Poseduje)obj;

            if ((Poseduje_veština.id_veštine == recievedObject.Poseduje_veština.id_veštine) &&
                (Poseduje_akrobate.matični_broj == recievedObject.Poseduje_akrobate.matični_broj))
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


