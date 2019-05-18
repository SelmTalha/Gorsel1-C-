using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İf_Else_Döngüsü
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
            if (sayi > 0 && sayi <= 100)
            {
                if (sayi < 40)
                {
                    MessageBox.Show("Kaldınız!");
                }
                else
                {
                    MessageBox.Show("Geçtiniz");
                }
            }
            else {
                MessageBox.Show("0-100 arası puan giriniz!");
            }
        }
    }
}
