using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salon;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            salon.BiletSat(checkboxindirim.Checked);
            label3.Text = "Bilet Satıldı.Kalan koltuk sayısı" + salon.BosKoltukOgren();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text = "Salon oluşturuldu. Koltuk Sayısı : " + salon.BosKoltukOgren();
            }
            catch
            {
                label3.Text = "Salon oluşturulamadı.Bilggileri kontrol edin";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(checkboxindirim.Checked);
            label3.Text = "Bilet iptal edildi.Kalan koltuk sayısı :" + salon.BosKoltukOgren();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Şu anki bakiye :" + salon.BakiyeOgren()+"TL";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Boş koltuk sayısı" + salon.BosKoltukOgren();
        }
    }
}
