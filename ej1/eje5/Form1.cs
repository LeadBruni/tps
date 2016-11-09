using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fachada Fachada = new Fachada();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void soloNumero(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxXPto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void radioBCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBCirculo.Checked)
            {
                labelRadio.Visible = true;
                textBoxRadio.Visible = true;
                labelP2.Visible = false;
                textBoxXPto2.Visible = false;
                textBoxYPto2.Visible = false;
                labelP3.Visible = false;
                textBoxXPto3.Visible = false;
                textBoxYPto3.Visible = false;
            }
        }

        private void radioBTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            labelRadio.Visible = false;
            textBoxRadio.Visible = false;
            labelP2.Visible = true;
            textBoxXPto2.Visible = true;
            textBoxYPto2.Visible = true;
            labelP3.Visible = true;
            textBoxXPto3.Visible = true;
            textBoxYPto3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p1X = Convert.ToDouble(textBoxXPto1);
            double p1Y = Convert.ToDouble(textBoxYPto1);
            double p2X = Convert.ToDouble(textBoxXPto2);
            double p2Y = Convert.ToDouble(textBoxYPto2);
            double p3X = Convert.ToDouble(textBoxXPto3);
            double p3Y = Convert.ToDouble(textBoxYPto3);

            if ((radioBTriangulo.Checked))
            {

                MessageBox.Show(Fachada.perimetroTriangulo(p1X,p1Y,p2X,p2Y,p3X,p3Y));
            }
        }
    }
}
