namespace Cirkus.Forme
{
    partial class Životinje
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
            this.btn_ukloni_životinju = new System.Windows.Forms.Button();
            this.btn_izmeni_životinju = new System.Windows.Forms.Button();
            this.btn_dodaj_životinju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_životinja = new System.Windows.Forms.ListView();
            this.datum_dolaska = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.težina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.broj_kaveza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vrsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.starost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.veterinarski_pregled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_nazad
            // 
            this.btn_nazad.Location = new System.Drawing.Point(28, 466);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(99, 32);
            this.btn_nazad.TabIndex = 13;
            this.btn_nazad.Text = "Nazad";
            this.btn_nazad.UseVisualStyleBackColor = true;
            this.btn_nazad.Click += new System.EventHandler(this.Btn_nazad_Click_1);
            // 
            // btn_ukloni_životinju
            // 
            this.btn_ukloni_životinju.Location = new System.Drawing.Point(856, 236);
            this.btn_ukloni_životinju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ukloni_životinju.Name = "btn_ukloni_životinju";
            this.btn_ukloni_životinju.Size = new System.Drawing.Size(119, 48);
            this.btn_ukloni_životinju.TabIndex = 12;
            this.btn_ukloni_životinju.Text = "Ukloni životinju";
            this.btn_ukloni_životinju.UseVisualStyleBackColor = true;
            this.btn_ukloni_životinju.Click += new System.EventHandler(this.Btn_ukloni_životinju_Click);
            // 
            // btn_izmeni_životinju
            // 
            this.btn_izmeni_životinju.Location = new System.Drawing.Point(856, 150);
            this.btn_izmeni_životinju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_izmeni_životinju.Name = "btn_izmeni_životinju";
            this.btn_izmeni_životinju.Size = new System.Drawing.Size(119, 48);
            this.btn_izmeni_životinju.TabIndex = 11;
            this.btn_izmeni_životinju.Text = "Izmeni životinju";
            this.btn_izmeni_životinju.UseVisualStyleBackColor = true;
            this.btn_izmeni_životinju.Click += new System.EventHandler(this.Btn_izmeni_životinju_Click);
            // 
            // btn_dodaj_životinju
            // 
            this.btn_dodaj_životinju.Location = new System.Drawing.Point(856, 60);
            this.btn_dodaj_životinju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dodaj_životinju.Name = "btn_dodaj_životinju";
            this.btn_dodaj_životinju.Size = new System.Drawing.Size(119, 48);
            this.btn_dodaj_životinju.TabIndex = 10;
            this.btn_dodaj_životinju.Text = "Dodaj životinju";
            this.btn_dodaj_životinju.UseVisualStyleBackColor = true;
            this.btn_dodaj_životinju.Click += new System.EventHandler(this.Btn_dodaj_životinju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odaberite životinju:";
            // 
            // listView_životinja
            // 
            this.listView_životinja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.datum_dolaska,
            this.nadimak,
            this.težina,
            this.pol,
            this.broj_kaveza,
            this.vrsta,
            this.starost,
            this.veterinarski_pregled});
            this.listView_životinja.FullRowSelect = true;
            this.listView_životinja.Location = new System.Drawing.Point(28, 74);
            this.listView_životinja.Margin = new System.Windows.Forms.Padding(4);
            this.listView_životinja.Name = "listView_životinja";
            this.listView_životinja.Size = new System.Drawing.Size(803, 370);
            this.listView_životinja.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_životinja.TabIndex = 8;
            this.listView_životinja.UseCompatibleStateImageBehavior = false;
            this.listView_životinja.View = System.Windows.Forms.View.Details;
            this.listView_životinja.SelectedIndexChanged += new System.EventHandler(this.ListView_životinja_SelectedIndexChanged);
            // 
            // datum_dolaska
            // 
            this.datum_dolaska.Text = "Datum dolaska";
            this.datum_dolaska.Width = 98;
            // 
            // nadimak
            // 
            this.nadimak.Text = "Nadimak";
            this.nadimak.Width = 72;
            // 
            // težina
            // 
            this.težina.Text = "Težina";
            this.težina.Width = 65;
            // 
            // pol
            // 
            this.pol.Text = "Pol";
            this.pol.Width = 49;
            // 
            // broj_kaveza
            // 
            this.broj_kaveza.Text = "Broj kaveza";
            this.broj_kaveza.Width = 79;
            // 
            // vrsta
            // 
            this.vrsta.Text = "Vrsta";
            // 
            // starost
            // 
            this.starost.Text = "Starost";
            // 
            // veterinarski_pregled
            // 
            this.veterinarski_pregled.Text = "Veterinarski pregled";
            this.veterinarski_pregled.Width = 116;
            // 
            // Životinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1013, 511);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_ukloni_životinju);
            this.Controls.Add(this.btn_izmeni_životinju);
            this.Controls.Add(this.btn_dodaj_životinju);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_životinja);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Životinje";
            this.Text = "Životinje";
            this.Load += new System.EventHandler(this.Životinje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nazad;
        private System.Windows.Forms.Button btn_ukloni_životinju;
        private System.Windows.Forms.Button btn_izmeni_životinju;
        private System.Windows.Forms.Button btn_dodaj_životinju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_životinja;
        private System.Windows.Forms.ColumnHeader datum_dolaska;
        private System.Windows.Forms.ColumnHeader nadimak;
        private System.Windows.Forms.ColumnHeader težina;
        private System.Windows.Forms.ColumnHeader pol;
        private System.Windows.Forms.ColumnHeader broj_kaveza;
        private System.Windows.Forms.ColumnHeader vrsta;
        private System.Windows.Forms.ColumnHeader starost;
        private System.Windows.Forms.ColumnHeader veterinarski_pregled;
    }
}