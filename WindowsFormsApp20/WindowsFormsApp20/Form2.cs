using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "yeşil";
            rb2.hiz = 140;
            rb2.durum = 'i';
            rb2.fiyat = 35850;
            rb2.motor = 1222.56;
            rb2.YIl = -13311;
            rb2.MARKASI = "golf";
            rb2.muayene = 2017;
            rb2.plaka = "58 SE 2020";
            rb2.sahip = "Zehra Aydın";
            label1.Text = rb2.renk;
            label2.Text = rb2.hiz.ToString();
            label3.Text = rb2.motor.ToString();
            label4.Text = rb2.fiyat.ToString();
            label5.Text = rb2.durum.ToString();
            label6.Text = rb2.YIl.ToString();
            label7.Text = rb2.MARKASI;
            label8.Text = rb2.muayene.ToString();
            label9.Text = rb2.plaka.ToString();
            label10.Text = rb2.sahip;
            pictureBox1.BackColor = Color.Green;
        }
    }
}
