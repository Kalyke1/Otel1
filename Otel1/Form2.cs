using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Otel1
{
    public partial class Form2 : Form
    {   
        private Form1 loginForm = null;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form login)
        {
            loginForm = login as Form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void exit(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("message");
            string theDate = DateTime.Now.ToString("h:mm:ss tt");
            this.loginForm.label4.Text = (theDate+" "+"Last Save");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
