namespace Cirkus
{
    partial class Predstava
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
            this.listView_predstave = new System.Windows.Forms.ListView();
            this.id_predstave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vreme_predstave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.broj_prodath_karata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dodaj_predstavu = new System.Windows.Forms.Button();
            this.btn_izmeni_predstavu = new System.Windows.Forms.Button();
            this.btn_ukloni_predstavu = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_predstave
            // 
            this.listView_predstave.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_predstave,
            this.vreme_predstave,
            this.broj_prodath_karata});
            this.listView_predstave.FullRowSelect = true;
            this.listView_predstave.Location = new System.Drawing.Point(20, 62);
            this.listView_predstave.Margin = new System.Windows.Forms.Padding(4);
            this.listView_predstave.Name = "listView_predstave";
            this.listView_predstave.Size = new System.Drawing.Size(532, 363);
            this.listView_predstave.TabIndex = 0;
            this.listView_predstave.UseCompatibleStateImageBehavior = false;
            this.listView_predstave.View = System.Windows.Forms.View.Details;
            // 
            // id_predstave
            // 
            this.id_predstave.Text = "ID predstave";
            this.id_predstave.Width = 125;
            // 
            // vreme_predstave
            // 
            this.vreme_predstave.Text = "Vreme predstave";
            this.vreme_predstave.Width = 147;
            // 
            // broj_prodath_karata
            // 
            this.broj_prodath_karata.Text = "Broj prodatih karata";
            this.broj_prodath_karata.Width = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite predstavu:";
            // 
            // btn_dodaj_predstavu
            // 
            this.btn_dodaj_predstavu.Location = new System.Drawing.Point(659, 84);
            this.btn_dodaj_predstavu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dodaj_predstavu.Name = "btn_dodaj_predstavu";
            this.btn_dodaj_predstavu.Size = new System.Drawing.Size(119, 48);
            this.btn_dodaj_predstavu.TabIndex = 2;
            this.btn_dodaj_predstavu.Text = "Dodaj predstavu";
            this.btn_dodaj_predstavu.UseVisualStyleBackColor = true;
            this.btn_dodaj_predstavu.Click += new System.EventHandler(this.btn_dodaj_predstavu_Click);
            // 
            // btn_izmeni_predstavu
            // 
            this.btn_izmeni_predstavu.Location = new System.Drawing.Point(659, 174);
            this.btn_izmeni_predstavu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_izmeni_predstavu.Name = "btn_izmeni_predstavu";
            this.btn_izmeni_predstavu.Size = new System.Drawing.Size(119, 48);
            this.btn_izmeni_predstavu.TabIndex = 3;
            this.btn_izmeni_predstavu.Text = "Izmeni predstavu";
            this.btn_izmeni_predstavu.UseVisualStyleBackColor = true;
            this.btn_izmeni_predstavu.Click += new System.EventHandler(this.btn_izmeni_predstavu_Click);
            // 
            // btn_ukloni_predstavu
            // 
            this.btn_ukloni_predstavu.Location = new System.Drawing.Point(659, 270);
            this.btn_ukloni_predstavu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ukloni_predstavu.Name = "btn_ukloni_predstavu";
            this.btn_ukloni_predstavu.Size = new System.Drawing.Size(119, 48);
            this.btn_ukloni_predstavu.TabIndex = 4;
            this.btn_ukloni_predstavu.Text = "Ukloni predstavu";
            this.btn_ukloni_predstavu.UseVisualStyleBackColor = true;
            this.btn_ukloni_predstavu.Click += new System.EventHandler(this.btn_ukloni_predstavu_Click);
            // 
            // btn_nazad
            // 
            this.btn_nazad.Location = new System.Drawing.Point(20, 455);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(99, 32);
            this.btn_nazad.TabIndex = 5;
            this.btn_nazad.Text = "Nazad";
            this.btn_nazad.UseVisualStyleBackColor = true;
            // 
            // Predstava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(823, 524);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_ukloni_predstavu);
            this.Controls.Add(this.btn_izmeni_predstavu);
            this.Controls.Add(this.btn_dodaj_predstavu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_predstave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Predstava";
            this.Text = "Predstava";
            this.Load += new System.EventHandler(this.Predstava_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_predstave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader id_predstave;
        private System.Windows.Forms.ColumnHeader vreme_predstave;
        private System.Windows.Forms.ColumnHeader broj_prodath_karata;
        private System.Windows.Forms.Button btn_dodaj_predstavu;
        private System.Windows.Forms.Button btn_izmeni_predstavu;
        private System.Windows.Forms.Button btn_ukloni_predstavu;
        private System.Windows.Forms.Button btn_nazad;
    }
}