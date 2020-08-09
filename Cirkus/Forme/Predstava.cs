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

namespace Cirkus
{
    public partial class Predstava : Form
    {
        private IList<PredstavaPregled> lista_predstava;

        public Predstava()
        {
            InitializeComponent();
        }
        

        private void Predstava_Load(object sender, EventArgs e)
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
            listView_predstave.Items.Clear();
            lista_predstava = DTOManager.Učitaj_informacije_svih_predstava();

            foreach (PredstavaPregled pp in lista_predstava)
            {
                ListViewItem item = new ListViewItem(new string[] { pp.id_predstave.ToString(), pp.vreme_predstave, pp.broj_prodatih_karata.ToString() });

                listView_predstave.Items.Add(item);
            }
            listView_predstave.Refresh();
        }

        private void btn_dodaj_predstavu_Click(object sender, EventArgs e)
        {
            Dodaj_predstavu dodaj_predstavu = new Dodaj_predstavu();
            dodaj_predstavu.ShowDialog();
            this.PopulateInfos();
        }

        private void Predstava_Load_1(object sender, EventArgs e)
        {
            this.PopulateInfos();
        }

        private void btn_izmeni_predstavu_Click(object sender, EventArgs e)
        {
            if (listView_predstave.SelectedItems.Count == 1)
            {
                Obrada_izmene();
            }
            else if (listView_predstave.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati predstavu pre nego što probate da izmenite podatke.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jednu predstavu.");
            }
        }

        private void Obrada_izmene()
        {
            PredstavaPregled predstava = Pribavi_predstavu();

            Izmeni_predstavu izmeni_predstavu = new Izmeni_predstavu(predstava);
            izmeni_predstavu.ShowDialog();
            this.PopulateInfos();
        }
        private PredstavaPregled Pribavi_predstavu()
        {
            int indeks = listView_predstave.SelectedItems[0].Index;
            return lista_predstava.ElementAt(indeks);
        }

        private void listViewBanke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Obrada_izmene();
        }

        //private void btnObrisiBanku_Click(object sender, EventArgs e)
        //{
        //if (listView_predstave.SelectedItems.Count == 1)
        //{
        //    PredstavaPregled predstava = Pribavi_predstavu);
        //    Obriši_predstavu(predstava.id_predstave);
        //}
        //else if (listView_predstave.SelectedItems.Count == 0)
        //{
        //    MessageBox.Show("Morate odabrati predstavu pre nego što probate da izmenite podatke.");
        //}
        //else
        //{
        //    MessageBox.Show("Možete da izaberete samo jednu predstavu.");
        //}
        //}

        private void Obriši_predstavu(int id)
        {
            if (DTOManager.Obriši_predstavu(id))
            {
                MessageBox.Show("Uspešno ste obrisali predstavu! :)");
            }
            else
            {
                MessageBox.Show("Nastao je problem sa brisanjem predstave.");
            }

        }
        private void btn_nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btn_ukloni_predstavu_Click(object sender, EventArgs e)
		{
			if (listView_predstave.SelectedItems.Count == 1)
			{
				PredstavaPregled predstava = Pribavi_predstavu();
				Obriši_predstavu(predstava.id_predstave);
                this.PopulateInfos();
            }
            else if (listView_predstave.SelectedItems.Count == 0)
			{
				MessageBox.Show("Morate odabrati predstavu pre nego što probate da izmenite podatke.");
			}
			else
			{
				MessageBox.Show("Možete da izaberete samo jednu predstavu.");
			}
		}
	}

}
