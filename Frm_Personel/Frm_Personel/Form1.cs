using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Personel
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //Dizi oluşturma ve listeleme
            personeller = new string[] { "Sema", "Mehmet", "Oktay", "Beyza", "Aslı" };
            maaslar = new int[] { 3900, 3800, 5100, 4500, 5500 };

            for (int i = 0; i < personeller.Length; i++)
            {
                listBox1.Items.Add(personeller[i] + "\t" + maaslar[i]);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            for (int i = 0; i < personeller.Length; i++)
            {
                if (aranan == personeller[i])
                {
                    MessageBox.Show("Personel Bulundu");
                }
                else
                {
                    MessageBox.Show("personel Bulunmadı");
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //ListBox Temizle
            listBox1.Items.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            lblSonuc.Text = "Toplam Personel Sayısı : " + personeller.Length;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //En Düşük Maaş
            int dusuk = maaslar[0];
            for(int i = 0; i < maaslar.Length; i++)
            {
                if (dusuk > maaslar[i])
                {
                    dusuk = maaslar[i];
                }
            }
            lblSonuc.Text = "En Dusuk Maas : " + dusuk;
        }        


