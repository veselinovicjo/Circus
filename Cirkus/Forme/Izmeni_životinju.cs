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
    public partial class Izmeni_životinju : Form
    {
        public Izmeni_životinju()
        {
            InitializeComponent();
        }

        public Izmeni_životinju(ŽivotinjePregled životinja)
        {
            InitializeComponent();

            dtp_dolazak.Value = DateTime.Parse(životinja.datum_dolaska.ToString());
            tbx_nadimak.Text = životinja.nadimak;
            tbx_težina.Text = životinja.težina.ToString();
            cbx_pol.Text = životinja.pol.ToString(); 
            tbx_br_kaveza.Text = životinja.broj_kaveza.ToString();
            tbx_vrsta.Text = životinja.vrsta;
            tbx_starost.Text = životinja.starost;
            dtp_vpregled.Value = DateTime.Parse(životinja.veterinarski_pregled.ToString());
        }

        private void Btn_odustani_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public char GetFirstChar(string text)
        {
            return text[0];
        }

        private void Btn_dodaj_Click(object sender, EventArgs e)
        {
            ŽivotinjePregled životinja = new ŽivotinjePregled();
            životinja.nadimak = tbx_nadimak.Text;
            životinja.težina = float.Parse(tbx_težina.Text);
            životinja.pol = GetFirstChar(cbx_pol.Text.ToString());
            životinja.broj_kaveza = int.Parse(tbx_br_kaveza.Text);
            životinja.vrsta = tbx_vrsta.Text;
            životinja.starost = tbx_starost.Text;
            životinja.datum_dolaska = dtp_dolazak.Value;
            životinja.veterinarski_pregled = dtp_vpregled.Value;
            try
            {
                if (DTOManager.Izmeni_životinju(životinja))
                {
                    DialogResult dialog = MessageBox.Show("Uspešno su ažurirani podaci o životinji!");
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
    }
}
