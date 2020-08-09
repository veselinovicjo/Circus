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
    public class Cirkuska_tačkaController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<TačkaPregled> Get()
        {
            IEnumerable<TačkaPregled> tačke = DTOManager.Učitaj_informacije_svih_tačaka();
            return tačke;
        }

        // GET api/<controller>/5
        public TačkaPregled Get(int id)
        {
            TačkaPregled tačka = DTOManager.Učitaj_tačku_po_id(id);
            return tačka;
        }

        // POST api/<controller>
        public int Post([FromBody]TačkaPregled tačka)
        {
            if (DTOManager.Dodaj_tačku(tačka.naziv_tačke, tačka.tip, tačka.efekti, tačka.uzrast))
                return 1;
            return -1;
        }

        // PUT api/<controller>/5
        public int Put(int id, [FromBody]TačkaPregled tačka)
        {
            tačka.broj_tačke = id;
            if (DTOManager.Izmeni_tačku(tačka))
                return 1;
            return -1;
        }

        // DELETE api/<controller>/5
        public int Delete(int id)
        {
            if (DTOManager.Obriši_tačku(id))
                return 1;
            return -1;
        }
    }
}