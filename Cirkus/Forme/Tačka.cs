using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Linq;
using Cirkus.Entiteti;
using Cirkus.Forme;

namespace Cirkus.Forme
{
    public partial class Tačka : Form
    {
        private IList<TačkaPregled> lista_tačaka;

        public Tačka()
        {
            InitializeComponent();            
        }

        private void Tačka_Load(object sender, EventArgs e)
        {
            try
            {
                this.PopulateInfos();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PopulateInfos()
        {
            listView_tačke.Items.Clear();
            lista_tačaka = DTOManager.Učitaj_informacije_svih_tačaka();

            foreach (TačkaPregled tp in lista_tačaka)
            {
                ListViewItem item = new ListViewItem(new string[] { tp.broj_tačke.ToString(), tp.naziv_tačke, tp.tip, tp.efekti, tp.uzrast });

                listView_tačke.Items.Add(item);
            }
            listView_tačke.Refresh();
        }

        private void Btn_dodaj_tačku_Click_1(object sender, EventArgs e)
        {
            Dodaj_tačku dodaj_tačku = new Dodaj_tačku();
            dodaj_tačku.ShowDialog();
            this.PopulateInfos();
        }

        private void Btn_izmeni_tačku_Click_1(object sender, EventArgs e)
        {
            if (listView_tačke.SelectedItems.Count == 1)
            {
                Obrada_izmene();
            }
            else if (listView_tačke.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati cirkusku tačku pre nego što probate da izmenite podatke.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jednu cirkusku tačku.");
            }
        }

        private void Obrada_izmene()
        {
            TačkaPregled tačka = Pribavi_tačku();

            Izmeni_tačku izmeni_tačku = new Izmeni_tačku(tačka);
            izmeni_tačku.ShowDialog();
            this.PopulateInfos();
        }
        private TačkaPregled Pribavi_tačku()
        {
            int indeks = listView_tačke.SelectedItems[0].Index;
            return lista_tačaka.ElementAt(indeks);
        }

        private void listView_tačke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Obrada_izmene();
        }

        //private void btnObrisiBanku_Click(object sender, EventArgs e)
        //{
        //    //if (listView_predstave.SelectedItems.Count == 1)
        //    //{
        //    //    PredstavaPregled predstava = Pribavi_predstavu);
        //    //    Obriši_predstavu(predstava.id_predstave);
        //    //}
        //    //else if (listView_predstave.SelectedItems.Count == 0)
        //    //{
        //    //    MessageBox.Show("Morate odabrati predstavu pre nego što probate da izmenite podatke.");
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Možete da izaberete samo jednu predstavu.");
        //    //}
        //}

        //private void Obriši_tačku(int id)
        //{
        //    if (DTOManager.Obriši_tačku(id))
        //    {
        //        MessageBox.Show("Uspešno ste obrisali cirkusku tačku! :)");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nastao je problem sa brisanjem cirkuske tačke.");
        //    }

        //}

        private void Btn_nazad_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ukloni_tačku_Click(object sender, EventArgs e)
        {
            if (listView_tačke.SelectedItems.Count == 1)
            {
                TačkaPregled tačka = Pribavi_tačku();
                Obriši_tačku(tačka.broj_tačke);
                this.PopulateInfos();
            }
            else if (listView_tačke.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati tačku pre nego što probate da izmenite podatke.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jednu tačku.");
            }
        }

        private void Obriši_tačku(int broj_tačke)
        {
            if (DTOManager.Obriši_tačku(broj_tačke))
            {
                MessageBox.Show("Uspešno ste obrisali tačku! :)");
            }
            else
            {
                MessageBox.Show("Nastao je problem sa brisanjem tačke.");
            }

        }


        //private void listViewBanke_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
