
namespace temel_arac_kullanımları
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.LabelAdSoyad = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelSinav1 = new System.Windows.Forms.Label();
            this.LabelSinav2 = new System.Windows.Forms.Label();
            this.LabelSinav3 = new System.Windows.Forms.Label();
            this.LabelOrtalama = new System.Windows.Forms.Label();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.LabelDurum = new System.Windows.Forms.Label();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnForDöngüsü = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnListBoxTemizle = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDizi1 = new System.Windows.Forms.Button();
            this.btnDizi2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Not Kayıt Sistemi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelAdSoyad
            // 
            this.LabelAdSoyad.AutoSize = true;
            this.LabelAdSoyad.Location = new System.Drawing.Point(50, 95);
            this.LabelAdSoyad.Name = "LabelAdSoyad";
            this.LabelAdSoyad.Size = new System.Drawing.Size(95, 25);
            this.LabelAdSoyad.TabIndex = 1;
            this.LabelAdSoyad.Text = "Ad Soyad:";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(151, 92);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(184, 31);
            this.TxtAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Algoritma",
            "Yapay Zeka",
            "Biçimsel Diller"});
            this.comboBox1.Location = new System.Drawing.Point(151, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // LabelSinav1
            // 
            this.LabelSinav1.AutoSize = true;
            this.LabelSinav1.Location = new System.Drawing.Point(401, 95);
            this.LabelSinav1.Name = "LabelSinav1";
            this.LabelSinav1.Size = new System.Drawing.Size(71, 25);
            this.LabelSinav1.TabIndex = 5;
            this.LabelSinav1.Text = "Sınav1:";
            // 
            // LabelSinav2
            // 
            this.LabelSinav2.AutoSize = true;
            this.LabelSinav2.Location = new System.Drawing.Point(401, 135);
            this.LabelSinav2.Name = "LabelSinav2";
            this.LabelSinav2.Size = new System.Drawing.Size(71, 25);
            this.LabelSinav2.TabIndex = 6;
            this.LabelSinav2.Text = "Sınav2:";
            // 
            // LabelSinav3
            // 
            this.LabelSinav3.AutoSize = true;
            this.LabelSinav3.Location = new System.Drawing.Point(401, 172);
            this.LabelSinav3.Name = "LabelSinav3";
            this.LabelSinav3.Size = new System.Drawing.Size(71, 25);
            this.LabelSinav3.TabIndex = 7;
            this.LabelSinav3.Text = "Sınav3:";
            this.LabelSinav3.Click += new System.EventHandler(this.label6_Click);
            // 
            // LabelOrtalama
            // 
            this.LabelOrtalama.AutoSize = true;
            this.LabelOrtalama.Location = new System.Drawing.Point(602, 101);
            this.LabelOrtalama.Name = "LabelOrtalama";
            this.LabelOrtalama.Size = new System.Drawing.Size(43, 25);
            this.LabelOrtalama.TabIndex = 8;
            this.LabelOrtalama.Text = "Ort:";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(478, 95);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(59, 31);
            this.TxtSinav1.TabIndex = 9;
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(478, 135);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(59, 31);
            this.TxtSinav2.TabIndex = 10;
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(478, 172);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(59, 31);
            this.TxtSinav3.TabIndex = 11;
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Enabled = false;
            this.TxtOrtalama.Location = new System.Drawing.Point(662, 101);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(59, 31);
            this.TxtOrtalama.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(223, 224);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(112, 45);
            this.buttonHesapla.TabIndex = 15;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 41);
            this.button4.TabIndex = 16;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 325);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(617, 179);
            this.listBox1.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Numara:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 175);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(184, 31);
            this.maskedTextBox1.TabIndex = 19;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // LabelDurum
            // 
            this.LabelDurum.AutoSize = true;
            this.LabelDurum.Location = new System.Drawing.Point(582, 138);
            this.LabelDurum.Name = "LabelDurum";
            this.LabelDurum.Size = new System.Drawing.Size(74, 25);
            this.LabelDurum.TabIndex = 20;
            this.LabelDurum.Text = "Durum:";
            // 
            // TxtDurum
            // 
            this.TxtDurum.Enabled = false;
            this.TxtDurum.Location = new System.Drawing.Point(662, 140);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(59, 31);
            this.TxtDurum.TabIndex = 21;
            this.TxtDurum.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 41);
            this.button3.TabIndex = 23;
            this.button3.Text = "Çizgi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(662, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 41);
            this.button5.TabIndex = 24;
            this.button5.Text = "Mesaj Kutusu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnForDöngüsü
            // 
            this.btnForDöngüsü.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForDöngüsü.Location = new System.Drawing.Point(85, 279);
            this.btnForDöngüsü.Name = "btnForDöngüsü";
            this.btnForDöngüsü.Size = new System.Drawing.Size(123, 36);
            this.btnForDöngüsü.TabIndex = 25;
            this.btnForDöngüsü.Text = "For Döngüsü";
            this.btnForDöngüsü.UseVisualStyleBackColor = true;
            this.btnForDöngüsü.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(635, 325);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(286, 179);
            this.listBox2.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(223, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 36);
            this.button6.TabIndex = 27;
            this.button6.Text = "For Döngüsü 2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // btnListBoxTemizle
            // 
            this.btnListBoxTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListBoxTemizle.Location = new System.Drawing.Point(359, 279);
            this.btnListBoxTemizle.Name = "btnListBoxTemizle";
            this.btnListBoxTemizle.Size = new System.Drawing.Size(123, 36);
            this.btnListBoxTemizle.TabIndex = 28;
            this.btnListBoxTemizle.Text = "ListBox Temizle";
            this.btnListBoxTemizle.UseVisualStyleBackColor = true;
            this.btnListBoxTemizle.Click += new System.EventHandler(this.btnListBoxTemizle_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWhile.Location = new System.Drawing.Point(499, 279);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(123, 36);
            this.btnWhile.TabIndex = 29;
            this.btnWhile.Text = "While Döngüsü";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDizi1
            // 
            this.btnDizi1.Location = new System.Drawing.Point(635, 279);
            this.btnDizi1.Name = "btnDizi1";
            this.btnDizi1.Size = new System.Drawing.Size(99, 32);
            this.btnDizi1.TabIndex = 30;
            this.btnDizi1.Text = "Dizi1";
            this.btnDizi1.UseVisualStyleBackColor = true;
            this.btnDizi1.Click += new System.EventHandler(this.btnDizi1_Click);
            // 
            // btnDizi2
            // 
            this.btnDizi2.Location = new System.Drawing.Point(740, 279);
            this.btnDizi2.Name = "btnDizi2";
            this.btnDizi2.Size = new System.Drawing.Size(99, 32);
            this.btnDizi2.TabIndex = 31;
            this.btnDizi2.Text = "Dizi2";
            this.btnDizi2.UseVisualStyleBackColor = true;
            this.btnDizi2.Click += new System.EventHandler(this.btnDizi2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 557);
            this.Controls.Add(this.btnDizi2);
            this.Controls.Add(this.btnDizi1);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnListBoxTemizle);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnForDöngüsü);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtDurum);
            this.Controls.Add(this.LabelDurum);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtOrtalama);
            this.Controls.Add(this.TxtSinav3);
            this.Controls.Add(this.TxtSinav2);
            this.Controls.Add(this.TxtSinav1);
            this.Controls.Add(this.LabelOrtalama);
            this.Controls.Add(this.LabelSinav3);
            this.Controls.Add(this.LabelSinav2);
            this.Controls.Add(this.LabelSinav1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.LabelAdSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelAdSoyad;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelSinav1;
        private System.Windows.Forms.Label LabelSinav2;
        private System.Windows.Forms.Label LabelSinav3;
        private System.Windows.Forms.Label LabelOrtalama;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label LabelDurum;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnForDöngüsü;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnListBoxTemizle;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDizi1;
        private System.Windows.Forms.Button btnDizi2;
    }
}