using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuvvet_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int i;
            int kuvvet = 1;
            i = 1;
            while (i < 11) {
                kuvvet *= sayi;
                textBox2.Text += sayi+" üzeri " + i.ToString() + " = " + kuvvet.ToString() + "\r\n";
                i++;

            }
        }
    }
}
