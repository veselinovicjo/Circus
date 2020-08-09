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
    public partial class Dodaj_životinju : Form
    {
        private IList<ArtistiPregled> lista_dresera;

        public Dodaj_životinju()
        {
            InitializeComponent();
        }

        private void Dodaj_životinju_Load(object sender, EventArgs e)
        {
            try
            {
                tbx_br_kaveza.Text = String.Empty;
                tbx_nadimak.Text = String.Empty;
                tbx_vrsta.Text = String.Empty;
                cbx_pol.Text = String.Empty;
                cbx_pol.SelectedText = "--select--";
                tbx_starost.Text = String.Empty;
                tbx_težina.Text = String.Empty;
                dtp_dolazak.Value = DateTime.Today;
                dtp_vpregled.Value = DateTime.Today;

                listView_dreseri.MultiSelect = false;

                this.PopulateInfos();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PopulateInfos()
        {
            listView_dreseri.Items.Clear();
            lista_dresera = DTOManager.Učitaj_informacije_svih_artista();
            //lista_tačaka_checked = DTOManager.Učitaj_informacije_svih_tačaka();
            foreach (ArtistiPregled a in lista_dresera)
            {
                ListViewItem item = new ListViewItem(new string[] {  });

                listView_dreseri.Items.Add(item);
            }
            listView_dreseri.Refresh();
        }

        private void Btn_dodaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                    return;

                if (DTOManager.Dodaj_životinju(int.Parse(tbx_br_kaveza.Text), tbx_nadimak.Text, float.Parse(tbx_težina.Text), GetFirstChar(cbx_pol.Text), tbx_vrsta.Text, tbx_starost.Text, dtp_dolazak.Value, dtp_vpregled.Value))
                {
                    MessageBox.Show("Uspešno ste dodali životinju!");
                    tbx_nadimak.Text = String.Empty;
                    tbx_težina.Text = String.Empty;
                    tbx_br_kaveza.Text = String.Empty;
                    tbx_vrsta.Text = String.Empty;
                    tbx_starost.Text = String.Empty;
                    cbx_pol.Text = String.Empty;
                    cbx_pol.SelectedText = "--select--";
                    dtp_dolazak.Value = DateTime.Today;
                    dtp_vpregled.Value = DateTime.Today;
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

        private void Tbx_br_kaveza_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //8 backspace key
            {
                e.Handled = true;
            }
        }

        private void Btn_odustani_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(tbx_br_kaveza.Text) || String.IsNullOrEmpty(tbx_nadimak.Text) || String.IsNullOrEmpty(tbx_vrsta.Text) || String.IsNullOrEmpty(cbx_pol.Text) || String.IsNullOrEmpty(dtp_dolazak.Text) || String.IsNullOrEmpty(dtp_vpregled.Text))
            {
                MessageBox.Show("Morate popuniti sva polja.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else
                return true;
        }

        public char GetFirstChar(String text)
        {
            return text[0];
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
