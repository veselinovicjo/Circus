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
    public partial class Osoblje : Form
    {
        private IList<PomoćnoOsobljePregled> lista_osoblja;

        public Osoblje()
        {
            InitializeComponent();
        }

        private void Osoblje_Load_1(object sender, EventArgs e)
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
            listView_osoblje.Items.Clear();
            lista_osoblja = DTOManager.Učitaj_informacije_svog_pomoćnog_osoblja();
            foreach (PomoćnoOsobljePregled po in lista_osoblja)
            {
                ListViewItem item = new ListViewItem(new string[] { po.matični_broj.ToString(), po.ime, po.prezime, po.pol.ToString(), po.datum_rođenja.ToString(), po.mesto_rođenja });

                listView_osoblje.Items.Add(item);
            }
            listView_osoblje.Refresh();
        }

        private void Btn_dodaj_pomoćno_osoblje_Click(object sender, EventArgs e)
        {
            Dodaj_osoblje dodaj_osoblje = new Dodaj_osoblje();
            dodaj_osoblje.ShowDialog();
            this.PopulateInfos();
        }

        private void Btn_izmeni_pomoćno_osoblje_Click(object sender, EventArgs e)
        {
            if (listView_osoblje.SelectedItems.Count == 1)
            {
                Obrada_izmene();
            }
            else if (listView_osoblje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati pomoćno osoblje pre nego što probate da izmenite podatke.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedno pomoćno osoblje.");
            }
        }

        private void Obrada_izmene()
        {
            PomoćnoOsobljePregled osoblje = Pribavi_osoblje();

            Izmeni_osoblje izmeni_osoblje = new Izmeni_osoblje(osoblje);
            izmeni_osoblje.ShowDialog();
            this.PopulateInfos();
        }
        private PomoćnoOsobljePregled Pribavi_osoblje()
        {
            int indeks = listView_osoblje.SelectedItems[0].Index;
            return lista_osoblja.ElementAt(indeks);
        }

        private void Btn_ukloni_pomoćno_osoblje_Click(object sender, EventArgs e)
        {
            if (listView_osoblje.SelectedItems.Count == 1)
            {
                PomoćnoOsobljePregled osoblje = Pribavi_osoblje();
                Obriši_pomoćno_osoblje(osoblje.matični_broj);
                this.PopulateInfos();
            }
            else if (listView_osoblje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati osoblje pre nego što probate da obrišete.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedno od osoblja.");
            }
        }

        private void Obriši_pomoćno_osoblje(long matični_broj)
        {
            if (DTOManager.Obriši_pomoćno_osoblje(matični_broj))
            {
                MessageBox.Show("Uspešno ste obrisali osoblje! :)");
            }
            else
            {
                MessageBox.Show("Nastao je problem sa brisanjem osoblja.");
            }

        }

    }
}
