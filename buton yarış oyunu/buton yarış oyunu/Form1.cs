using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace buton_yarış_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            button1.Left += a.Next (0,10);
            button2.Left += a.Next (0,10);
            int x = this.ClientSize.Width;
            int y = this.ClientSize.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
            //hocam bulamadım forma sınırlama olayını kusura bakmayın!
        }
    }
}
