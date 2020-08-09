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
    public class GradController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<GradPregled> Get()
        {
            IEnumerable<GradPregled> gradovi = DTOManager.Učitaj_informacije_svih_gradova();
            return gradovi;
        }

        // GET api/<controller>/5
        public GradPregled Get(int id)
        {
            GradPregled grad = DTOManager.Učitaj_grad_po_id(id);
            return grad;
        }

        // POST api/<controller>
        public int Post([FromBody]GradPregled grad)
        {
            if (DTOManager.Dodaj_grad(grad.poštanski_broj, grad.naziv, grad.zemlja, grad.opis))
                return 1;
            return -1;
        }

        // PUT api/<controller>/5
        public int Put(int id, [FromBody]GradPregled grad)
        {
            grad.poštanski_broj = id;
            if (DTOManager.Izmeni_grad(grad))
                return 1;
            return -1;
        }

        // DELETE api/<controller>/5
        public int Delete(int id)
        {
            if (DTOManager.Obriši_grad(id))
                return 1;
            return -1;
        }
    }
}