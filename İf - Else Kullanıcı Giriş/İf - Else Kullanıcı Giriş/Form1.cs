using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İf___Else_Kullanıcı_Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kullanici=textBox1.Text;
            String sifre=textBox2.Text;
            if (kullanici == "selimtlh" && sifre == "selimtlh")
            {
                MessageBox.Show("Giriş Başarılı!");
            }
            else {
                MessageBox.Show("Kullanici adini veya şifreyi hatalı girdiniz!!");
            }
        }
    }
}
