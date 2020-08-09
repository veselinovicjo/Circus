namespace Cirkus.Forme
{
    partial class Dodaj_predstavu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_vreme_predstave = new System.Windows.Forms.TextBox();
            this.tbx_broj_prodatih_karata = new System.Windows.Forms.TextBox();
            this.btn_odustani = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_dodaj_cirkusku_tačku = new System.Windows.Forms.Button();
            this.btn_dodaj_grad = new System.Windows.Forms.Button();
            this.listView_cirkuske_tačke = new System.Windows.Forms.ListView();
            this.broj_tačke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naziv_tačke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.efekti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uzrast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_gradovi = new System.Windows.Forms.ListView();
            this.poštanski_broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zemlja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_od = new System.Windows.Forms.DateTimePicker();
            this.dtp_do = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite podatke o predstavi, koju želite da dodate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vreme predstave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj prodatih karata:";
            // 
            // tbx_vreme_predstave
            // 
            this.tbx_vreme_predstave.Location = new System.Drawing.Point(199, 77);
            this.tbx_vreme_predstave.Name = "tbx_vreme_predstave";
            this.tbx_vreme_predstave.Size = new System.Drawing.Size(184, 22);
            this.tbx_vreme_predstave.TabIndex = 3;
            // 
            // tbx_broj_prodatih_karata
            // 
            this.tbx_broj_prodatih_karata.Location = new System.Drawing.Point(199, 114);
            this.tbx_broj_prodatih_karata.Name = "tbx_broj_prodatih_karata";
            this.tbx_broj_prodatih_karata.Size = new System.Drawing.Size(184, 22);
            this.tbx_broj_prodatih_karata.TabIndex = 4;
            this.tbx_broj_prodatih_karata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_broj_prodatih_karata_KeyPress);
            // 
            // btn_odustani
            // 
            this.btn_odustani.Location = new System.Drawing.Point(523, 623);
            this.btn_odustani.Name = "btn_odustani";
            this.btn_odustani.Size = new System.Drawing.Size(92, 34);
            this.btn_odustani.TabIndex = 5;
            this.btn_odustani.Text = "Odustani";
            this.btn_odustani.UseVisualStyleBackColor = true;
            this.btn_odustani.Click += new System.EventHandler(this.btn_odustani_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(372, 623);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(92, 34);
            this.btn_dodaj.TabIndex = 6;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Izaberite cirkuske tačke koje će biti uključene u predstavu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Izaberite gradove u kojima će se održati predstava:";
            // 
            // btn_dodaj_cirkusku_tačku
            // 
            this.btn_dodaj_cirkusku_tačku.Location = new System.Drawing.Point(785, 238);
            this.btn_dodaj_cirkusku_tačku.Name = "btn_dodaj_cirkusku_tačku";
            this.btn_dodaj_cirkusku_tačku.Size = new System.Drawing.Size(127, 73);
            this.btn_dodaj_cirkusku_tačku.TabIndex = 11;
            this.btn_dodaj_cirkusku_tačku.Text = "Dodaj novu cirkusku tačku";
            this.btn_dodaj_cirkusku_tačku.UseVisualStyleBackColor = true;
            this.btn_dodaj_cirkusku_tačku.Click += new System.EventHandler(this.Btn_dodaj_cirkusku_tačku_Click);
            // 
            // btn_dodaj_grad
            // 
            this.btn_dodaj_grad.Location = new System.Drawing.Point(785, 442);
            this.btn_dodaj_grad.Name = "btn_dodaj_grad";
            this.btn_dodaj_grad.Size = new System.Drawing.Size(127, 73);
            this.btn_dodaj_grad.TabIndex = 12;
            this.btn_dodaj_grad.Text = "Dodaj novi grad";
            this.btn_dodaj_grad.UseVisualStyleBackColor = true;
            this.btn_dodaj_grad.Click += new System.EventHandler(this.Btn_dodaj_grad_Click);
            // 
            // listView_cirkuske_tačke
            // 
            this.listView_cirkuske_tačke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.broj_tačke,
            this.naziv_tačke,
            this.tip,
            this.efekti,
            this.uzrast});
            this.listView_cirkuske_tačke.FullRowSelect = true;
            this.listView_cirkuske_tačke.HideSelection = false;
            this.listView_cirkuske_tačke.Location = new System.Drawing.Point(32, 206);
            this.listView_cirkuske_tačke.Name = "listView_cirkuske_tačke";
            this.listView_cirkuske_tačke.Size = new System.Drawing.Size(696, 143);
            this.listView_cirkuske_tačke.TabIndex = 15;
            this.listView_cirkuske_tačke.UseCompatibleStateImageBehavior = false;
            this.listView_cirkuske_tačke.View = System.Windows.Forms.View.Details;
            // 
            // broj_tačke
            // 
            this.broj_tačke.Text = "Broj tačke";
            this.broj_tačke.Width = 100;
            // 
            // naziv_tačke
            // 
            this.naziv_tačke.Text = "Naziv tačke";
            this.naziv_tačke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.naziv_tačke.Width = 100;
            // 
            // tip
            // 
            this.tip.Text = "Tip";
            this.tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tip.Width = 100;
            // 
            // efekti
            // 
            this.efekti.Text = "Efekti";
            this.efekti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.efekti.Width = 100;
            // 
            // uzrast
            // 
            this.uzrast.Text = "Uzrast";
            this.uzrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uzrast.Width = 100;
            // 
            // listView_gradovi
            // 
            this.listView_gradovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.poštanski_broj,
            this.naziv,
            this.zemlja,
            this.opis});
            this.listView_gradovi.FullRowSelect = true;
            this.listView_gradovi.HideSelection = false;
            this.listView_gradovi.Location = new System.Drawing.Point(32, 407);
            this.listView_gradovi.Name = "listView_gradovi";
            this.listView_gradovi.Size = new System.Drawing.Size(696, 153);
            this.listView_gradovi.TabIndex = 16;
            this.listView_gradovi.UseCompatibleStateImageBehavior = false;
            this.listView_gradovi.View = System.Windows.Forms.View.Details;
            // 
            // poštanski_broj
            // 
            this.poštanski_broj.Text = "Poštanski broj";
            this.poštanski_broj.Width = 100;
            // 
            // naziv
            // 
            this.naziv.Text = "Naziv";
            this.naziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.naziv.Width = 100;
            // 
            // zemlja
            // 
            this.zemlja.Text = "Zemlja";
            this.zemlja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zemlja.Width = 100;
            // 
            // opis
            // 
            this.opis.Text = "Opis";
            this.opis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.opis.Width = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "od:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "do:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Izvodi se u periodu:";
            // 
            // dtp_od
            // 
            this.dtp_od.Location = new System.Drawing.Point(528, 77);
            this.dtp_od.Name = "dtp_od";
            this.dtp_od.Size = new System.Drawing.Size(200, 22);
            this.dtp_od.TabIndex = 20;
            // 
            // dtp_do
            // 
            this.dtp_do.Location = new System.Drawing.Point(528, 114);
            this.dtp_do.Name = "dtp_do";
            this.dtp_do.Size = new System.Drawing.Size(200, 22);
            this.dtp_do.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 596);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Polja sa oznakom * su obavezna.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "*";
            // 
            // Dodaj_predstavu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(972, 669);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_do);
            this.Controls.Add(this.dtp_od);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView_gradovi);
            this.Controls.Add(this.listView_cirkuske_tačke);
            this.Controls.Add(this.btn_dodaj_grad);
            this.Controls.Add(this.btn_dodaj_cirkusku_tačku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_odustani);
            this.Controls.Add(this.tbx_broj_prodatih_karata);
            this.Controls.Add(this.tbx_vreme_predstave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "Dodaj_predstavu";
            this.Text = "Dodaj_predstavu";
            this.Load += new System.EventHandler(this.Dodaj_predstavu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_vreme_predstave;
        private System.Windows.Forms.TextBox tbx_broj_prodatih_karata;
        private System.Windows.Forms.Button btn_odustani;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_dodaj_cirkusku_tačku;
        private System.Windows.Forms.Button btn_dodaj_grad;
        private System.Windows.Forms.ListView listView_cirkuske_tačke;
        private System.Windows.Forms.ColumnHeader broj_tačke;
        private System.Windows.Forms.ListView listView_gradovi;
        private System.Windows.Forms.ColumnHeader naziv_tačke;
        private System.Windows.Forms.ColumnHeader tip;
        private System.Windows.Forms.ColumnHeader efekti;
        private System.Windows.Forms.ColumnHeader uzrast;
        private System.Windows.Forms.ColumnHeader poštanski_broj;
        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader zemlja;
        private System.Windows.Forms.ColumnHeader opis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_od;
        private System.Windows.Forms.DateTimePicker dtp_do;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}