using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
#region Predstava
    public class PredstavaPregled
    {
        public virtual int id_predstave { get; set; }
        public virtual int broj_prodatih_karata { get; set; }
        public virtual string vreme_predstave { get; set; }

        public PredstavaPregled()
        {

        }

        //Bez ID-ja
        public PredstavaPregled(int bk, string vp)
        {
            this.broj_prodatih_karata = bk;
            this.vreme_predstave = vp;
        }

        //Sa ID-jem
        public PredstavaPregled(int id, int bk, string vp)
        {
            this.id_predstave = id;
            this.broj_prodatih_karata = bk;
            this.vreme_predstave = vp;
        }

    }
    #endregion

    #region Tačka

    public class TačkaPregled
    {
        public virtual int broj_tačke { get; set; }
        public virtual string naziv_tačke { get; set; }
        public virtual string tip { get; set; }
        public virtual string efekti { get; set; }
        public virtual string uzrast { get; set; }

        public TačkaPregled()
        {

        }

        //Bez ID-ja
        public TačkaPregled(string nt, string t, string e, string u)
        {
            this.naziv_tačke = nt;
            this.tip = t;
            this.efekti = e;
            this.uzrast = u;
        }

        //Sa ID-jem
        public TačkaPregled(int id, string nt, string t, string e, string u)
        {
            this.broj_tačke = id;
            this.naziv_tačke = nt;
            this.tip = t;
            this.efekti = e;
            this.uzrast = u;
        }


    }
    #endregion

    #region Grad

    public class GradPregled
    {
        public virtual int poštanski_broj { get; set; }
        public virtual string naziv { get; set; }
        public virtual string zemlja { get; set; }
        public virtual string opis { get; set; }

        public GradPregled()
        {

        }

        //Bez ID-ja
        public GradPregled(string n, string z, string o)
        {
            this.naziv = n;
            this.zemlja = z;
            this.opis = o;
        }

        //Sa ID-jem
        public GradPregled(int pb, string n, string z, string o)
        {
            this.poštanski_broj = pb;
            this.naziv = n;
            this.zemlja = z;
            this.opis = o;
        }


    }
    #endregion

    #region Pomoćno osoblje

    public class PomoćnoOsobljePregled
    {
        public virtual long matični_broj { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual char pol { get; set; }
        public virtual DateTime datum_rođenja { get; set; }
        public virtual string mesto_rođenja { get; set; }



        public PomoćnoOsobljePregled()
        {

        }

        //Bez ID-ja
        public PomoćnoOsobljePregled(string i, string p, char pol, DateTime dr, string mr)
        {
            this.ime = i;
            this.prezime = p;
            this.pol = pol;
            this.datum_rođenja = dr;
            this.mesto_rođenja = mr;

        }

        //Sa ID-jem
        public PomoćnoOsobljePregled(long mb, string i, string p, char pol, DateTime dr, string mr)
        {
            this.matični_broj = mb;
            this.ime = i;
            this.prezime = p;
            this.pol = pol;
            this.datum_rođenja = dr;
            this.mesto_rođenja = mr;

        }


    }
    #endregion

    #region Životinje
    public class ŽivotinjePregled
    {
        public virtual int broj_kaveza { get; set; }
        public virtual string nadimak { get; set; }
        public virtual float težina { get; set; }
        public virtual char pol { get; set; }
        public virtual string vrsta { get; set; }
        public virtual string starost { get; set; }
        public virtual DateTime datum_dolaska { get; set; }
        public virtual DateTime veterinarski_pregled { get; set; }


        public ŽivotinjePregled()
        {

        }

        //Bez ID-ja
        public ŽivotinjePregled(DateTime datum_dolaska, string nadimak, float težina, char pol, string vrsta, string starost, DateTime veterinarski_pregled)
        {
            this.nadimak = nadimak;
            this.težina = težina;
            this.pol = pol;
            this.vrsta = vrsta;
            this.starost = starost;
            this.datum_dolaska = datum_dolaska;
            this.veterinarski_pregled = veterinarski_pregled;
        }

        //Sa ID-jem
        public ŽivotinjePregled(DateTime datum_dolaska, string nadimak, float težina, char pol, int broj_kaveza, string vrsta, string starost, DateTime veterinarski_pregled)
        {
            this.broj_kaveza=broj_kaveza;
            this.nadimak = nadimak;
            this.težina = težina;
            this.pol = pol;
            this.vrsta = vrsta;
            this.starost = starost;
            this.datum_dolaska = datum_dolaska;
            this.veterinarski_pregled = veterinarski_pregled;
        }


    }
    #endregion

    //#region Dreseri
    //public class DreseriPregled : ArtistiPregled
    //{
    //    public DreseriPregled()
    //    {
    //        ArtistiPregled dreser = new ArtistiPregled();
    //    }

    //}
    //#endregion

    #region Artisti
    public class ArtistiPregled
    {
        public virtual long matični_broj { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual string ime_roditelja { get; set; }
        public virtual string nadimak { get; set; }
        public virtual DateTime datum_rođenja { get; set; }
        public virtual string mesto_rođenja { get; set; }
        public virtual char pol { get; set; }
        public virtual string asistenti { get; set; }
        public virtual DateTime datum_dolaska { get; set; }


        public ArtistiPregled()
        {

        }

        //Bez ID-ja
        public ArtistiPregled(string i, string p, string ir, string n, DateTime dr, string mr, char pol, string a, DateTime dd)
        {
            this.ime = i;
            this.prezime = p;
            this.pol = pol;
            this.datum_rođenja = dr;
            this.mesto_rođenja = mr;
            this.ime_roditelja = ir;
            this.nadimak = n;
            this.asistenti = a;
            this.datum_dolaska = dd;
        }

        //Sa ID-jem
        public ArtistiPregled(long mb, string i, string p, string ir, string n, DateTime dr, string mr, char pol, string a, DateTime dd)
        {
            this.matični_broj = mb;
            this.ime = i;
            this.prezime = p;
            this.pol = pol;
            this.datum_rođenja = dr;
            this.mesto_rođenja = mr;
            this.ime_roditelja = ir;
            this.nadimak = n;
            this.asistenti = a;
            this.datum_dolaska = dd;

        }

    }
    #endregion
}
