using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Veština
    {
        public virtual int id_veštine { get; set; }
        public virtual string naziv { get; set; }
        public virtual int broj_godina_iskustva { get; set; }

        public virtual Akrobate Akrobata { get; set; }
        public virtual IList<Poseduje> Poseduje_veština { get; set; }

        public Veština()
        {
            Poseduje_veština = new List<Poseduje>();
        }


    }
}
