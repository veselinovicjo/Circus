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
    public partial class Grad : Form
    {
        private IList<GradPregled> lista_gradova;

        public Grad()
        {
            InitializeComponent();
        }

        private void Grad_Load_1(object sender, EventArgs e)
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
            listView_gradova.Items.Clear();
            lista_gradova = DTOManager.Učitaj_informacije_svih_gradova();

            foreach (GradPregled gp in lista_gradova)
            {
                ListViewItem item = new ListViewItem(new string[] { gp.poštanski_broj.ToString(), gp.naziv, gp.zemlja, gp.opis });

                listView_gradova.Items.Add(item);
            }
            listView_gradova.Refresh();
        }

        private void Btn_dodaj_grad_Click_1(object sender, EventArgs e)
        {
            Dodaj_grad dodaj_grad = new Dodaj_grad();
            dodaj_grad.ShowDialog();
            this.PopulateInfos();
        }

        private void Btn_izmeni_grad_Click_1(object sender, EventArgs e)
        {
            if (listView_gradova.SelectedItems.Count == 1)
            {
                Obrada_izmene();
            }
            else if (listView_gradova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati grad pre nego što probate da izmenite podatke.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedan grad.");
            }
        }

        private void Obrada_izmene()
        {
            GradPregled grad = Pribavi_grad();

            Izmeni_grad izmeni_grad = new Izmeni_grad(grad);
            izmeni_grad.ShowDialog();
            this.PopulateInfos();
        }
        private GradPregled Pribavi_grad()
        {
            int indeks = listView_gradova.SelectedItems[0].Index;
            return lista_gradova.ElementAt(indeks);
        }

        private void Obriši_grad(int poštanski_broj)
        {
            if (DTOManager.Obriši_grad(poštanski_broj))
            {
                MessageBox.Show("Uspešno ste obrisali grad! :)");
            }
            else
            {
                MessageBox.Show("Nastao je problem sa brisanjem predstave.");
            }

        }

        private void Btn_ukloni_grad_Click(object sender, EventArgs e)
        {
            if (listView_gradova.SelectedItems.Count == 1)
            {
                GradPregled grad = Pribavi_grad();
                Obriši_grad(grad.poštanski_broj);
                this.PopulateInfos();
            }
            else if (listView_gradova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate odabrati grad pre nego što probate da izmenite podatke.");
            }
            else
            {
                MessageBox.Show("Možete da izaberete samo jedan grad.");
            }
        }

        private void Btn_nazad_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
