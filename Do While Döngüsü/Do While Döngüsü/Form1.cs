using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_While_Döngüsü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            while (a < 10 && a%2==0 ) {
                a+=1;
                listBox1.Items.Add(a);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1;
            do
            {
                a += 1;
                listBox1.Items.Add(a);
            } while (a < 10 &&a%2==0);
        }
    }
}
