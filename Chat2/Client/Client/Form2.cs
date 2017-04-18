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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            
            f1.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form f2 = new ChatForm();
            f2.Show(this);
            this.Hide();
        }
    }
}
