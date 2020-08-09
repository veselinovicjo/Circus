using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus.Entiteti
{
    public class Humanitarna : Specijalna
    {
        public virtual int prihod { get; set; }
        public virtual string namena { get; set; }

        public Humanitarna()
        {

        }
    }
}
