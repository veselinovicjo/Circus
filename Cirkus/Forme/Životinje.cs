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
    public partial class Životinje : Form
    {
        private IList<ŽivotinjePregled> lista_životinja;

        public Životinje()
        {
            InitializeComponent();
           
        }

        private void Životinje_Load(object sender, EventArgs e)
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
            listView_životinja.Items.Clear();
            lista_životinja = DTOManager.Učitaj_informacije_svih_životinja();
            foreach (ŽivotinjePregled žp in lista_životinja)
            {
                ListViewItem item = new ListViewItem(new string[] { žp.datum_dolaska.ToString(), žp.nadimak, žp.težina.ToString(), žp.pol.ToString(), žp.broj_kaveza.ToString(), žp.vrsta, žp.starost, žp.veterinarski_pregled.ToString() });

                listView_životinja.Items.Add(item);
            }
            listView_životinja.Refresh();
        }

        private void Obrada_izmene()
        {
            ŽivotinjePregled životinja = Pribavi_životinju();

            Izmeni_životinju izmeni_životinju = new Izmeni_životinju(životinja);
            izmeni_životinju.ShowDialog();
            this.PopulateInfos();
        }
        private ŽivotinjePregled Pribavi_životinju()
        {
            int indeks = listView_životinja.SelectedItems[0].Index;
            return lista_životinja.ElementAt(indeks);
        }


        private void ListView_životinja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_nazad_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_dodaj_životinju_Click(object sender, EventArgs e)
        {
            Dodaj_životinju dodaj_životinju = new Dodaj_životinju();
            dodaj_životinju.ShowDialog();
            this.PopulateInfos();
        }

        private void Btn_izmeni_životinju_Click(object sender, EventArgs e)
        {
            if (listView_životinja.SelectedItems.Count == 1)
            {
                Obrada_izmene();
            }
            else if (listView_životinja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati životinju pre nego što probate da izmenite podatke.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jednu životinju.");
            }
        }

        //private void Obriši_životinju(int id)
        //{
        //    if (DTOManager.Obriši_životinju(id))
        //    {
        //        MessageBox.Show("Uspešno ste obrisali životinju! :)");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nastao je problem sa brisanjem životinje.");
        //    }

        //}

        private void Btn_ukloni_životinju_Click(object sender, EventArgs e)
        {

        }

        

        //private void ListView_životinja_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    Obrada_izmene();
        //}
    }
}
