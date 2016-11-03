using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string opSeleccionada = "";
            if (radioButton1.Checked) { opSeleccionada =" "+ radioButton1.Name; }
            else if(radioButton2.Checked) { opSeleccionada = " " + radioButton2.Name; }
            else if(radioButton3.Checked) { opSeleccionada = " " + radioButton3.Name; }
            if (checkBox1.Checked) { opSeleccionada += " " + checkBox1.Name; }
            if (checkBox2.Checked) { opSeleccionada += " " + checkBox2.Name; }
            if (opSeleccionada == "") { opSeleccionada = "No eligio ninguna opcion"; }
            else opSeleccionada = "Eligio" + opSeleccionada;
            
            MessageBox.Show(opSeleccionada);

        }


    }
}
