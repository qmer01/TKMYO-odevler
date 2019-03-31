using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        int sayı1;
        int sayı2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            label1.Text = Convert.ToString(sayı1 + sayı2);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            label1.Text = Convert.ToString(sayı1 - sayı2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            label1.Text = Convert.ToString(sayı1 / sayı2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            label1.Text = Convert.ToString(sayı1 * sayı2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("HOŞGELDİNİZ");


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("YİNE BEKLERİZ");
        }
    }
}
