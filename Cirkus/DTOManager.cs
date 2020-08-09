using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cirkus.Entiteti;
using NHibernate;
using NHibernate.Linq;

namespace Cirkus
{
    public class DTOManager
    {
        #region Predstava

        public static List<PredstavaPregled> Učitaj_informacije_svih_predstava()
        {
            List<PredstavaPregled> lista_predstava_info = new List<PredstavaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Cirkuska_predstava");
                IList<Cirkuska_predstava> predstave = s.Query<Cirkuska_predstava>().ToList();
                foreach (Cirkuska_predstava cp in predstave)
                {
                    lista_predstava_info.Add(new PredstavaPregled(cp.id_predstave, cp.broj_prodatih_karata, cp.vreme_predstave));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspešno učitavanje predstava");
                MessageBox.Show(ec.Message);
            }

            return lista_predstava_info;
        }

        public static PredstavaPregled Učitaj_predstavu_po_id(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Cirkuska_predstava cp = s.Load<Cirkuska_predstava>(id);
                PredstavaPregled predstava_ret = new PredstavaPregled(cp.broj_prodatih_karata, cp.vreme_predstave);
                s.Close();
                return predstava_ret;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public static IList<Cirkuska_tačka> Učitaj_sve_tačke_za_predstavu(int id, ISession sesija)
        {
            try
            {

                try
                {

                    Cirkuska_predstava predstava = sesija.Load<Cirkuska_predstava>(id);
                    return predstava.Tačke;

                }
                catch (Exception ec)
                {
                    return null;
                }

            }
            catch (Exception ec)
            {
                return null;
            }
        }

        private static void Setuj_propertije_predstave(Cirkuska_predstava predstava, int broj_prodatih_karata, string vreme_predstave)
        {
            predstava.vreme_predstave = vreme_predstave;
            predstava.broj_prodatih_karata = broj_prodatih_karata;
        }

        //private static void Setuj_vezu_sastoji_se(Sastoji_se sastoji_se, int id_predstave, int broj_tačke)
        //{
        //    sastoji_se.Sastoji_se_predstava.id_predstave = id_predstave;
        //    sastoji_se.Sastoji_se_tačka.broj_tačke = broj_tačke;
        //}

        //private static void Setuj_vezu_izvodi_se(Izvodi_se izvodi_se, int id_predstave, DateTime Od, DateTime Do)
        //{
        //    izvodi_se.Id.Predstava_u_gradu.id_predstave = id_predstave;
        //    izvodi_se.Od = Od;
        //    izvodi_se.Do = Do;
        //}


        public static bool Dodaj_predstavu(int broj_prodatih_karata, string vreme_predstave)
        {
            Cirkuska_predstava predstava = new Cirkuska_predstava();
            Setuj_propertije_predstave(predstava, broj_prodatih_karata, vreme_predstave);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(predstava);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }

        public static bool Dodaj_predstavu(int broj_prodatih_karata, string vreme_predstave, int[] tačke, int[] gradovi, DateTime Od, DateTime Do)
        {
            Cirkuska_predstava predstava = new Cirkuska_predstava();
            Setuj_propertije_predstave(predstava, broj_prodatih_karata, vreme_predstave);
            Sastoji_se sastoji_se = new Sastoji_se();
            Izvodi_se izvodi_se = new Izvodi_se();

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(predstava);
                s.Flush();

                int id_predstave = predstava.id_predstave;
                Cirkuska_predstava cp = s.Load<Cirkuska_predstava>(id_predstave);
                
                foreach (int t in tačke)
                {
                    Entiteti.Cirkuska_tačka ct = s.Load<Entiteti.Cirkuska_tačka>(t);

                    Sastoji_se ss = new Sastoji_se();
                    ss.Sastoji_se_predstava = cp;
                    ss.Sastoji_se_tačka = ct;

                    s.Save(ss);
                    s.Update(predstava);
                }
                s.Flush();


                // Setuj_vezu_izvodi_se
                foreach (int grad in gradovi)
                {
                    Entiteti.Grad g = s.Load<Entiteti.Grad>(grad);

                    Izvodi_se iz = new Izvodi_se();
                    iz.Id.Predstava_u_gradu = cp;
                    iz.Id.Izvodi_se_u = g;
                    iz.Od = Od;
                    iz.Do = Do;

                    s.Save(iz);
                }
                s.Flush();               
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;

        }

        public static bool Izmeni_predstavu(PredstavaPregled predstava)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                Cirkuska_predstava učitana_predstava = s.Load<Cirkuska_predstava>(predstava.id_predstave);

                Setuj_propertije_predstave(učitana_predstava, predstava.broj_prodatih_karata, predstava.vreme_predstave);

                // sesija = DataLayer.GetSession();
                s.Update(učitana_predstava);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }

        public static bool Izmeni_predstavu(PredstavaPregled predstava, int[] tačke, int[] gradovi, DateTime Od, DateTime Do)
        {
            // TODO videti zasto kad se otvori sesija po drugi put puca kod
            // Napomena: kad se prolazi kroz debager sve je u redu,
            // kad se pokrene kod na izvrsavanje regularno puca.
            try
            {
                ISession s = DataLayer.GetSession();
                Cirkuska_predstava učitana_predstava = s.Load<Cirkuska_predstava>(predstava.id_predstave);
                Sastoji_se sastoji_se = new Sastoji_se();
                Izvodi_se izvodi_se = new Izvodi_se();

                Setuj_propertije_predstave(učitana_predstava, predstava.broj_prodatih_karata, predstava.vreme_predstave);

                foreach (int t in tačke)
                {
                    Entiteti.Cirkuska_tačka ct = s.Load<Entiteti.Cirkuska_tačka>(t);

                    Sastoji_se ss = new Sastoji_se();
                    ss.Sastoji_se_predstava = učitana_predstava;
                    ss.Sastoji_se_tačka = ct;

                    s.Save(ss);
                    s.Update(učitana_predstava);
                }
                s.Flush();


                // Setuj_vezu_izvodi_se
                foreach (int grad in gradovi)
                {
                    Entiteti.Grad g = s.Load<Entiteti.Grad>(grad);

                    Izvodi_se iz = new Izvodi_se();
                    iz.Id.Predstava_u_gradu = učitana_predstava;
                    iz.Id.Izvodi_se_u = g;
                    iz.Od = Od;
                    iz.Do = Do;

                    s.Save(iz);
                    s.Update(učitana_predstava);
                }

                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }

        #region Brisanje predstave
        public static bool Obriši_predstavu(int id)
        {
            try
            {

                ISession sesija = DataLayer.GetSession();

                Cirkuska_predstava predstava = sesija.Load<Cirkuska_predstava>(id);
                IList<Cirkuska_tačka> lista;
                //lista na osnovu koje se kasnije proverava da li tačka pripada nekoj predstavi
                lista = Učitaj_sve_tačke_za_predstavu(id, sesija);
                Brisanje_sastoji_se(predstava);

                Grad grad;
                Grad gr = new Grad();
                for (int i = 0; i < predstava.Gradovi.Count; i++)
                {
                    grad = predstava.Gradovi[i];
                    predstava.Gradovi.RemoveAt(i--);
                    gr.Predstave.Remove(predstava); //bisanje iz Izvodi se
                    predstava.Gradovi.Clear();

                }

                sesija.Update(predstava);
                sesija.Flush();
                //Obriši_povezane_tačke(lista, sesija);
                sesija.Delete(predstava);
                sesija.Flush();


                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }

        private static void Brisanje_sastoji_se(Cirkuska_predstava predstava)
        {

            try
            {

                //Sastoji_se sastoji = new Sastoji_se();
                Cirkuska_tačka tmp;
                Cirkuska_tačka ct = new Cirkuska_tačka();
                //Sastoji_se sastoji = new Sastoji_se();
                for (int i = 0; i < predstava.Tačke.Count; i++)
                {
                    tmp = predstava.Tačke[i];
                    predstava.Tačke.RemoveAt(i--);
                    //sesija.Flush();
                    MessageBox.Show("Cirkuska tačka " + tmp.naziv_tačke + " više ne pripada predstavi");

                    ct.Predstave.Remove(predstava); //brisanje iz Sastoji_se

                    //sesija.Flush();


                }
                predstava.Tačke.Clear();



            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);

            }

        }

        //proverava se da li tačka pripada nekoj predstavi, i ukoliko ne, briše se iz baze
        private static void Obriši_povezane_tačke(IList<Cirkuska_tačka> lista_tačaka, ISession sesija)
        {
            try
            {

                foreach (Cirkuska_tačka t in lista_tačaka)
                {
                    //provera da li tačka pripada nekoj predstavi u bazi
                    //moglo je i iz liste Predstave, ali je iskorišćen LINQ
                    IEnumerable<Sastoji_se> sastoji = from p in sesija.Query<Sastoji_se>()
                                                      where (p.Sastoji_se_tačka.broj_tačke == t.broj_tačke)
                                                      select p;

                    if (sastoji.Count() == 0)
                    {
                        DialogResult result = MessageBox.Show("Brisanjem ove predstave, tačka će biti obrisana: " + t.naziv_tačke + "Da li želite da nastavite?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            Brisanje_zadužuje(t);
                            Brisanje_angažuje(t);

                            sesija.CreateQuery("delete from Cirkuska_tačka s where s.broj_tačke = :broj_tačke")
                            .SetParameter("broj_tačke", t.broj_tačke)
                            .ExecuteUpdate();

                            sesija.Flush();

                            MessageBox.Show("Obrisana je tačka");
                        }
                        else
                        {
                        }




                    }
                    //foreach (Proizvod p in proizvodi)
                    //{
                    //	MessageBox.Show(p.Naziv);
                    //}


                    //for (int i = 0; i < tačke.Predstave.Count; i++)
                    //{
                    //	if (tačke.Predstave[i].Tačke.Count == 1)
                    //	{
                    //		tačke.Predstave[i].Tačke.Clear();
                    //		sesija.Delete(tačke.Predstave[i]);

                    //		tačke.Predstave.RemoveAt(i);
                    //		i--;
                    //	}
                    //}
                }
                sesija.Flush();
            }
            catch (Exception ec)
            {
                //MessageBox.Show(ec.Message);
            }
        }
        #endregion

        #endregion

        #region Tačka

        public static List<TačkaPregled> Učitaj_informacije_svih_tačaka()
        {
            List<TačkaPregled> lista_tačaka_info = new List<TačkaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Cirkuska_tačka> tačke = s.Query<Cirkuska_tačka>().ToList();

                foreach (Cirkuska_tačka ct in tačke)
                {
                    lista_tačaka_info.Add(new TačkaPregled(ct.broj_tačke,ct.naziv_tačke,ct.tip,ct.efekti,ct.uzrast));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista_tačaka_info;
        }
        private static void Setuj_propertije_tačke(Cirkuska_tačka tačka, string naziv_tačke, string tip, string efekti, string uzrast)
        {
            tačka.naziv_tačke = naziv_tačke;
            tačka.tip = tip;
            if (efekti == "nema")
            {
                tačka.efekti = null;
            }
            else
            {
                tačka.efekti = efekti;
            }
            tačka.uzrast = uzrast;
        }

        public static TačkaPregled Učitaj_tačku_po_id(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Cirkuska_tačka ct = s.Load<Cirkuska_tačka>(id);
                TačkaPregled tačka_ret = new TačkaPregled(ct.naziv_tačke, ct.tip, ct.efekti, ct.uzrast);
                s.Close();
                return tačka_ret;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public static bool Dodaj_tačku(string naziv_tačke, string tip, string efekti, string uzrast)
        {
            Cirkuska_tačka tačka = new Cirkuska_tačka();
            Setuj_propertije_tačke(tačka, naziv_tačke, tip, efekti, uzrast);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(tačka);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }

        public static bool Izmeni_tačku(TačkaPregled tačka)
        {
            // TODO videti zasto kad se otvori sesija po drugi put puca kod
            // Napomena: kad se prolazi kroz debager sve je u redu,
            // kad se pokrene kod na izvrsavanje regularno puca.
            try
            {
                ISession sesija = DataLayer.GetSession();
                Cirkuska_tačka učitana_tačka = sesija.Load<Cirkuska_tačka>(tačka.broj_tačke);
                // sesija.Close();

                Setuj_propertije_tačke(učitana_tačka, tačka.naziv_tačke, tačka.tip, tačka.efekti, tačka.uzrast);

                // sesija = DataLayer.GetSession();
                sesija.Update(učitana_tačka);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }
        public static IList<Cirkuska_predstava> Učitaj_sve_predstave_u_kojima_se_izvodi_tačka(int id, ISession sesija)
        {
            try
            {

                Cirkuska_tačka tačka = sesija.Load<Cirkuska_tačka>(id);
                //PredstavaPregled predstava_ret = new PredstavaPregled(predstava.id_predstave, predstava.broj_prodatih_karata, predstava.vreme_predstave);
                return tačka.Predstave;

            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public static IList<Pomoćno_osoblje> Učitaj_svo_pomoćno_osoblje(int id, ISession sesija)
        {
            try
            {

                Cirkuska_tačka tačka = sesija.Load<Cirkuska_tačka>(id);
                //PredstavaPregled predstava_ret = new PredstavaPregled(predstava.id_predstave, predstava.broj_prodatih_karata, predstava.vreme_predstave);
                return tačka.Osoblje;

            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public static IList<Artisti> Učitaj_sve_artiste(int id, ISession sesija)
        {
            try
            {

                Cirkuska_tačka tačka = sesija.Load<Cirkuska_tačka>(id);
                //PredstavaPregled predstava_ret = new PredstavaPregled(predstava.id_predstave, predstava.broj_prodatih_karata, predstava.vreme_predstave);
                return tačka.Artist;

            }
            catch (Exception ec)
            {
                return null;
            }
        }
        #region BrisanjeTačke
        public static bool Obriši_tačku(int broj_tačke)
        {
            try
            {
                IList<Cirkuska_predstava> lista_predstava;
                IList<Pomoćno_osoblje> lista_osoblja;
                IList<Artisti> lista_artista;
                ISession sesija = DataLayer.GetSession();

                Cirkuska_tačka tačka = sesija.Load<Cirkuska_tačka>(broj_tačke);
                lista_predstava = Učitaj_sve_predstave_u_kojima_se_izvodi_tačka(broj_tačke, sesija);
                lista_osoblja = Učitaj_svo_pomoćno_osoblje(broj_tačke, sesija);
                lista_artista = Učitaj_sve_artiste(broj_tačke, sesija);

                ITransaction t = sesija.BeginTransaction();
                //lista na osnovu koje se kasnije proverava da li tačka pripada nekoj predstavi
                //lista_tačaka = Učitaj_sve_tačke_za_predstavu(id, sesija);
                Brisanje_sastoji_se_tačke(tačka);
                Brisanje_zadužuje(tačka);
                Brisanje_angažuje(tačka);

                sesija.Flush();
                sesija.Delete(tačka);
                t.Commit();
                //sesija.Update(tačka);
                //sesija.Flush();

                //sesija.Delete(tačka);
                //sesija.Flush();

                //Obriši_povezane_tačke(lista_tačaka, sesija);
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }

        private static void Brisanje_sastoji_se_tačke(Cirkuska_tačka tačka)
        {

            try
            {

                //Sastoji_se sastoji = new Sastoji_se();
                Cirkuska_predstava tmp;
                Cirkuska_predstava cp = new Cirkuska_predstava();
                //Sastoji_se sastoji = new Sastoji_se();
                for (int i = 0; i < tačka.Predstave.Count; i++)
                {
                    tmp = tačka.Predstave[i];
                    tačka.Predstave.RemoveAt(i--);
                    //sesija.Flush();
                    MessageBox.Show("Cirkuska predstava sa ID-em:  " + tmp.id_predstave + " više ne pripada tački");

                    cp.Tačke.Remove(tačka); 

                    //sesija.Flush();


                }
                tačka.Predstave.Clear();


            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);

            }

        }

        private static void Brisanje_angažuje(Cirkuska_tačka tačka)
        {

            try
            {

                Artisti tmp;
                Artisti ar = new Artisti();
                for (int i = 0; i < tačka.Artist.Count; i++)
                {
                    tmp = tačka.Artist[i];
                    tačka.Artist.RemoveAt(i--);
                    //sesija.Flush();
                    MessageBox.Show("Artista " + tmp.nadimak + " više nije angažovan na tački");

                    //ar.Tačka.; //brisanje iz Sastoji_se

                    //sesija.Flush();
                }
                tačka.Artist.Clear();

            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);

            }

        }

        private static void Brisanje_zadužuje(Cirkuska_tačka tačka)
        {

            try
            {

                //Sastoji_se sastoji = new Sastoji_se();
                Pomoćno_osoblje tmp;
                Pomoćno_osoblje cp = new Pomoćno_osoblje();
                //Sastoji_se sastoji = new Sastoji_se();
                for (int i = 0; i < tačka.Osoblje.Count; i++)
                {
                    tmp = tačka.Osoblje[i];
                    tačka.Osoblje.RemoveAt(i--);
                    //sesija.Flush();
                    MessageBox.Show("Osoba:  " + tmp.ime + " više nije zadužena na tački");

                    cp.Tačke.Remove(tačka); //brisanje iz Sastoji_se

                    //sesija.Flush();


                }
                tačka.Osoblje.Clear();

            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);

            }

        }
        #endregion
        #endregion

        #region Grad

        public static List<GradPregled> Učitaj_informacije_svih_gradova()
        {
            List<GradPregled> lista_gradova_info = new List<GradPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Grad> gradovi = s.Query<Grad>().ToList();

                foreach (Grad g in gradovi)
                {
                    lista_gradova_info.Add(new GradPregled(g.poštanski_broj, g.naziv, g.zemlja, g.opis));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista_gradova_info;
        }
        public static GradPregled Učitaj_grad_po_id(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Grad grad = s.Load<Grad>(id);
                GradPregled grad_ret = new GradPregled(grad.poštanski_broj, grad.naziv, grad.zemlja, grad.opis);
                s.Close();
                return grad_ret;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public static IList<Cirkuska_predstava> Učitaj_predstave_koje_pripadaju_gradu(int poštanski_broj, ISession sesija)
        {
            try
            {


                Grad grad = sesija.Load<Grad>(poštanski_broj);
                //PredstavaPregled predstava_ret = new PredstavaPregled(predstava.id_predstave, predstava.broj_prodatih_karata, predstava.vreme_predstave);
                return grad.Predstave;

            }
            catch (Exception ec)
            {
                return null;
            }
        }

        private static void Setuj_propertije_grada(Grad grad, int poštanski_broj, string naziv, string zemlja, string opis)
        {
            grad.poštanski_broj = poštanski_broj;
            grad.naziv = naziv;
            grad.zemlja = zemlja;
            grad.opis = opis;
        }

        public static bool Dodaj_grad(int poštanski_broj, string naziv, string zemlja, string opis)
        {
            Grad grad = new Grad();
            Setuj_propertije_grada(grad, poštanski_broj, naziv, zemlja, opis);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(grad);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }

        public static bool Izmeni_grad(GradPregled grad)
        {
            // TODO videti zasto kad se otvori sesija po drugi put puca kod
            // Napomena: kad se prolazi kroz debager sve je u redu,
            // kad se pokrene kod na izvrsavanje regularno puca.
            try
            {
                ISession sesija = DataLayer.GetSession();
                Grad učitani_grad = sesija.Load<Grad>(grad.poštanski_broj);
                // sesija.Close();

                Setuj_propertije_grada(učitani_grad, grad.poštanski_broj, grad.naziv, grad.zemlja, grad.opis);

                // sesija = DataLayer.GetSession();
                sesija.Update(učitani_grad);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }
        #region obriši_grad
        public static bool Obriši_grad(int poštanski_broj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Grad grad = sesija.Load<Grad>(poštanski_broj);
                IList<Cirkuska_predstava> predstave_u_gradu;
                predstave_u_gradu = Učitaj_predstave_koje_pripadaju_gradu(poštanski_broj, sesija);
                Obriši_iz_izvodi_se(grad, sesija);
                Ukloni_grad(grad, sesija);
                //sesija.Update(predstava);
                //sesija.Flush();

                //sesija.Delete(predstava);


                sesija.Flush();
                Proveri_cirkuske_predstave(predstave_u_gradu, sesija);
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }

        private static void Obriši_iz_izvodi_se(Grad grad, ISession sesija)
        {

            Cirkuska_predstava predstava;

            Cirkuska_predstava pred = new Cirkuska_predstava();

            for (int i = 0; i < grad.Predstave.Count; i++)
            {
                predstava = grad.Predstave[i];
                grad.Predstave.RemoveAt(i--);
                //sesija.Flush();
                //Kaskadno_brisanje_tačke(tmp, predstava, sesija);

                pred.Gradovi.Remove(grad); //bisanje iz Izvodi se


            }
            pred.Gradovi.Clear();
            //sesija.Flush();
        }

        private static void Ukloni_grad(Grad grad, ISession sesija)
        {
            try
            {

                //Sastoji_se sastoji = new Sastoji_se();
                //Cirkuska_tačka ct = new Cirkuska_tačka();
                //Cirkuska_predstava cp = new Cirkuska_predstava();
                //if (!cp.Tačke.Contains(tačke))
                //{
                sesija.CreateQuery("delete from Grad g where g.poštanski_broj = :poštanski_broj")
                .SetParameter("poštanski_broj", grad.poštanski_broj)
                .ExecuteUpdate();
                //}

                //for (int i = 0; i < tačke.Predstave.Count; i++)
                //{
                //	if (tačke.Predstave[i].Tačke.Count == 1)
                //	{
                //		tačke.Predstave[i].Tačke.Clear();
                //		sesija.Delete(tačke.Predstave[i]);

                //		tačke.Predstave.RemoveAt(i);
                //		i--;
                //	}
                //}

                sesija.Flush();
            }
            catch (Exception ec)
            {
                //MessageBox.Show(ec.Message);
            }

        }
        private static void Proveri_cirkuske_predstave(IList<Cirkuska_predstava> lista_predstava, ISession sesija)
        {
            try
            {

                foreach (Cirkuska_predstava t in lista_predstava)
                {
                    //provera da li tačka pripada nekoj predstavi u bazi
                    //moglo je i iz liste Predstave, ali je iskorišćen LINQ
                    IEnumerable<Izvodi_se> izvodi = from p in sesija.Query<Izvodi_se>()
                                                    where (p.Id.Predstava_u_gradu.id_predstave == t.id_predstave)
                                                    select p;

                    if (izvodi.Count() == 0)
                    {
                        DialogResult result = MessageBox.Show("Brisanjem ovog grada, predstava će biti obrisana: " + t.id_predstave, "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            sesija.CreateQuery("delete from Cirkuska_predstava s where s.id_predstave = :id_predstave")
                            .SetParameter("id_predstave", t.id_predstave)
                            .ExecuteUpdate();

                            sesija.Flush();

                            MessageBox.Show("Obrisana je predstava");
                        }
                        else
                        {
                        }



                    }
                    //foreach (Proizvod p in proizvodi)
                    //{
                    //	MessageBox.Show(p.Naziv);
                    //}


                    //for (int i = 0; i < tačke.Predstave.Count; i++)
                    //{
                    //	if (tačke.Predstave[i].Tačke.Count == 1)
                    //	{
                    //		tačke.Predstave[i].Tačke.Clear();
                    //		sesija.Delete(tačke.Predstave[i]);

                    //		tačke.Predstave.RemoveAt(i);
                    //		i--;
                    //	}
                    //}
                }
                //sesija.Flush();
            }
            catch (Exception ec)
            {
                //MessageBox.Show(ec.Message);
            }
        }

        #endregion
        #endregion

        #region Pomoćno osoblje

        public static List<PomoćnoOsobljePregled> Učitaj_informacije_svog_pomoćnog_osoblja()
        {
            List<PomoćnoOsobljePregled> lista_pomoćnog_osoblja_info = new List<PomoćnoOsobljePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Pomoćno_osoblje> pomoćno_osoblje = s.Query<Pomoćno_osoblje>().ToList();

                foreach (Pomoćno_osoblje po in pomoćno_osoblje)
                {
                    lista_pomoćnog_osoblja_info.Add(new PomoćnoOsobljePregled(po.matični_broj, po.ime, po.prezime, po.pol, po.datum_rođenja, po.mesto_rođenja));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista_pomoćnog_osoblja_info;
        }

        public static PomoćnoOsobljePregled Učitaj_pomoćno_osoblje_po_id(long id)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Pomoćno_osoblje po = s.Load<Pomoćno_osoblje>(id);
                PomoćnoOsobljePregled pomoćno_osoblje_ret = new PomoćnoOsobljePregled(po.matični_broj, po.ime, po.prezime, po.pol, po.datum_rođenja, po.mesto_rođenja);
                s.Close();
                return pomoćno_osoblje_ret;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        private static void Setuj_propertije_pomoćnog_osoblja(Pomoćno_osoblje po, long matični_broj, string ime, string prezime, char pol, DateTime datum_rođenja, string mesto_rođenja)
        {
            po.matični_broj = matični_broj;
            po.ime = ime;
            po.prezime = prezime;
            po.pol = pol;
            po.datum_rođenja = datum_rođenja;
            po.mesto_rođenja = mesto_rođenja;
        }

        public static bool Dodaj_pomoćno_osoblje(long matični_broj, string ime, string prezime, char pol, DateTime datum_rođenja, string mesto_rođenja)
        {
            Pomoćno_osoblje pomoćno_osoblje = new Pomoćno_osoblje();
            Setuj_propertije_pomoćnog_osoblja(pomoćno_osoblje, matični_broj, ime, prezime, pol, datum_rođenja, mesto_rođenja);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(pomoćno_osoblje);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }

        public static bool Izmeni_pomoćno_osoblje(PomoćnoOsobljePregled pomoćno_osoblje)
        {
            // TODO videti zasto kad se otvori sesija po drugi put puca kod
            // Napomena: kad se prolazi kroz debager sve je u redu,
            // kad se pokrene kod na izvrsavanje regularno puca.
            try
            {
                ISession sesija = DataLayer.GetSession();
                Pomoćno_osoblje učitano_pomoćno_osoblje = sesija.Load<Pomoćno_osoblje>(pomoćno_osoblje.matični_broj);
                // sesija.Close();

                Setuj_propertije_pomoćnog_osoblja(učitano_pomoćno_osoblje, pomoćno_osoblje.matični_broj, pomoćno_osoblje.ime, pomoćno_osoblje.prezime, pomoćno_osoblje.pol, pomoćno_osoblje.datum_rođenja, pomoćno_osoblje.mesto_rođenja);

                // sesija = DataLayer.GetSession();
                sesija.Update(učitano_pomoćno_osoblje);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }
        public static IList<Cirkuska_tačka> Učitaj_sve_tačke_koje_zadužuju_osoblje(long id, ISession sesija)
        {
            try
            {

                Pomoćno_osoblje osoblje = sesija.Load<Pomoćno_osoblje>(id);
                return osoblje.Tačke;

            }
            catch (Exception ec)
            {
                return null;
            }
        }
        #region Brisanje Pomoćnog osoblja

        public static bool Obriši_pomoćno_osoblje(long matični_broj)
        {
            try
            {
                IList<Cirkuska_tačka> lista_tačaka;
                ISession sesija = DataLayer.GetSession();

                Pomoćno_osoblje osoblje = sesija.Load<Pomoćno_osoblje>(matični_broj);
                lista_tačaka = Učitaj_sve_tačke_koje_zadužuju_osoblje(matični_broj, sesija);

                ITransaction t = sesija.BeginTransaction();
                Brisanje_zadužuje(osoblje);

                sesija.Update(osoblje);
                sesija.Flush();
                sesija.Delete(osoblje);
                t.Commit();

                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return false;
            }
        }


        private static void Brisanje_zadužuje(Pomoćno_osoblje osoblje)
        {

            try
            {

                Cirkuska_tačka tmp;
                Cirkuska_tačka po = new Cirkuska_tačka();
                for (int i = 0; i < osoblje.Tačke.Count; i++)
                {
                    tmp = osoblje.Tačke[i];
                    osoblje.Tačke.RemoveAt(i--);
                    //sesija.Flush();


                    po.Osoblje.Remove(osoblje); //brisanje iz Sastoji_se
                    MessageBox.Show("Cirkuska tačka " + tmp.broj_tačke + " više ne zadužuje artistu");
                    //sesija.Flush();
                }
                osoblje.Tačke.Clear();

            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);

            }

        }



        #endregion  

        #endregion

        #region Životinje

        public static List<ŽivotinjePregled> Učitaj_informacije_svih_životinja()
        {
            List<ŽivotinjePregled> lista_životinja_info = new List<ŽivotinjePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Životinje");

                IList<Životinje> životinje = s.Query<Životinje>().ToList();

                foreach (Životinje ž in životinje)
                {
                    lista_životinja_info.Add(new ŽivotinjePregled(ž.datum_dolaska, ž.nadimak, ž.težina, ž.pol, ž.broj_kaveza, ž.vrsta, ž.starost, ž.veterinarski_pregled));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista_životinja_info;
        }
        public static ŽivotinjePregled Učitaj_životinju_po_id(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Životinje ž = s.Load<Životinje>(id);
                ŽivotinjePregled životinja_ret = new ŽivotinjePregled(ž.datum_dolaska, ž.nadimak, ž.težina, ž.pol, ž.broj_kaveza, ž.vrsta, ž.starost, ž.veterinarski_pregled);
                s.Close();
                return životinja_ret;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        private static void Setuj_propertije_životinje(Životinje životinja, int broj_kaveza, string nadimak, float težina, char pol, string vrsta, string starost, DateTime datum_dolaska, DateTime veterinarski_pregled)
        {
            životinja.broj_kaveza = broj_kaveza;
            životinja.nadimak = nadimak;
            životinja.težina = težina;
            životinja.pol = pol;
            životinja.vrsta = vrsta;
            životinja.starost = starost;
            životinja.datum_dolaska = datum_dolaska;
            životinja.veterinarski_pregled = veterinarski_pregled;
        }

        public static bool Dodaj_životinju(int broj_kaveza, string nadimak, float težina, char pol, string vrsta, string starost, DateTime datum_dolaska, DateTime veterinarski_pregled)
        {
            Životinje životinja = new global::Cirkus.Entiteti.Životinje();
            Setuj_propertije_životinje(životinja, broj_kaveza, nadimak, težina, pol, vrsta, starost, datum_dolaska, veterinarski_pregled);

            //TODO veza Dreser
            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(životinja);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }

        public static bool Izmeni_životinju(ŽivotinjePregled ž)
        {
            // TODO videti zasto kad se otvori sesija po drugi put puca kod
            // Napomena: kad se prolazi kroz debager sve je u redu,
            // kad se pokrene kod na izvrsavanje regularno puca.
            try
            {
                ISession sesija = DataLayer.GetSession();
                Životinje učitana_životinja = sesija.Load<Životinje>(ž.broj_kaveza);
                // sesija.Close();

                Setuj_propertije_životinje(učitana_životinja, ž.broj_kaveza, ž.nadimak, ž.težina, ž.pol, ž.vrsta, ž.starost, ž.datum_dolaska, ž.veterinarski_pregled);

                // sesija = DataLayer.GetSession();
                sesija.Update(učitana_životinja);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }

        #endregion

        #region Artisti

        public static List<ArtistiPregled> Učitaj_informacije_svih_artista()
        {
            List<ArtistiPregled> lista_artista_info = new List<ArtistiPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                //IList<Cirkuska_predstava> predstave = s.Query<Cirkuska_predstava>().ToList();
                IQuery q = s.CreateQuery("Select matični_broj from Artisti");

                IList<Artisti> artisti = q.List<Artisti>();
                foreach (Artisti a in artisti)
                {
                    lista_artista_info.Add(new ArtistiPregled(a.matični_broj, a.ime, a.prezime, a.ime_roditelja, a.nadimak, a.datum_rođenja, a.mesto_rođenja, a.pol, a.asistenti, a.datum_dolaska));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspešno učitavanje artista");
                MessageBox.Show(ec.Message);
            }

            return lista_artista_info;
        }

        public static ArtistiPregled Učitaj_artiste_po_id(long id)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Artisti a = s.Load<Artisti>(id);
                ArtistiPregled artisti_ret = new ArtistiPregled(a.matični_broj, a.ime, a.prezime, a.ime_roditelja, a.nadimak, a.datum_rođenja, a.mesto_rođenja, a.pol, a.asistenti, a.datum_dolaska);
                s.Close();
                return artisti_ret;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        private static void Setuj_propertije_artista(Artisti a, long matični_broj, string ime, string prezime, string ime_roditelja, string nadimak, DateTime datum_rođenja, string mesto_rođenja, char pol, string asistenti, DateTime datum_dolaska)
        {
            a.matični_broj = matični_broj;
            a.ime = ime;
            a.prezime = prezime;
            a.pol = pol;
            a.datum_rođenja = datum_rođenja;
            a.mesto_rođenja = mesto_rođenja;
            a.ime_roditelja = ime_roditelja;
            a.nadimak = nadimak;
            a.asistenti = asistenti;
            a.datum_dolaska = datum_dolaska;
        }

        public static bool Dodaj_artistu(long matični_broj, string ime, string prezime, string ime_roditelja, string nadimak, DateTime datum_rođenja, string mesto_rođenja, char pol, string asistenti, DateTime datum_dolaska)
        {
            Artisti artisti = new Artisti();
            Setuj_propertije_artista(artisti, matični_broj, ime, prezime, ime_roditelja, nadimak, datum_rođenja, mesto_rođenja, pol, asistenti, datum_dolaska);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(artisti);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //TODO handle
                return false;
            }
            return true;
        }

        public static bool Izmeni_artiste(ArtistiPregled artisti)
        {

            try
            {
                ISession sesija = DataLayer.GetSession();
                Artisti učitani_artisti = sesija.Load<Artisti>(artisti.matični_broj);
                // sesija.Close();

                Setuj_propertije_artista(učitani_artisti, artisti.matični_broj, artisti.ime, artisti.prezime, artisti.ime_roditelja, artisti.nadimak, artisti.datum_rođenja, artisti.mesto_rođenja, artisti.pol, artisti.asistenti, artisti.datum_dolaska);

                // sesija = DataLayer.GetSession();
                sesija.Update(učitani_artisti);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }

        #endregion

        #region Transakcije
        #endregion

    }
}
