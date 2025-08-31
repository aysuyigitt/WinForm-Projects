using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Tahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi;
        int skor;

        private void button1_Click(object sender, EventArgs e)
        {
            skor = 100;
            lblSkor.Text = "Skor : " + skor.ToString();
            //btnTahminEt.Enabled = true;
            Random rastgale = new Random();
            sayi = rastgale.Next(101);
            MessageBox.Show("Aklımdan bir sayı tuttum");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(txtTahmin.Text);
            if (tahmin < sayi)
            {
                MessageBox.Show("Yukarı");
                skor = skor - 10;
            }
            else if (sayi > tahmin)
            {
                MessageBox.Show("Aşağı");
                skor = skor - 10; ;
            }
            else
            {
                MessageBox.Show("Tebrikler");
            }
            if (skor == 0)
            {
                MessageBox.Show("GAME OVER!!!");
                //btnTahminEt.Enabled = false;
            }
            //lblSkor.Text = "Skor : " + skor.ToString();
            txtTahmin.Clear();
            }

        }
    }

