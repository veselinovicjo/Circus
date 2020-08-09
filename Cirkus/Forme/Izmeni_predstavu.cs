using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cirkus.Entiteti;

namespace Cirkus.Forme
{
    public partial class Izmeni_predstavu : Form

    {
        private IList<TačkaPregled> lista_tačaka;
        private IList<GradPregled> lista_gradova;
        private IList<Izvodi_se> izvodi_se;

        public Izmeni_predstavu()
        {
            InitializeComponent();
        }

        private void Izmeni_predstavu_Load(object sender, EventArgs e)
        {
            try
            {
                dtp_od.Value = DateTime.Today;
                dtp_do.Value = DateTime.Today;
                listView_cirkuske_tačke.MultiSelect = true;
               // listView_cirkuske_tačke.CheckBoxes = true;

                listView_gradovi.MultiSelect = true;
               // listView_gradovi.CheckBoxes = true;

                this.PopulateInfos();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PopulateInfos()
        {
            //Load infos for Cirkuske tačke
            listView_cirkuske_tačke.Items.Clear();
            lista_tačaka = DTOManager.Učitaj_informacije_svih_tačaka();
            //lista_tačaka_checked = DTOManager.Učitaj_informacije_svih_tačaka();
            foreach (TačkaPregled t in lista_tačaka)
            {
                ListViewItem item = new ListViewItem(new string[] { t.broj_tačke.ToString(), t.naziv_tačke, t.tip, t.efekti, t.uzrast });

                listView_cirkuske_tačke.Items.Add(item);
            }
            listView_cirkuske_tačke.Refresh();

            //Load infos for Gradovi
            listView_gradovi.Items.Clear();
            lista_gradova = DTOManager.Učitaj_informacije_svih_gradova();
            //lista_gradova_checked = DTOManager.Učitaj_informacije_svih_gradova();
            foreach (GradPregled g in lista_gradova)
            {
                ListViewItem item = new ListViewItem(new string[] { g.poštanski_broj.ToString(), g.naziv, g.zemlja, g.opis });

                listView_gradovi.Items.Add(item);
            }
            listView_gradovi.Refresh();
        }

        public Izmeni_predstavu(PredstavaPregled predstava)
        {
            InitializeComponent();
            tbx_vreme_predstave.Text = predstava.vreme_predstave;
            tbx_broj_prodatih_karata.Text = predstava.broj_prodatih_karata.ToString();
            lbl_id_predstave.Text = predstava.id_predstave.ToString();

        }

        private void btn_sačuvaj_Click(object sender, EventArgs e)
        {
            PredstavaPregled predstava = new PredstavaPregled();
            predstava.id_predstave = int.Parse(lbl_id_predstave.Text);
            predstava.vreme_predstave = tbx_vreme_predstave.Text;
            predstava.broj_prodatih_karata = int.Parse(tbx_broj_prodatih_karata.Text);
            Cirkuska_predstava cp = new Cirkuska_predstava();
           // cp.Predstava_u_gradu[]
            

            try
            {
                if (DTOManager.Izmeni_predstavu(predstava, Pribavi_tačke(), Pribavi_gradove(), dtp_od.Value, dtp_do.Value))
                {
                    DialogResult dialog = MessageBox.Show("Uspešno su ažurirani podaci o predstavi!");
                    if (dialog == DialogResult.OK)
                        this.Close();

                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Došlo je do problema sa ažuriranjem podataka ");
                    if (dialog == DialogResult.OK)
                        this.Close();
                }
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btn_odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int[] Pribavi_tačke()
        {
            int i = 0;
            int[] brojevi_tačaka = new int[listView_cirkuske_tačke.SelectedItems.Count];

            foreach (ListViewItem item in listView_cirkuske_tačke.SelectedItems)
            {
                brojevi_tačaka[i] = int.Parse(listView_cirkuske_tačke.SelectedItems[i].Text);
                i++;
            }
            return brojevi_tačaka;
        }

        private int[] Pribavi_gradove()
        {
            int i = 0;
            int[] indeksi_gradova = new int[listView_gradovi.SelectedItems.Count];

            foreach (ListViewItem item in listView_gradovi.SelectedItems)
            {
                indeksi_gradova[i] = int.Parse(listView_gradovi.SelectedItems[i].Text);
                i++;
            }
            return indeksi_gradova;
        }
    }
}
