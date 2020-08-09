using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cirkus;
using Cirkus.Entiteti;

namespace Faza4.Controllers
{
    public class ŽivotinjeController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ŽivotinjePregled> Get()
        {
            IEnumerable<ŽivotinjePregled> životinje = DTOManager.Učitaj_informacije_svih_životinja();
            return životinje;
        }

        // GET api/<controller>/5
        public ŽivotinjePregled Get(int id)
        {
            ŽivotinjePregled životinja = DTOManager.Učitaj_životinju_po_id(id);
            return životinja;
        }

        // POST api/<controller>
        public int Post([FromBody]ŽivotinjePregled životinja)
        {
            if (DTOManager.Dodaj_životinju(životinja.broj_kaveza, životinja.nadimak, životinja.težina, životinja.pol, životinja.vrsta, životinja.starost, životinja.datum_dolaska, životinja.veterinarski_pregled))
                return 1;
            return -1;
        }

        // PUT api/<controller>/5
        public int Put(int id, [FromBody]ŽivotinjePregled životinja)
        {
            životinja.broj_kaveza = id;
            if (DTOManager.Izmeni_životinju(životinja))
                return 1;
            return -1;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}