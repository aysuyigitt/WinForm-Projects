
namespace Frm_Personell
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnEnDüşük = new System.Windows.Forms.Button();
            this.btnEnYüksek = new System.Windows.Forms.Button();
            this.btnİsim = new System.Windows.Forms.Button();
            this.btnArası = new System.Windows.Forms.Button();
            this.btnÖdenen = new System.Windows.Forms.Button();
            this.btnArttır = new System.Windows.Forms.Button();
            this.btnSonAd = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oluştur ve Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(62, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 276);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(426, 41);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(135, 99);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "ListBox Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(589, 41);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(135, 99);
            this.btnPersonel.TabIndex = 6;
            this.btnPersonel.Text = "Toplam Personel Sayısını Göster";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnEnDüşük
            // 
            this.btnEnDüşük.Location = new System.Drawing.Point(763, 41);
            this.btnEnDüşük.Name = "btnEnDüşük";
            this.btnEnDüşük.Size = new System.Drawing.Size(135, 99);
            this.btnEnDüşük.TabIndex = 7;
            this.btnEnDüşük.Text = "En Düşük Maaşı Göster";
            this.btnEnDüşük.UseVisualStyleBackColor = true;
            this.btnEnDüşük.Click += new System.EventHandler(this.btnEnDüşük_Click);
            // 
            // btnEnYüksek
            // 
            this.btnEnYüksek.Location = new System.Drawing.Point(426, 169);
            this.btnEnYüksek.Name = "btnEnYüksek";
            this.btnEnYüksek.Size = new System.Drawing.Size(135, 99);
            this.btnEnYüksek.TabIndex = 8;
            this.btnEnYüksek.Text = "En Yüksek Maaşlı Personelin Adını Göster";
            this.btnEnYüksek.UseVisualStyleBackColor = true;
            this.btnEnYüksek.Click += new System.EventHandler(this.btnEnYüksek_Click);
            // 
            // btnİsim
            // 
            this.btnİsim.Location = new System.Drawing.Point(589, 169);
            this.btnİsim.Name = "btnİsim";
            this.btnİsim.Size = new System.Drawing.Size(135, 99);
            this.btnİsim.TabIndex = 9;
            this.btnİsim.Text = "Maaşı 4000$ den olan Personel İsimlerinin  Listele ";
            this.btnİsim.UseVisualStyleBackColor = true;
            this.btnİsim.Click += new System.EventHandler(this.btnİsim_Click);
            // 
            // btnArası
            // 
            this.btnArası.Location = new System.Drawing.Point(763, 169);
            this.btnArası.Name = "btnArası";
            this.btnArası.Size = new System.Drawing.Size(135, 99);
            this.btnArası.TabIndex = 10;
            this.btnArası.Text = "Maaşı 5000$-7000$ Arası Personel Sayısını Göster";
            this.btnArası.UseVisualStyleBackColor = true;
            this.btnArası.Click += new System.EventHandler(this.btnArası_Click);
            // 
            // btnÖdenen
            // 
            this.btnÖdenen.Location = new System.Drawing.Point(426, 302);
            this.btnÖdenen.Name = "btnÖdenen";
            this.btnÖdenen.Size = new System.Drawing.Size(135, 99);
            this.btnÖdenen.TabIndex = 11;
            this.btnÖdenen.Text = "Toplam Ödenen Maaş Tutarını Göster";
            this.btnÖdenen.UseVisualStyleBackColor = true;
            this.btnÖdenen.Click += new System.EventHandler(this.btnÖdenen_Click);
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(589, 300);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(135, 99);
            this.btnArttır.TabIndex = 12;
            this.btnArttır.Text = "Listedeki 3.Elemanın Maaşını 500$ Arttır";
            this.btnArttır.UseVisualStyleBackColor = true;
            this.btnArttır.Click += new System.EventHandler(this.btnArttır_Click);
            // 
            // btnSonAd
            // 
            this.btnSonAd.Location = new System.Drawing.Point(763, 300);
            this.btnSonAd.Name = "btnSonAd";
            this.btnSonAd.Size = new System.Drawing.Size(135, 99);
            this.btnSonAd.TabIndex = 13;
            this.btnSonAd.Text = "Son Personelin Adını Yazdır";
            this.btnSonAd.UseVisualStyleBackColor = true;
            this.btnSonAd.Click += new System.EventHandler(this.btnSonAd_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(506, 433);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(46, 17);
            this.lblSonuc.TabIndex = 14;
            this.lblSonuc.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(966, 475);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnSonAd);
            this.Controls.Add(this.btnArttır);
            this.Controls.Add(this.btnÖdenen);
            this.Controls.Add(this.btnArası);
            this.Controls.Add(this.btnİsim);
            this.Controls.Add(this.btnEnYüksek);
            this.Controls.Add(this.btnEnDüşük);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnEnDüşük;
        private System.Windows.Forms.Button btnEnYüksek;
        private System.Windows.Forms.Button btnİsim;
        private System.Windows.Forms.Button btnArası;
        private System.Windows.Forms.Button btnÖdenen;
        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.Button btnSonAd;
        private System.Windows.Forms.Label lblSonuc;
    }
}

