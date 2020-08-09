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
    public partial class Dodaj_tačku : Form
    {
        public Dodaj_tačku()
        {
            InitializeComponent();
        }

        private void Dodaj_tačku_Load(object sender, EventArgs e)
        {
            tbx_naziv_tačke.Text = String.Empty;
            cbx_tip.SelectedText = "--select--";
            cbx_efekti.SelectedText = "--select--";
            tbx_uzrast.Text = String.Empty;
        }

        private void Btn_dodaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                    return;


                if (DTOManager.Dodaj_tačku(tbx_naziv_tačke.Text, cbx_tip.Text, cbx_efekti.Text, tbx_uzrast.Text))
                {
                    MessageBox.Show("Uspešno ste dodali cirkusku tačku!");
                    tbx_naziv_tačke.Text = String.Empty;
                    cbx_tip.Text = String.Empty;
                    cbx_tip.SelectedText = "--select--";
                    cbx_efekti.Text = String.Empty;
                    cbx_efekti.SelectedText = "--select--";
                    tbx_uzrast.Text = String.Empty;
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
