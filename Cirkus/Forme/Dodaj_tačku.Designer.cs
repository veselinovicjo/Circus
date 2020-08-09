namespace Cirkus.Forme
{
    partial class Dodaj_tačku
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
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_odustani = new System.Windows.Forms.Button();
            this.tbx_naziv_tačke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_uzrast = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_tip = new System.Windows.Forms.ComboBox();
            this.cbx_efekti = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(104, 359);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(92, 34);
            this.btn_dodaj.TabIndex = 13;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.Btn_dodaj_Click_1);
            // 
            // btn_odustani
            // 
            this.btn_odustani.Location = new System.Drawing.Point(257, 359);
            this.btn_odustani.Name = "btn_odustani";
            this.btn_odustani.Size = new System.Drawing.Size(92, 34);
            this.btn_odustani.TabIndex = 12;
            this.btn_odustani.Text = "Odustani";
            this.btn_odustani.UseVisualStyleBackColor = true;
            this.btn_odustani.Click += new System.EventHandler(this.Btn_odustani_Click_1);
            // 
            // tbx_naziv_tačke
            // 
            this.tbx_naziv_tačke.Location = new System.Drawing.Point(198, 84);
            this.tbx_naziv_tačke.Name = "tbx_naziv_tačke";
            this.tbx_naziv_tačke.Size = new System.Drawing.Size(184, 22);
            this.tbx_naziv_tačke.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naziv tačke:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unesite podatke o cirkuskoj predstavi, koju želite da dodate:";
            // 
            // tbx_uzrast
            // 
            this.tbx_uzrast.Location = new System.Drawing.Point(198, 245);
            this.tbx_uzrast.Name = "tbx_uzrast";
            this.tbx_uzrast.Size = new System.Drawing.Size(184, 22);
            this.tbx_uzrast.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Uzrast:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Efekti:";
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
            this.cbx_tip.Location = new System.Drawing.Point(198, 131);
            this.cbx_tip.Name = "cbx_tip";
            this.cbx_tip.Size = new System.Drawing.Size(184, 24);
            this.cbx_tip.TabIndex = 18;
            // 
            // cbx_efekti
            // 
            this.cbx_efekti.FormattingEnabled = true;
            this.cbx_efekti.Items.AddRange(new object[] {
            "opasne životinje",
            "vatra",
            "noževi",
            "nema"});
            this.cbx_efekti.Location = new System.Drawing.Point(198, 185);
            this.cbx_efekti.Name = "cbx_efekti";
            this.cbx_efekti.Size = new System.Drawing.Size(184, 24);
            this.cbx_efekti.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Polja sa oznakom * su obavezna.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "*";
            // 
            // Dodaj_tačku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(514, 431);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbx_efekti);
            this.Controls.Add(this.cbx_tip);
            this.Controls.Add(this.tbx_uzrast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_odustani);
            this.Controls.Add(this.tbx_naziv_tačke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "Dodaj_tačku";
            this.Text = "DodajTačku";
            this.Load += new System.EventHandler(this.Dodaj_tačku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_odustani;
        private System.Windows.Forms.TextBox tbx_naziv_tačke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_uzrast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_tip;
        private System.Windows.Forms.ComboBox cbx_efekti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}