using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int toplam = sayi1 + sayi2;
                label4.Text = toplam.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi");
            }
            finally {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int fark = sayi1 - sayi2;
                label4.Text = fark.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);
                int carpim = sayi1 * sayi2;
                label4.Text = carpim.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float sayi1 = Convert.ToInt32(textBox1.Text);
                float sayi2 = Convert.ToInt32(textBox2.Text);
                float bolum = sayi1 / sayi2;
                label4.Text = bolum.ToString();
            }
            catch
            {
                MessageBox.Show("Hata Meydana Geldi");
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
