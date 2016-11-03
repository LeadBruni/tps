using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new string[]  {" ","Uno","Dos","Tres","Cuatro","Cinco","Seis","Siete","Ocho","Nueve","Diez"};
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             string[] traduccion = new[] {"---","One","Two","Three","Four","Five","Six","Seven","Eigth","Nine","Ten" };
            labelTrad.Text = traduccion[comboBox1.SelectedIndex];
        }
    }
}
