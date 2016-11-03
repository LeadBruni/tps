using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje4
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text+= button1.Text + "\r\n";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text + "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text + "\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text + "\r\n";
        }
    }
}
