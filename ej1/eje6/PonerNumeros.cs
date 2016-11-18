using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje6
{
    public partial class PonerNumeros : Form
    {
        private string opcion;

        public intermedio iIntermedio { get; set; }

        Fachada Fachada = new Fachada();

        public PonerNumeros()
        {
            InitializeComponent();
        }


        public void Show(string pOption)
        {
            this.opcion = pOption;
            this.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text+= button1.Text;

    }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                textBox1.Text += button0.Text;
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            { 
                double monto = double.Parse(textBox1.Text);
                switch (opcion)
                {
                    case "CcTr":
                        Fachada.transferirCuentaCaja(monto);
                        // MessageBox.Show("Cuenta Corriente: "+ Fachada.this);
                        break;

                    case "CcAc":
                        Fachada.acreditarsaldocuentaco(monto);
                        break;

                    case "CcDe":
                        Fachada.debitarsaldocuentaco(monto);
                        break;

                    case "CaTr":
                        Fachada.transferirCajaaCuenta(monto);
                        break;

                    case "CaAc":
                        Fachada.acreditarsaldocaja(monto);
                        break;

                    case "CaDe":
                        Fachada.debitarsaldocaja(monto);
                        break;
                }    
            }
            textBox1.Text =String.Empty;
            labelCA.Text = Convert.ToString(Fachada.saldoCajaAhorro());
            labelCC.Text = Convert.ToString(Fachada.saldoCuentaCorriente());
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            

            opcion = opcion.Substring(0, opcion.Length - 2);
           this.iIntermedio.SetValor(opcion);

            base.OnFormClosing(e);

            // Application.Restart();

            //  private void PonerNumeros_FormClosing(Object sender, FormClosingEventArgs e)
            // {
            // if (opcion != string.Empty)
            //{
            //}
        }

        private void PonerNumeros_Load(object sender, EventArgs e)
        {
        
        labelCA.Text = Convert.ToString(Fachada.saldoCajaAhorro());
            labelCC.Text = Convert.ToString(Fachada.saldoCuentaCorriente());
        }
    }
}
