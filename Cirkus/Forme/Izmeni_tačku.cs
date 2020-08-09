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
    public partial class Izmeni_tačku : Form
    {
      //  private int broj_tačke;

        public Izmeni_tačku()
        {
            InitializeComponent();
       //     broj_tačke = -1;
        }

        public Izmeni_tačku(TačkaPregled tačka)
        {
            InitializeComponent();
            lbl_broj_tačke.Text = tačka.broj_tačke.ToString();
            tbx_naziv_tačke.Text = tačka.naziv_tačke;
            cbx_tip.Text = tačka.tip;
            cbx_efekti.Text = tačka.efekti;
            tbx_uzrast.Text = tačka.uzrast;
        }

        private void Izmeni_tačku_Load(object sender, EventArgs e)
        {

        }

        private void Btn_sačuvaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                { return; }

                TačkaPregled tačka = new TačkaPregled();
                tačka.broj_tačke = int.Parse(lbl_broj_tačke.Text);
                tačka.naziv_tačke = tbx_naziv_tačke.Text;
                tačka.tip = cbx_tip.Text;
                tačka.efekti = cbx_efekti.Text;
                tačka.uzrast = tbx_uzrast.Text;

                try
                {
                    if (DTOManager.Izmeni_tačku(tačka))
                    {
                        DialogResult dialog = MessageBox.Show("Uspešno su ažurirani podaci o cirkuskoj tački!");
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
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Btn_odustani_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(tbx_naziv_tačke.Text))
            {
                MessageBox.Show("Morate popuniti naziv cirkuske tačke.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else if (String.IsNullOrEmpty(cbx_tip.Text))
            {
                MessageBox.Show("Morate izabrati tip cirkuske tačke.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else if (String.IsNullOrEmpty(cbx_efekti.Text))
            {
                MessageBox.Show("Morate izabrati efekte u cirkuskoj tački.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else
                return true;
        }

    }
}
