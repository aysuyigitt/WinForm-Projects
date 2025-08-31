using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Mevsim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İlkbahar");
            comboBox1.Items.Add("Yaz");
            comboBox1.Items.Add("Sonbahar");
            comboBox1.Items.Add("Kış");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("Mart");
                listBox1.Items.Add("Nisan");
                listBox1.Items.Add("Mayıs");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("Haziran");
                listBox1.Items.Add("Temmuz");
                listBox1.Items.Add("Ağustos");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add("Eylül");
                listBox1.Items.Add("Ekim");
                listBox1.Items.Add("Kasım");
            }
            else if(comboBox1.SelectedIndex==3)
            {
                listBox1.Items.Add("Aralık");
                listBox1.Items.Add("Ocak");
                listBox1.Items.Add("Şubat");
            }
        }
    }
}
