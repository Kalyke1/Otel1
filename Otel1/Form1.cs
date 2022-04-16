using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == ("123"))
            {
                if (textBox2.Text == ("123"))
                {
                    MessageBox.Show("Şifre Doğrulandı");
                    var form = new Form2();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı/Şifre yanlış");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı/Şifre yanlış");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}