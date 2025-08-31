using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FrmÜrün
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = localhost; Initial Catalog = DbÜrün; Integrated Security = True");
        //ÜRÜN LİSTESİ(listeleme)
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select * from TBLÜRÜNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        //GÜNCELLEME İŞLEMİ
        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("update TBLÜRÜNLER set UrunAd=@p1,stok=@p2,AlısFiyat=@p3,SatısFiyat=@p4,Katogori=@p5 where UrunId=@p6", baglanti);
            komut5.Parameters.AddWithValue("@p1", txtAd.Text);
            komut5.Parameters.AddWithValue("@p2", nudStok.Value);
            komut5.Parameters.AddWithValue("@p3", txtAlıs.Text);
            komut5.Parameters.AddWithValue("@p4", txtSatıs.Text);
            komut5.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut5.Parameters.AddWithValue("@p", txtID.Text);
            baglanti.Close();
            MessageBox.Show("Ürün kgüncellemsi başarılı bir şekilde gerçekleştirildi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        //Yeni Ürün Ekleme İşlemi
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3=new SqlCommand("insert into TBLÜRÜNLER (UrunAd,Stok,AlısFiyat,SatısFiyat,Katogori) values(@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut3.Parameters.AddWithValue("@p1", txtAd.Text);
            komut3.Parameters.AddWithValue("@p2", nudStok.Value);
            komut3.Parameters.AddWithValue("@p3", decimal.Parse(txtAlıs.Text));
            komut3.Parameters.AddWithValue("@p4",decimal.Parse( txtSatıs.Text));
            komut3.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleştirildi");
        }
        //Kategorilerin Combobox Üzerinde Listelenmesi
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select * from TBLKATOGORİ", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dt2;//Data'daki değerleri combox'a atamış olduk
        }
        //Ürünleri Silme İşlemi
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("delete from TBLÜRÜNLER where UrunId=@p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", txtID.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silme başarılı bir şekilde gerçekleştirildi");
        }
    }
}
