using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirkus.Forme
{
    public partial class Dodaj_predstavu : Form
    {
        private IList<TačkaPregled> lista_tačaka;
        private IList<GradPregled> lista_gradova;

        public Dodaj_predstavu()
        {
            InitializeComponent();
        }

        private void Dodaj_predstavu_Load(object sender, EventArgs e)
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

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                    return;

                if (DTOManager.Dodaj_predstavu(int.Parse(tbx_broj_prodatih_karata.Text), tbx_vreme_predstave.Text, Pribavi_tačke(), Pribavi_gradove(), dtp_od.Value, dtp_do.Value))
                {
                    MessageBox.Show("Uspešno ste dodali predstavu!");
                    tbx_vreme_predstave.Text = String.Empty;
                    tbx_broj_prodatih_karata.Text = String.Empty;
                    dtp_od.Value = DateTime.Today;
                    dtp_do.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("Došlo je do problema sa unosom. Molimo Vas probajte ponovo.");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void tbx_broj_prodatih_karata_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //8 backspace key
            {
                e.Handled = true;
            }
        }

        private void btn_odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_dodaj_cirkusku_tačku_Click(object sender, EventArgs e)
        {
            Forme.Dodaj_tačku tačka = new Forme.Dodaj_tačku();
            tačka.ShowDialog();
            this.PopulateInfos();
        }

        private void Btn_dodaj_grad_Click(object sender, EventArgs e)
        {
            Forme.Dodaj_grad grad = new Forme.Dodaj_grad();
            grad.ShowDialog();
            this.PopulateInfos();
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

        private bool Validacija()
        {
            if(listView_cirkuske_tačke.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate dodeliti barem jednu cirkusku tačku predstavi.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else if (listView_gradovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate dodati barem jedan grad u kojem će se izvoditi predstava.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else
                return true;
        }

    }
}
