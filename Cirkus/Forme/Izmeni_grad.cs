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
    public partial class Izmeni_grad : Form
    {
        //private int poštanski_broj;

        public Izmeni_grad()
        {
            InitializeComponent();
        }

        public Izmeni_grad(GradPregled grad)
        {
            InitializeComponent();
            lbl_poštanski_broj.Text = grad.poštanski_broj.ToString();
            tbx_naziv_grada.Text = grad.naziv;
            tbx_zemlja.Text = grad.zemlja;
            tbx_opis.Text = grad.opis;
        }

        private void Btn_sačuvaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                    return;
                GradPregled grad = new GradPregled();
                //grad.poštanski_broj = int.Parse(tbx_poštanski_broj.Text);
                grad.naziv = tbx_naziv_grada.Text;
                grad.zemlja = tbx_zemlja.Text;
                grad.opis = tbx_opis.Text;
                grad.poštanski_broj = int.Parse(lbl_poštanski_broj.Text);

                try
                {
                    if (DTOManager.Izmeni_grad(grad))
                    {
                        DialogResult dialog = MessageBox.Show("Uspešno su ažurirani podaci o gradu!");
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

        private void Izmeni_grad_Load(object sender, EventArgs e)
        {

        }

        private bool Validacija()
        {
            if (String.IsNullOrEmpty(tbx_naziv_grada.Text))
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
