using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBüyükKücük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2, sayi3,EK,EB;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sayi3 = Convert.ToInt32(txtSayi3.Text);

            if (sayi1 > sayi2 && sayi1 > sayi3)
                EB = sayi1;
            else if (sayi2 > sayi1 && sayi2 > sayi3)
                EB = sayi2;
            else
                EB = sayi3;

            if (sayi1 < sayi2 && sayi1 < sayi3)
                EK = sayi1;
            else if (sayi2 < sayi1 && sayi2 < sayi3)
                EK = sayi2;
            else
                EK = sayi3;

            txtEnBuyuk.Text = EB.ToString();
            txtEnKucuk.Text = EK.ToString();
        }
    }
}
