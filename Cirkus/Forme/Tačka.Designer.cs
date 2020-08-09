namespace Cirkus.Forme
{
    partial class Tačka
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
            this.btn_ukloni_tačku = new System.Windows.Forms.Button();
            this.btn_izmeni_tačku = new System.Windows.Forms.Button();
            this.btn_dodaj_tačku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_tačke = new System.Windows.Forms.ListView();
            this.broj_tačke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naziv_tačke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.efekti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uzrast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_nazad
            // 
            this.btn_nazad.Location = new System.Drawing.Point(23, 470);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(99, 32);
            this.btn_nazad.TabIndex = 13;
            this.btn_nazad.Text = "Nazad";
            this.btn_nazad.UseVisualStyleBackColor = true;
            this.btn_nazad.Click += new System.EventHandler(this.Btn_nazad_Click_1);
            // 
            // btn_ukloni_tačku
            // 
            this.btn_ukloni_tačku.Location = new System.Drawing.Point(814, 271);
            this.btn_ukloni_tačku.Name = "btn_ukloni_tačku";
            this.btn_ukloni_tačku.Size = new System.Drawing.Size(119, 48);
            this.btn_ukloni_tačku.TabIndex = 12;
            this.btn_ukloni_tačku.Text = "Ukloni cirkusku tačku";
            this.btn_ukloni_tačku.UseVisualStyleBackColor = true;
            this.btn_ukloni_tačku.Click += new System.EventHandler(this.Btn_ukloni_tačku_Click);
            // 
            // btn_izmeni_tačku
            // 
            this.btn_izmeni_tačku.Location = new System.Drawing.Point(814, 175);
            this.btn_izmeni_tačku.Name = "btn_izmeni_tačku";
            this.btn_izmeni_tačku.Size = new System.Drawing.Size(119, 48);
            this.btn_izmeni_tačku.TabIndex = 11;
            this.btn_izmeni_tačku.Text = "Izmeni cirkusku tačku";
            this.btn_izmeni_tačku.UseVisualStyleBackColor = true;
            this.btn_izmeni_tačku.Click += new System.EventHandler(this.Btn_izmeni_tačku_Click_1);
            // 
            // btn_dodaj_tačku
            // 
            this.btn_dodaj_tačku.Location = new System.Drawing.Point(814, 85);
            this.btn_dodaj_tačku.Name = "btn_dodaj_tačku";
            this.btn_dodaj_tačku.Size = new System.Drawing.Size(119, 48);
            this.btn_dodaj_tačku.TabIndex = 10;
            this.btn_dodaj_tačku.Text = "Dodaj cirkusku tačku";
            this.btn_dodaj_tačku.UseVisualStyleBackColor = true;
            this.btn_dodaj_tačku.Click += new System.EventHandler(this.Btn_dodaj_tačku_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odaberite cirkusku tačku:";
            // 
            // listView_tačke
            // 
            this.listView_tačke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.broj_tačke,
            this.naziv_tačke,
            this.tip,
            this.efekti,
            this.uzrast});
            this.listView_tačke.FullRowSelect = true;
            this.listView_tačke.Location = new System.Drawing.Point(23, 65);
            this.listView_tačke.Margin = new System.Windows.Forms.Padding(4);
            this.listView_tačke.Name = "listView_tačke";
            this.listView_tačke.Size = new System.Drawing.Size(766, 369);
            this.listView_tačke.TabIndex = 8;
            this.listView_tačke.UseCompatibleStateImageBehavior = false;
            this.listView_tačke.View = System.Windows.Forms.View.Details;
            // 
            // broj_tačke
            // 
            this.broj_tačke.Text = "Broj tačke";
            this.broj_tačke.Width = 125;
            // 
            // naziv_tačke
            // 
            this.naziv_tačke.Text = "Naziv";
            this.naziv_tačke.Width = 147;
            // 
            // tip
            // 
            this.tip.Text = "Tip";
            this.tip.Width = 156;
            // 
            // efekti
            // 
            this.efekti.Text = "Efekti";
            this.efekti.Width = 156;
            // 
            // uzrast
            // 
            this.uzrast.Text = "Uzrast";
            this.uzrast.Width = 156;
            // 
            // Tačka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(984, 527);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_ukloni_tačku);
            this.Controls.Add(this.btn_izmeni_tačku);
            this.Controls.Add(this.btn_dodaj_tačku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_tačke);
            this.Name = "Tačka";
            this.Text = "Tačka";
            this.Load += new System.EventHandler(this.Tačka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nazad;
        private System.Windows.Forms.Button btn_ukloni_tačku;
        private System.Windows.Forms.Button btn_izmeni_tačku;
        private System.Windows.Forms.Button btn_dodaj_tačku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_tačke;
        private System.Windows.Forms.ColumnHeader broj_tačke;
        private System.Windows.Forms.ColumnHeader naziv_tačke;
        private System.Windows.Forms.ColumnHeader tip;
        private System.Windows.Forms.ColumnHeader efekti;
        private System.Windows.Forms.ColumnHeader uzrast;
    }
}