namespace Cirkus.Forme
{
    partial class Izmeni_tačku
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
            this.btn_sačuvaj = new System.Windows.Forms.Button();
            this.btn_odustani = new System.Windows.Forms.Button();
            this.tbx_naziv_tačke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_uzrast = new System.Windows.Forms.TextBox();
            this.cbx_efekti = new System.Windows.Forms.ComboBox();
            this.cbx_tip = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_broj_tačke = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sačuvaj
            // 
            this.btn_sačuvaj.Location = new System.Drawing.Point(120, 399);
            this.btn_sačuvaj.Name = "btn_sačuvaj";
            this.btn_sačuvaj.Size = new System.Drawing.Size(92, 34);
            this.btn_sačuvaj.TabIndex = 20;
            this.btn_sačuvaj.Text = "Sačuvaj";
            this.btn_sačuvaj.UseVisualStyleBackColor = true;
            this.btn_sačuvaj.Click += new System.EventHandler(this.Btn_sačuvaj_Click_1);
            // 
            // btn_odustani
            // 
            this.btn_odustani.Location = new System.Drawing.Point(273, 399);
            this.btn_odustani.Name = "btn_odustani";
            this.btn_odustani.Size = new System.Drawing.Size(92, 34);
            this.btn_odustani.TabIndex = 19;
            this.btn_odustani.Text = "Odustani";
            this.btn_odustani.UseVisualStyleBackColor = true;
            this.btn_odustani.Click += new System.EventHandler(this.Btn_odustani_Click_1);
            // 
            // tbx_naziv_tačke
            // 
            this.tbx_naziv_tačke.Location = new System.Drawing.Point(210, 145);
            this.tbx_naziv_tačke.Name = "tbx_naziv_tačke";
            this.tbx_naziv_tačke.Size = new System.Drawing.Size(184, 22);
            this.tbx_naziv_tačke.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Naziv tačke:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Unesite podatke o cirkuskoj tački, koju želite da izmenite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Uzrast:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Efekti:";
            // 
            // tbx_uzrast
            // 
            this.tbx_uzrast.Location = new System.Drawing.Point(210, 301);
            this.tbx_uzrast.Name = "tbx_uzrast";
            this.tbx_uzrast.Size = new System.Drawing.Size(184, 22);
            this.tbx_uzrast.TabIndex = 24;
            // 
            // cbx_efekti
            // 
            this.cbx_efekti.FormattingEnabled = true;
            this.cbx_efekti.Items.AddRange(new object[] {
            "opasne životinje",
            "vatra",
            "noževi",
            "nema"});
            this.cbx_efekti.Location = new System.Drawing.Point(210, 248);
            this.cbx_efekti.Name = "cbx_efekti";
            this.cbx_efekti.Size = new System.Drawing.Size(184, 24);
            this.cbx_efekti.TabIndex = 26;
            // 
            // cbx_tip
            // 
            this.cbx_tip.FormattingEnabled = true;
            this.cbx_tip.Items.AddRange(new object[] {
            "akrobatska",
            "žonglerska",
            "dresura",
            "klovnovski nastup",
            "gutanje plamena",
            "bacanje noževa"});
            this.cbx_tip.Location = new System.Drawing.Point(210, 194);
            this.cbx_tip.Name = "cbx_tip";
            this.cbx_tip.Size = new System.Drawing.Size(184, 24);
            this.cbx_tip.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Polja sa oznakom * su obavezna.";
            // 
            // lbl_broj_tačke
            // 
            this.lbl_broj_tačke.AutoSize = true;
            this.lbl_broj_tačke.Location = new System.Drawing.Point(207, 97);
            this.lbl_broj_tačke.Name = "lbl_broj_tačke";
            this.lbl_broj_tačke.Size = new System.Drawing.Size(0, 17);
            this.lbl_broj_tačke.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Broj tačke:";
            // 
            // Izmeni_tačku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(465, 446);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_broj_tačke);
            this.Controls.Add(this.cbx_efekti);
            this.Controls.Add(this.cbx_tip);
            this.Controls.Add(this.tbx_uzrast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sačuvaj);
            this.Controls.Add(this.btn_odustani);
            this.Controls.Add(this.tbx_naziv_tačke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "Izmeni_tačku";
            this.Text = "Izmeni_tačku";
            this.Load += new System.EventHandler(this.Izmeni_tačku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sačuvaj;
        private System.Windows.Forms.Button btn_odustani;
        private System.Windows.Forms.TextBox tbx_naziv_tačke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_uzrast;
        private System.Windows.Forms.ComboBox cbx_efekti;
        private System.Windows.Forms.ComboBox cbx_tip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_broj_tačke;
        private System.Windows.Forms.Label label11;
    }
}