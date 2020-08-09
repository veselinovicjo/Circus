namespace Cirkus.Forme
{
    partial class Dodaj_grad
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
            this.tbx_naziv_grada = new System.Windows.Forms.TextBox();
            this.tbx_poštanski_broj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_opis = new System.Windows.Forms.TextBox();
            this.tbx_zemlja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(86, 359);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(92, 34);
            this.btn_dodaj.TabIndex = 13;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.Btn_dodaj_Click_1);
            // 
            // btn_odustani
            // 
            this.btn_odustani.Location = new System.Drawing.Point(243, 359);
            this.btn_odustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_odustani.Name = "btn_odustani";
            this.btn_odustani.Size = new System.Drawing.Size(92, 34);
            this.btn_odustani.TabIndex = 12;
            this.btn_odustani.Text = "Odustani";
            this.btn_odustani.UseVisualStyleBackColor = true;
            this.btn_odustani.Click += new System.EventHandler(this.Btn_odustani_Click_1);
            // 
            // tbx_naziv_grada
            // 
            this.tbx_naziv_grada.Location = new System.Drawing.Point(200, 134);
            this.tbx_naziv_grada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_naziv_grada.Name = "tbx_naziv_grada";
            this.tbx_naziv_grada.Size = new System.Drawing.Size(184, 22);
            this.tbx_naziv_grada.TabIndex = 11;
            // 
            // tbx_poštanski_broj
            // 
            this.tbx_poštanski_broj.Location = new System.Drawing.Point(200, 81);
            this.tbx_poštanski_broj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_poštanski_broj.Name = "tbx_poštanski_broj";
            this.tbx_poštanski_broj.Size = new System.Drawing.Size(184, 22);
            this.tbx_poštanski_broj.TabIndex = 10;
            this.tbx_poštanski_broj.TextChanged += new System.EventHandler(this.Tbx_poštanski_broj_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Naziv grada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Poštanski broj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unesite podatke o gradu, koji želite da dodate:";
            // 
            // tbx_opis
            // 
            this.tbx_opis.Location = new System.Drawing.Point(200, 246);
            this.tbx_opis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_opis.Name = "tbx_opis";
            this.tbx_opis.Size = new System.Drawing.Size(184, 22);
            this.tbx_opis.TabIndex = 17;
            // 
            // tbx_zemlja
            // 
            this.tbx_zemlja.Location = new System.Drawing.Point(200, 193);
            this.tbx_zemlja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_zemlja.Name = "tbx_zemlja";
            this.tbx_zemlja.Size = new System.Drawing.Size(184, 22);
            this.tbx_zemlja.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Opis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zemlja:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Polja sa oznakom * su obavezna.";
            // 
            // Dodaj_grad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(424, 414);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_opis);
            this.Controls.Add(this.tbx_zemlja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_odustani);
            this.Controls.Add(this.tbx_naziv_grada);
            this.Controls.Add(this.tbx_poštanski_broj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dodaj_grad";
            this.Text = "Dodaj_tačku";
            this.Load += new System.EventHandler(this.Dodaj_grad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_odustani;
        private System.Windows.Forms.TextBox tbx_naziv_grada;
        private System.Windows.Forms.TextBox tbx_poštanski_broj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_opis;
        private System.Windows.Forms.TextBox tbx_zemlja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}