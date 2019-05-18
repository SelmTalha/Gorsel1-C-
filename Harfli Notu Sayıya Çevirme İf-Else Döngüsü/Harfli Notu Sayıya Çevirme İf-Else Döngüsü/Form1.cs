using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harfli_Notu_Sayıya_Çevirme_İf_Else_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string not;
            string yaziyla;
            yaziyla = textBox1.Text;
            switch (yaziyla) {
                case "A" :
                    not = "85-100";
                    break;
                case "B":
                    not = "70-84";
                    break;
                case "C":
                    not = "50-69";
                    break;
                case "D":
                    not = "30-49";
                    break;
                case "FF":
                    not = "0-29";
                    break;
                default:
                    not = "Harf Notu A,B,C,D,FF 'den biri olmalıdır.";
                    break;
            }
            textBox2.Text = not;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
