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
                labelP1.Visible = false;
                textBoxXPto1.Visible = false;
                textBoxYPto1.Visible = false;
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
            labelP1.Visible = true;
            textBoxXPto1.Visible = true;
            textBoxYPto1.Visible = true;
            labelP2.Visible = true;
            textBoxXPto2.Visible = true;
            textBoxYPto2.Visible = true;
            labelP3.Visible = true;
            textBoxXPto3.Visible = true;
            textBoxYPto3.Visible = true;
        }

        private bool textBoxNoVacio(object sender)
        {
            if (string.IsNullOrEmpty(Text))
            {

                return false;
            }
            else return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if ((radioBTriangulo.Checked))
                {
                    double p1X = double.Parse(textBoxXPto1.Text);
                    double p1Y = double.Parse(textBoxYPto1.Text);
                    double p2X = double.Parse(textBoxXPto2.Text);
                    double p2Y = double.Parse(textBoxYPto2.Text);
                    double p3X = double.Parse(textBoxXPto3.Text);
                    double p3Y = double.Parse(textBoxYPto3.Text);
                    MessageBox.Show("El Perimetro del Tirangulo es: " + Convert.ToString(Fachada.perimetroTriangulo(p1X, p1Y, p2X, p2Y, p3X, p3Y)) + "\n El Area del Triangulo es: " + Convert.ToString(Fachada.areaTriangulo(p1X, p1Y, p2X, p2Y, p3X, p3Y)));
                }


                else if (radioBCirculo.Checked)
                {


                    double radio = double.Parse(textBoxRadio.Text);
                    MessageBox.Show("El Perimetro del Circulo es: " + Convert.ToString(Fachada.perimetroCirculo(radio)) + "\n El Area del Circulo es: " + Convert.ToString(Fachada.areaCirculo(radio)));
                }
            }
            catch (FormatException) { MessageBox.Show("Debe completar la informacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }


        }
    }
}
