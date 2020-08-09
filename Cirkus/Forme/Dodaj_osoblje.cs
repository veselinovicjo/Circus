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
    public partial class Dodaj_osoblje : Form
    {
        public Dodaj_osoblje()
        {
            InitializeComponent();
        }

        private void Dodaj_osoblje_Load(object sender, EventArgs e)
        {
            tbx_matični_broj.Text = String.Empty;
            tbx_ime.Text = String.Empty;
            tbx_prezime.Text = String.Empty;
            cbx_pol.Text = String.Empty;
            cbx_pol.SelectedText = "--select--";
            dtp_datum_rođenja.Value = DateTime.Today;
            tbx_mesto_rođenja.Text = String.Empty;
        }

        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                    return;

                if (DTOManager.Dodaj_pomoćno_osoblje(long.Parse(tbx_matični_broj.Text), tbx_ime.Text, tbx_prezime.Text, GetFirstChar(cbx_pol.Text.ToString()), dtp_datum_rođenja.Value, tbx_mesto_rođenja.Text))
                {
                    MessageBox.Show("Uspešno ste dodali pomoćno osoblje!");
                    tbx_matični_broj.Text = String.Empty;
                    tbx_ime.Text = String.Empty;
                    tbx_prezime.Text = String.Empty;
                    cbx_pol.Text = String.Empty;
                    cbx_pol.SelectedText = "--select--";
                    dtp_datum_rođenja.Value = DateTime.Today;
                    tbx_mesto_rođenja.Text = String.Empty;
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

        public char GetFirstChar(string text)
        {
            return text[0];
        }

        private void tbx_broj_prodatih_karata_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) //8 backspace key
            {
                e.Handled = true;
            }
        }

        private void Btn_odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(tbx_matični_broj.Text))
            {
                MessageBox.Show("Morate uneti matični broj pomoćnog osoblja.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else if (tbx_matični_broj.Text.Length != 12)
            {
                MessageBox.Show("Matični broj se mora sastojati od 12 cifara.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else if (String.IsNullOrEmpty(tbx_ime.Text))
            {
                MessageBox.Show("Morate uneti ime pomoćnog osoblja.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else if (String.IsNullOrEmpty(tbx_prezime.Text))
            {
                MessageBox.Show("Morate uneti prezime pomoćnog osoblja.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else
                return true;
        }
       
    }
}
