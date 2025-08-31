using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Personell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int indeks = 0;
        string[] personeller;
        int[] maaslar;

        private void button1_Click(object sender, EventArgs e)
        {
            //Dizi Oluşturma ve Listeleme
            personeller = new string[] { "sema", "aylin", "burak", "doruk", "defne" };
            maaslar = new int[] { 3900, 3800, 5100, 4500, 5500 };

            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Personel Arama
            string aranan = textBox1.Text;
            bool bulundu = false;

            for (int i = 0; i < personeller.Length; i++)
            {
                if (aranan == personeller[i])
                {
                    bulundu = true;
                    listBox1.SelectedIndex = i;
                    break;
                }
            }
            if (bulundu)
            {
                MessageBox.Show("personel bulundu");
            }
            else
            {
                MessageBox.Show("personel bulunamadı");
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //listBox Temizle
            listBox1.Items.Clear();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            lblSonuc.Text = "Toplam Personel Sayısı : " + personeller.Length;
        }

        private void btnEnDüşük_Click(object sender, EventArgs e)
        {
            //En Düşük Maaş
            int dusuk = maaslar[0];
            for (int i = 0; i < personeller.Length; i++)
            {
                if (dusuk > maaslar[i])
                {
                    dusuk = maaslar[i];
                }
            }
            lblSonuc.Text = "En Düşük Maaş : " + dusuk;
        }

        private void btnEnYüksek_Click(object sender, EventArgs e)
        {
            //En Düşük Maaşlı Personel Adı
            int yuksek = maaslar[0];
            int yuksekIndex = 0;
            for (int i = 0; i < personeller.Length; i++)
            {
                if (yuksek < maaslar[i])
                {
                    yuksek = maaslar[i];
                    yuksekIndex = i;
                }
            }
            lblSonuc.Text = "En yüksek Maaş Alan :" + personeller[yuksekIndex];
        }

        private void btnİsim_Click(object sender, EventArgs e)
        {
            //Maaşı 4000 den az personel listesi
            for (int i = 0; i < maaslar.Length; i++)
            {
                if (maaslar[i] < 4000)
                {
                    listBox1.Items.Add(personeller[i] + ">>" + maaslar[i]);
                }
            }
        }

        private void btnArası_Click(object sender, EventArgs e)
        {
            //Maaşı 5000-7000 arası personel sayısı
            int sayac = 0;
            for(int i = 0; i < personeller.Length; i++)
            {
                if (maaslar[i] >= 5000 && maaslar[i] <= 7000)
                {
                    sayac++;
                }
            }
            lblSonuc.Text = "5000-700 arası maas alan sayısı : " + sayac;
        }

        private void btnÖdenen_Click(object sender, EventArgs e)
        {
            //Toplam Ödenen Maaşı Göster
            int toplam=0;
            for(int i = 0; i < personeller.Length; i++)
            {
                toplam += maaslar[i]
;            }
            lblSonuc.Text = "Toplam Maaş : " + toplam;
        }

        private void btnArttır_Click(object sender, EventArgs e)
        {
            //3 nolu personelin maasını 500 arttır
            listBox1.Items.Clear();
            maaslar[2] += 500;
            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }

        private void btnSonAd_Click(object sender, EventArgs e)
        {
            //Son personelin adını yazdır
            MessageBox.Show(personeller[4]);
        }
    }
}