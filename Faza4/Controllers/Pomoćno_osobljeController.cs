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
    public class Pomoćno_osobljeController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<PomoćnoOsobljePregled> Get()
        {
            IEnumerable<PomoćnoOsobljePregled> pomoćno_osoblje = DTOManager.Učitaj_informacije_svog_pomoćnog_osoblja();
            return pomoćno_osoblje;
        }

        // GET api/<controller>/5
        public PomoćnoOsobljePregled Get(long id)
        {
            PomoćnoOsobljePregled pomoćno_osoblje = DTOManager.Učitaj_pomoćno_osoblje_po_id(id);
            return pomoćno_osoblje;
        }

        // POST api/<controller>
        public int Post([FromBody]PomoćnoOsobljePregled po)
        {
            if (DTOManager.Dodaj_pomoćno_osoblje(po.matični_broj, po.ime, po.prezime, po.pol, po.datum_rođenja, po.mesto_rođenja))
                return 1;
            return -1;
        }

        // PUT api/<controller>/5
        public int Put(long id, [FromBody]PomoćnoOsobljePregled po)
        {
            po.matični_broj = id;
            if (DTOManager.Izmeni_pomoćno_osoblje(po))
                return 1;
            return -1;
        }

        // DELETE api/<controller>/5
        public int Delete(long id)
        {
            if (DTOManager.Obriši_pomoćno_osoblje(id))
                return 1;
            return -1;
        }
    }
}