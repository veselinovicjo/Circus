namespace Cirkus.Forme
{
    partial class Osoblje
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
            this.btn_nazad = new System.Windows.Forms.Button();
            this.btn_ukloni_pomoćno_osoblje = new System.Windows.Forms.Button();
            this.btn_izmeni_pomoćno_osoblje = new System.Windows.Forms.Button();
            this.btn_dodaj_pomoćno_osoblje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_osoblje = new System.Windows.Forms.ListView();
            this.matični_broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datum_rođenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mesto_rođenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_nazad
            // 
            this.btn_nazad.Location = new System.Drawing.Point(32, 459);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(99, 32);
            this.btn_nazad.TabIndex = 13;
            this.btn_nazad.Text = "Nazad";
            this.btn_nazad.UseVisualStyleBackColor = true;
            // 
            // btn_ukloni_pomoćno_osoblje
            // 
            this.btn_ukloni_pomoćno_osoblje.Location = new System.Drawing.Point(936, 290);
            this.btn_ukloni_pomoćno_osoblje.Name = "btn_ukloni_pomoćno_osoblje";
            this.btn_ukloni_pomoćno_osoblje.Size = new System.Drawing.Size(119, 67);
            this.btn_ukloni_pomoćno_osoblje.TabIndex = 12;
            this.btn_ukloni_pomoćno_osoblje.Text = "Ukloni pomoćno osoblje";
            this.btn_ukloni_pomoćno_osoblje.UseVisualStyleBackColor = true;
            this.btn_ukloni_pomoćno_osoblje.Click += new System.EventHandler(this.Btn_ukloni_pomoćno_osoblje_Click);
            // 
            // btn_izmeni_pomoćno_osoblje
            // 
            this.btn_izmeni_pomoćno_osoblje.Location = new System.Drawing.Point(936, 194);
            this.btn_izmeni_pomoćno_osoblje.Name = "btn_izmeni_pomoćno_osoblje";
            this.btn_izmeni_pomoćno_osoblje.Size = new System.Drawing.Size(119, 67);
            this.btn_izmeni_pomoćno_osoblje.TabIndex = 11;
            this.btn_izmeni_pomoćno_osoblje.Text = "Izmeni pomoćno osoblje";
            this.btn_izmeni_pomoćno_osoblje.UseVisualStyleBackColor = true;
            this.btn_izmeni_pomoćno_osoblje.Click += new System.EventHandler(this.Btn_izmeni_pomoćno_osoblje_Click);
            // 
            // btn_dodaj_pomoćno_osoblje
            // 
            this.btn_dodaj_pomoćno_osoblje.Location = new System.Drawing.Point(936, 104);
            this.btn_dodaj_pomoćno_osoblje.Name = "btn_dodaj_pomoćno_osoblje";
            this.btn_dodaj_pomoćno_osoblje.Size = new System.Drawing.Size(119, 67);
            this.btn_dodaj_pomoćno_osoblje.TabIndex = 10;
            this.btn_dodaj_pomoćno_osoblje.Text = "Dodaj pomoćno osoblje";
            this.btn_dodaj_pomoćno_osoblje.UseVisualStyleBackColor = true;
            this.btn_dodaj_pomoćno_osoblje.Click += new System.EventHandler(this.Btn_dodaj_pomoćno_osoblje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odaberite predstavu:";
            // 
            // listView_osoblje
            // 
            this.listView_osoblje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matični_broj,
            this.ime,
            this.prezime,
            this.pol,
            this.datum_rođenja,
            this.mesto_rođenja});
            this.listView_osoblje.FullRowSelect = true;
            this.listView_osoblje.Location = new System.Drawing.Point(32, 48);
            this.listView_osoblje.Margin = new System.Windows.Forms.Padding(4);
            this.listView_osoblje.Name = "listView_osoblje";
            this.listView_osoblje.Size = new System.Drawing.Size(876, 377);
            this.listView_osoblje.TabIndex = 8;
            this.listView_osoblje.UseCompatibleStateImageBehavior = false;
            this.listView_osoblje.View = System.Windows.Forms.View.Details;
            // 
            // matični_broj
            // 
            this.matični_broj.Text = "Matični broj";
            this.matični_broj.Width = 156;
            // 
            // ime
            // 
            this.ime.Text = "Ime";
            this.ime.Width = 156;
            // 
            // prezime
            // 
            this.prezime.Text = "Prezime";
            this.prezime.Width = 156;
            // 
            // pol
            // 
            this.pol.Text = "Pol";
            // 
            // datum_rođenja
            // 
            this.datum_rođenja.Text = "Datum rođenja";
            this.datum_rođenja.Width = 156;
            // 
            // mesto_rođenja
            // 
            this.mesto_rođenja.Text = "Mesto rođenja";
            this.mesto_rođenja.Width = 156;
            // 
            // Osoblje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1077, 519);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_ukloni_pomoćno_osoblje);
            this.Controls.Add(this.btn_izmeni_pomoćno_osoblje);
            this.Controls.Add(this.btn_dodaj_pomoćno_osoblje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_osoblje);
            this.Name = "Osoblje";
            this.Text = "Pomoćno_osoblje";
            this.Load += new System.EventHandler(this.Osoblje_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nazad;
        private System.Windows.Forms.Button btn_ukloni_pomoćno_osoblje;
        private System.Windows.Forms.Button btn_izmeni_pomoćno_osoblje;
        private System.Windows.Forms.Button btn_dodaj_pomoćno_osoblje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_osoblje;
        private System.Windows.Forms.ColumnHeader matični_broj;
        private System.Windows.Forms.ColumnHeader ime;
        private System.Windows.Forms.ColumnHeader prezime;
        private System.Windows.Forms.ColumnHeader pol;
        private System.Windows.Forms.ColumnHeader datum_rođenja;
        private System.Windows.Forms.ColumnHeader mesto_rođenja;
    }
}