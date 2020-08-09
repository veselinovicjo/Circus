using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Cirkus.Entiteti;
using NHibernate.Criterion;
using NHibernate.Linq;
using Cirkus.Forme;

namespace Cirkus
{
    public partial class Cirkus : Form
    {
        public Cirkus()
        {
            InitializeComponent();
        }

        private void Btn_učitaj_predstavu_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                Cirkuska_predstava p = s.Load<Cirkuska_predstava>(2);
                MessageBox.Show("Cirkuska predstava sa id-em: " + p.id_predstave.ToString() + " se održava " + p.vreme_predstave.ToString() + ". Broj prodatih karata je " + p.broj_prodatih_karata.ToString() + ".");

                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_dodaj_predstavu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Cirkuska_predstava p = new Entiteti.Cirkuska_predstava();


                p.broj_prodatih_karata = 39;
                p.vreme_predstave = "11:29h";

                s.SaveOrUpdate(p);

                s.Flush();
                MessageBox.Show("Dodata je predstava sa ID-em: " + p.id_predstave);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_Specijalna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Specijalna sp = new Specijalna()
                {
                    broj_prodatih_karata = 555,
                    vreme_predstave = "10:30h",

                };

                s.Save(sp);


                s.Flush();

                MessageBox.Show("Uspesno kreirana predstava");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_Humanitarna_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Humanitarna h = new Humanitarna()
                {
                    broj_prodatih_karata = 125,
                    vreme_predstave = "11:30h",
                    namena = "Nurdor",
                    prihod = 15000,

                };


                s.Save(h);
                s.Flush();

                MessageBox.Show("Uspesno kreirana predstava");

				s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e) 
            //many to many
        {
			try
			{
				ISession s = DataLayer.GetSession();

				Pomoćno_osoblje po = s.Load<Pomoćno_osoblje>(987654321022);
				Entiteti.Cirkuska_tačka ct = s.Load<Entiteti.Cirkuska_tačka>(1234);

				ct.Osoblje.Add(po);

				
				foreach (Pomoćno_osoblje pom in ct.Osoblje)
				{
					MessageBox.Show("osoblje: " + pom.ime.ToString() + " " + pom.prezime.ToString() + " \n" + "tacka:");
				}

				s.Close();
			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}

		}

        private void Button2_Click(object sender, EventArgs e)
           
        {
			try
			{
				ISession s = DataLayer.GetSession();

				Cirkuska_predstava cp = s.Load<Cirkuska_predstava>(6);
				Entiteti.Grad g = s.Load<Entiteti.Grad>(18000);

				g.Predstave.Add(cp);
				cp.Gradovi.Add(g);

				Entiteti.Grad g1 = s.Load<Entiteti.Grad>(18220);

				g1.Predstave.Add(cp);
				cp.Gradovi.Add(g1);

				//foreach (Grad gr in cp.Gradovi)
				//{
				//	MessageBox.Show(gr.naziv.ToString());
				//}

				s.Flush();
				s.Close();



			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

        private void Button3_Click(object sender, EventArgs e)
        {
			try
			{
				ISession s = DataLayer.GetSession();

				Cirkuska_predstava cp = s.Load<Cirkuska_predstava>(18);
				Entiteti.Grad g = s.Load<Entiteti.Grad>(18220);

				Izvodi_se iz = new Izvodi_se();
				iz.Id.Predstava_u_gradu = cp;
				iz.Id.Izvodi_se_u = g;
				iz.Od = DateTime.Today;
				iz.Do = DateTime.Now;

				s.Save(iz);

				s.Flush();
				MessageBox.Show("Uspešno dodeljena predstava.");
				s.Close();


			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_izmeni_predstavu_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                Cirkuska_predstava p = s.Load<Cirkuska_predstava>(1);
                p.broj_prodatih_karata = 233;

                s.Update(p);
                s.Flush();
                MessageBox.Show("Uspešno izmenjena predstava.");

                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_izbrisi_predstavu_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                Cirkuska_predstava p = s.Load<Cirkuska_predstava>(4);

                s.Delete(p);
                s.Flush();
                MessageBox.Show("Uspešno obrisana predstava.");

                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_dodaj_grad_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Grad g = new Entiteti.Grad();

                g.poštanski_broj = 18220;
                g.naziv = "Aleksinac";
                g.zemlja = "Hrvatska";
                g.opis = "Za Nevenu";

                s.SaveOrUpdate(g);

                s.Flush();
                MessageBox.Show("Dodat je grad " + g.naziv);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_dodaj_tačku_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                // Cirkuska_predstava cp = s.Load<Cirkuska_predstava>(1);

                Entiteti.Cirkuska_tačka ct = new Entiteti.Cirkuska_tačka();


                ct.broj_tačke = 5145;
                ct.efekti = "vatra";
                ct.uzrast = "18+";
                ct.tip = "gutanje plamena";
                ct.naziv_tačke = "Pesma vatre i leda";
                

    
                s.SaveOrUpdate(ct);
                //cp.Tačke.Add(ct);
                //s.SaveOrUpdate(cp);

                s.Flush();
                MessageBox.Show("Dodata je cirkuska tačka " + ct.naziv_tačke);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_tacke_u_predstavi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cirkuska_predstava cp = s.Load<Cirkuska_predstava>(6);
                Entiteti.Cirkuska_tačka ct = s.Load<Entiteti.Cirkuska_tačka>(1565);

                //Sastoji_se ss = new Sastoji_se();
                //ss.Sastoji_se_predstava = cp;
                //ss.Sastoji_se_tačka = ct;

                //s.Save(ss);
                cp.Tačke.Add(ct);

                Entiteti.Cirkuska_tačka ct1 = s.Load<Entiteti.Cirkuska_tačka>(1565);

                //Sastoji_se ss = new Sastoji_se();
                //ss.Sastoji_se_predstava = cp;
                //ss.Sastoji_se_tačka = ct;

                //s.Save(ss);
                cp.Tačke.Add(ct1);

                foreach (Cirkuska_tačka t in cp.Tačke)
                {
                    MessageBox.Show(t.naziv_tačke.ToString());
                }

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_dodeli_tacku_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Cirkuska_predstava cp = s.Load<Cirkuska_predstava>(49);
                Entiteti.Cirkuska_tačka ct = s.Load<Entiteti.Cirkuska_tačka>(5145);

				Sastoji_se ss = new Sastoji_se();
				ss.Sastoji_se_predstava = cp;
				ss.Sastoji_se_tačka = ct;

				s.Save(ss);

				s.Flush();
                
                MessageBox.Show("Uspešno dodeljena 1. tačka.");
                

                Cirkuska_predstava cp2 = s.Load<Cirkuska_predstava>(49);
                Entiteti.Cirkuska_tačka ct2 = s.Load<Entiteti.Cirkuska_tačka>(5252);

                Sastoji_se ss2 = new Sastoji_se();
                ss2.Sastoji_se_predstava = cp2;
                ss2.Sastoji_se_tačka = ct2;

                s.Save(ss2);

                s.Flush();
                MessageBox.Show("Uspešno dodeljena 2. tačka.");
				s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

		private void btn_Zaduzi_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Cirkuska_tačka ct = s.Load<Cirkuska_tačka>(5145);
				Entiteti.Pomoćno_osoblje pom = s.Load<Entiteti.Pomoćno_osoblje>(987654321022);

				Zadužuje zad = new Zadužuje();
				zad.id.zaduženo_Tačka = ct;
				zad.id.zaduženo_Osoblje = pom;
				
				s.Save(zad);

				s.Flush();
				MessageBox.Show("Uspešno zadužen Branko.");
				s.Close();


			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

		private void btn_dresira_Click(object sender, EventArgs e)
		{

			try
			{
				ISession s = DataLayer.GetSession();

				
				Dreseri d = s.Load<Dreseri>(123456789011);
				Entiteti.Životinje ž = s.Load<Entiteti.Životinje>(123);

				Dresira dr = new Dresira();
				dr.Dresira_dreseri = d;
				dr.Dresira_životinje = ž;

				s.Save(dr);

				s.Flush();
				MessageBox.Show("Dresirano");
				s.Close();


			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
			

				


		}

        private void btn_vestina_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o akrobati sa zadatim maticnim br
                Akrobate a = s.Load<Akrobate>(123456789101);
                Veština v = s.Load<Veština>(11);

                Poseduje po = new Poseduje();
                po.Poseduje_veština = v;
                po.Poseduje_akrobate = a;
                MessageBox.Show("proba");

                s.Save(po);

                s.Flush();
                MessageBox.Show("Uspešno");
                s.Close();

            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
			try
			{
				ISession s = DataLayer.GetSession();

				Cirkuska_tačka ct = s.Load<Cirkuska_tačka>(1234);
				Entiteti.Artisti art = s.Load<Entiteti.Artisti>(9827384958372);

				Angažuje zad = new Angažuje();
				zad.Angažuje_tačka = ct;
				zad.Angažuje_artisti = art;

				s.Save(zad);

				s.Flush();
				MessageBox.Show("Uspešno");
				s.Close();


			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}

		}

		private void btn_dodaj_klovna_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();


				Entiteti.Klovnovi p = new Entiteti.Klovnovi()
				{

					matični_broj = 9827384958372,
					ime = "Pennywise",
					prezime = "King",
					ime_roditelja = "Nema",
					nadimak = "Penny",
					pol = 'm',
					datum_rođenja = DateTime.Now,
					asistenti = "ne",
					datum_dolaska = DateTime.Today,
					mesto_rođenja = "Derry",
					tip = "tužan",
					čime_zabavlja = "Plače",
				};
				s.Save(p);

				s.Flush();
				MessageBox.Show("Dodat je klovn : " + p.čime_zabavlja);
				s.Close();
			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

        private void btn_Predstava_Click(object sender, EventArgs e)
        {
            Predstava predstava = new Predstava();
            predstava.ShowDialog();
        }

        private void Btn_Tačka_Click(object sender, EventArgs e)
        {
            Tačka tačka = new Tačka();
            tačka.ShowDialog();
        }

        private void Btn_pomoćno_osoblje_Click(object sender, EventArgs e)
        {
            Osoblje osoblje = new Osoblje();
            osoblje.ShowDialog();            
        }

        private void Btn_Grad_Click(object sender, EventArgs e)
        {
            Forme.Grad grad = new Forme.Grad();
            grad.ShowDialog();
        }

        private void Btn_Životinje_Click(object sender, EventArgs e)
        {
            Forme.Životinje životinje = new Forme.Životinje();
            životinje.ShowDialog();
        }

        private void Btn_criteria_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<Cirkuska_predstava>();

                c.Add(Expression.Ge("broj_prodatih_karata", 500));

                IList<Cirkuska_predstava> pred = c.List<Cirkuska_predstava>();

                foreach (Cirkuska_predstava p in pred)
                {
                    MessageBox.Show("Id trazene predstave: " + p.id_predstave.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_native_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM GRAD O");
                q.AddEntity(typeof(global::Cirkus.Entiteti.Grad));


                IList<Entiteti.Grad> gradovi = q.List<global::Cirkus.Entiteti.Grad>();

                foreach (global::Cirkus.Entiteti.Grad g in gradovi)
                {
                    MessageBox.Show(g.naziv);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_ukupno_karata_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select sum(o.broj_prodatih_karata) from Cirkuska_predstava o ");

                //za slucaj da upit vraca samo jednu vrednost
                Int64 karte = q.UniqueResult<Int64>();

                MessageBox.Show("Ukupan broj prodatih karata: " + karte.ToString());

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
	

