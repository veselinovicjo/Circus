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
    public class Cirkuska_predstavaController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<PredstavaPregled> Get()
        {
            IEnumerable<PredstavaPregled> predstave = DTOManager.Učitaj_informacije_svih_predstava();
            return predstave;
        }

        // GET api/<controller>/5
        public PredstavaPregled Get(int id)
        {
            PredstavaPregled predstava = DTOManager.Učitaj_predstavu_po_id(id);
            return predstava;
        }

        // POST api/<controller>
        public int Post([FromBody]PredstavaPregled predstava)
        {
            if (DTOManager.Dodaj_predstavu(predstava.broj_prodatih_karata, predstava.vreme_predstave))
                return 1;
            return -1;

        }

        // PUT api/<controller>/5
        public int Put(int id, [FromBody]PredstavaPregled predstava)
        {
            predstava.id_predstave = id;
            if (DTOManager.Izmeni_predstavu(predstava))
                return 1;
            return -1;
        }

        // DELETE api/<controller>/5
        public int Delete(int id)
        {
            if (DTOManager.Obriši_predstavu(id))
                return 1;
            return -1;
        }
    }
}