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
    public partial class Izmeni_osoblje : Form
    {
        public Izmeni_osoblje()
        {
            InitializeComponent();
        }

        public Izmeni_osoblje(PomoćnoOsobljePregled osoblje)
        {
            InitializeComponent();
            lbl_matični_broj.Text = osoblje.matični_broj.ToString();
            tbx_ime.Text = osoblje.ime;
            tbx_prezime.Text = osoblje.prezime;
            cbx_pol.Text = osoblje.pol.ToString();
            dtp_datum_rođenja.Value = DateTime.Parse(osoblje.datum_rođenja.ToString());
            tbx_mesto_rođenja.Text = osoblje.mesto_rođenja;
        }
        public char GetFirstChar(string text)
        {
            return text[0];
        }

        private void Btn_sačuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                    return;

                PomoćnoOsobljePregled osoblje = new PomoćnoOsobljePregled();
                osoblje.matični_broj = long.Parse(lbl_matični_broj.Text);
                osoblje.ime = tbx_ime.Text;
                osoblje.prezime = tbx_prezime.Text;
                osoblje.pol = GetFirstChar(cbx_pol.Text.ToString());
                osoblje.datum_rođenja = dtp_datum_rođenja.Value;
                osoblje.mesto_rođenja = tbx_mesto_rođenja.Text;

                try
                {
                    if (DTOManager.Izmeni_pomoćno_osoblje(osoblje))
                    {
                        DialogResult dialog = MessageBox.Show("Uspešno su ažurirani podaci o pomoćnom osoblju!");
                        if (dialog == DialogResult.OK)
                            this.Close();

                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Došlo je do problema sa ažuriranjem podataka.");
                        if (dialog == DialogResult.OK)
                            this.Close();
                    }
                }

                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Izmeni_osoblje_Load(object sender, EventArgs e)
        {

        }

        private bool Validacija()
        {            
            if (String.IsNullOrEmpty(tbx_ime.Text))
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
