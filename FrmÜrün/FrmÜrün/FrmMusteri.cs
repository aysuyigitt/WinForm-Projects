using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmÜrün
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLMUSTERİTableAdapter tb = new DataSet1TableAdapters.TBLMUSTERİTableAdapter();
        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = tb.MusteriListesi();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tb.MüsteriEkle(txtAd.Text, txtSoyad.Text, txtŞehir.Text, decimal.Parse(txtBakiye.Text));
            MessageBox.Show("Müşteri Sisteme Kaydedildi");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            tb.MusteriSil(int.Parse(txtID.Text));
            MessageBox.Show("Müşteri Sistemden Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            tb.MüsteriGüncelleme(txtAd.Text, txtSoyad.Text, txtŞehir.Text, decimal.Parse(txtBakiye.Text), int.Parse(txtID.Text));
            MessageBox.Show("Müşteri Bilgileri Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RdbAd.Checked == true)
            {//  //Radio buton içersinde Ad radiosu seçtiysem
                dataGridView1.DataSource = tb.AdaGöreListele(txtAranacak.Text);
            }
            if (RdbSoyad.Checked == true)
            {
                dataGridView1.DataSource = tb.GetDataBy3(txtAranacak.Text);
            }
            if (RdbŞehir.Checked == true)
            {
                dataGridView1.DataSource = tb.GetDataBy4(txtAranacak.Text);
            }
        }
    }
}
