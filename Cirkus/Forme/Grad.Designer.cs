namespace Cirkus.Forme
{
    partial class Grad
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
            this.btn_ukloni_grad = new System.Windows.Forms.Button();
            this.btn_izmeni_grad = new System.Windows.Forms.Button();
            this.btn_dodaj_grad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_gradova = new System.Windows.Forms.ListView();
            this.poštanski_broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zemlja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_nazad
            // 
            this.btn_nazad.Location = new System.Drawing.Point(31, 476);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(99, 32);
            this.btn_nazad.TabIndex = 13;
            this.btn_nazad.Text = "Nazad";
            this.btn_nazad.UseVisualStyleBackColor = true;
            this.btn_nazad.Click += new System.EventHandler(this.Btn_nazad_Click_1);
            // 
            // btn_ukloni_grad
            // 
            this.btn_ukloni_grad.Location = new System.Drawing.Point(666, 315);
            this.btn_ukloni_grad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ukloni_grad.Name = "btn_ukloni_grad";
            this.btn_ukloni_grad.Size = new System.Drawing.Size(119, 48);
            this.btn_ukloni_grad.TabIndex = 12;
            this.btn_ukloni_grad.Text = "Ukloni grad";
            this.btn_ukloni_grad.UseVisualStyleBackColor = true;
            this.btn_ukloni_grad.Click += new System.EventHandler(this.Btn_ukloni_grad_Click);
            // 
            // btn_izmeni_grad
            // 
            this.btn_izmeni_grad.Location = new System.Drawing.Point(666, 219);
            this.btn_izmeni_grad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_izmeni_grad.Name = "btn_izmeni_grad";
            this.btn_izmeni_grad.Size = new System.Drawing.Size(119, 48);
            this.btn_izmeni_grad.TabIndex = 11;
            this.btn_izmeni_grad.Text = "Izmeni grad";
            this.btn_izmeni_grad.UseVisualStyleBackColor = true;
            this.btn_izmeni_grad.Click += new System.EventHandler(this.Btn_izmeni_grad_Click_1);
            // 
            // btn_dodaj_grad
            // 
            this.btn_dodaj_grad.Location = new System.Drawing.Point(666, 130);
            this.btn_dodaj_grad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dodaj_grad.Name = "btn_dodaj_grad";
            this.btn_dodaj_grad.Size = new System.Drawing.Size(119, 48);
            this.btn_dodaj_grad.TabIndex = 10;
            this.btn_dodaj_grad.Text = "Dodaj grad";
            this.btn_dodaj_grad.UseVisualStyleBackColor = true;
            this.btn_dodaj_grad.Click += new System.EventHandler(this.Btn_dodaj_grad_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odaberite grad:";
            // 
            // listView_gradova
            // 
            this.listView_gradova.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.poštanski_broj,
            this.naziv,
            this.zemlja,
            this.opis});
            this.listView_gradova.FullRowSelect = true;
            this.listView_gradova.Location = new System.Drawing.Point(31, 58);
            this.listView_gradova.Margin = new System.Windows.Forms.Padding(4);
            this.listView_gradova.Name = "listView_gradova";
            this.listView_gradova.Size = new System.Drawing.Size(616, 381);
            this.listView_gradova.TabIndex = 8;
            this.listView_gradova.UseCompatibleStateImageBehavior = false;
            this.listView_gradova.View = System.Windows.Forms.View.Details;
            // 
            // poštanski_broj
            // 
            this.poštanski_broj.Text = "Poštanski broj";
            this.poštanski_broj.Width = 125;
            // 
            // naziv
            // 
            this.naziv.Text = "Naziv";
            this.naziv.Width = 147;
            // 
            // zemlja
            // 
            this.zemlja.Text = "Zemlja";
            this.zemlja.Width = 156;
            // 
            // opis
            // 
            this.opis.Text = "Opis";
            this.opis.Width = 156;
            // 
            // Grad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(818, 554);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_ukloni_grad);
            this.Controls.Add(this.btn_izmeni_grad);
            this.Controls.Add(this.btn_dodaj_grad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_gradova);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Grad";
            this.Text = "Grad";
            this.Load += new System.EventHandler(this.Grad_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nazad;
        private System.Windows.Forms.Button btn_ukloni_grad;
        private System.Windows.Forms.Button btn_izmeni_grad;
        private System.Windows.Forms.Button btn_dodaj_grad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_gradova;
        private System.Windows.Forms.ColumnHeader poštanski_broj;
        private System.Windows.Forms.ColumnHeader naziv;
        private System.Windows.Forms.ColumnHeader zemlja;
        private System.Windows.Forms.ColumnHeader opis;
    }
}