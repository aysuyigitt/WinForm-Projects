using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temel_arac_kullanımları
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //Değişkenlerin Araçlarla Kullanımı
        private void button3_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, ort;
            string durum;
            s1 = Convert.ToInt16(TxtSinav1.Text);
            s2 = Convert.ToInt16(TxtSinav2.Text);
            s3 = Convert.ToInt16(TxtSinav3.Text);
            ort = (s1 + s2 + s3) / 3;
            TxtOrtalama.Text = ort.ToString();
            //Değişkenler ile Karar Yapısı Kullanımı
            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "kaldı";
            }
            TxtDurum.Text = durum;
        }
        //Öğrenci Bilgilerinin Listbox Aracına Aktarılması
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtDurum.Text != "" && TxtOrtalama.Text != "")
            {
                string adsoyad, ders, numara;
                adsoyad = TxtAdSoyad.Text;
                ders = comboBox1.Text;
                numara = maskedTextBox1.Text;
                listBox1.Items.Add(adsoyad + " " + ders + "Numara: " + numara + "Ortalama: " + TxtOrtalama.Text + "Durum: " + TxtDurum.Text);
            }
            else
            {
                MessageBox.Show("Lütfen durum ve ortalama hesaplamayı yapınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("--------------------------------------");
        }
        //Araçları Temizleme İşlemi
        private void button4_Click(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = "";
            TxtDurum.Text = "";
            TxtOrtalama.Text = "";
            TxtSinav1.Text = "";
            TxtSinav2.Text = "";
            TxtSinav3.Text = "";
            comboBox1.SelectedIndex = -1;
            maskedTextBox1.Text = "";


        }
        //MessageBox
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya Derslerimiz Devam Ediyor", "Mesaj Kutusu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                listBox2.Items.Add(i + "-Merhaba");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            for(int i = 1; i <= 20; i++)
            {
                if (i%3==0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void btnListBoxTemizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int x = 0;
            while (x <= 10)
            {
                listBox2.Items.Add(x+ "-While Döngüsü");
                x++;
            }
        }

        private void btnDizi1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "adana", "ankara", "istanbul", "manisa", "sakarya" };
            TxtAdSoyad.Text = sehirler[4];
        }

        private void btnDizi2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 34, 66, 87, 32, 98, 104, 327, 78 }; ;
            //for(int i = 0; i < sayilar.Length; i++)
           // {
              //  listBox2.Items.Add(sayilar[i]);
           // }
           foreach(int k in sayilar)
            {
                if (k%4==0)
                {
                    listBox2.Items.Add(k);
                }
            }
        }
    }
}
