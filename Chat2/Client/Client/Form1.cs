using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm = (Form2)this.Owner;
            frm.Show();
        }

        string site1 = "https://www.amdm.ru/search/?q=";
        private void button1_Click(object sender, EventArgs e)
        {
            webControl1.Source = new Uri(site1 + textBox1.Text);
          //  webBrowser1.Navigate(site1 + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
