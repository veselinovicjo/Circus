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
    public partial class Dodaj_grad : Form
    {
        public Dodaj_grad()
        {
            InitializeComponent();
        }

        private void Btn_dodaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                    return;

                if (DTOManager.Dodaj_grad(int.Parse(tbx_poštanski_broj.Text), tbx_naziv_grada.Text, tbx_zemlja.Text, tbx_opis.Text))
                {
                    MessageBox.Show("Uspešno ste dodali grad!");
                    tbx_poštanski_broj.Text = String.Empty;
                    tbx_naziv_grada.Text = String.Empty;
                    tbx_zemlja.Text = String.Empty;
                    tbx_opis.Text = String.Empty;
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

        private void Tbx_poštanski_broj_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Dodaj_grad_Load(object sender, EventArgs e)
        {

        }

        private void Tbx_poštanski_broj_TextChanged(object sender, EventArgs e)
        {

        }
        private bool Validacija()
        {
            if (String.IsNullOrEmpty(tbx_poštanski_broj.Text))
            {
                MessageBox.Show("Morate uneti poštanski broj grada.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else if (String.IsNullOrEmpty(tbx_naziv_grada.Text))
            {
                MessageBox.Show("Morate uneti naziv grada.", "Obavestenje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else
                return true;
        }
    }
}

