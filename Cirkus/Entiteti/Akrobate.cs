using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Akrobate : Artisti
    {
        public virtual IList<Veština> Veštine { get; set; }
        public virtual IList<Poseduje> Poseduje_akrobate { get; set; }
       

        public Akrobate()
        {
            Veštine = new List<Veština>();
            Poseduje_akrobate = new List<Poseduje>();
        }

    }
    
}