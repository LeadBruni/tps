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
    public partial class VentanaPrincipal : Form
    {
        public string tipoCuentaElegido;
        private string valor;
        intermedio intermedio1 = new intermedio();
        Fachada Fachada = new Fachada();

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            tipoCuentaElegido = string.Empty;
            labelFecha.Text = DateTime.Now.ToLongDateString();
           
        }

        public void btnCajaAhorro_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido += "Ca";
            hacerInvisibleVentPrinc();


           
        }

        public void BtnCtaCorriente_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido += "Cc";
            hacerInvisibleVentPrinc();

            
        }
        public void SetValor(string pValor)
        {
            this.valor = pValor;
        }

        public void hacerVisibleVentPrinc()
        {
            groupBoxCuentas.Visible = true;
            groupBoxMovimientos.Visible = false;

            
        }

        public void hacerInvisibleVentPrinc()
        {
            groupBoxMovimientos.Visible = true;
            groupBoxCuentas.Visible = false;

            
        }


        public void hacerInvicibleInterme()
        {
            
            groupBoxMovimientos.Visible = false;
            groupBoxOperacion.Visible = true;

            labelCA.Text = Convert.ToString(Fachada.saldoCajaAhorro());
            labelCC.Text = Convert.ToString(Fachada.saldoCuentaCorriente());
            
        }

        public void hacerVisibleInterme()
        {
            groupBoxMovimientos.Visible = true;
            groupBoxOperacion.Visible = false;

            }


        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text += button1.Text;

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
                

                    switch (tipoCuentaElegido)
                    {
                        case "CcTr":
                            Fachada.transferirCuentaCaja(monto);
                            
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
                textBox1.Text = String.Empty;
                labelCA.Text = Convert.ToString(Fachada.saldoCajaAhorro());
                labelCC.Text = Convert.ToString(Fachada.saldoCuentaCorriente());
            }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido = tipoCuentaElegido.Substring(0, tipoCuentaElegido.Length - 2);
            if (tipoCuentaElegido == string.Empty)
            {
                btnAtras.Visible = false;
                hacerVisibleVentPrinc();
            }
            else
            {
                hacerVisibleInterme();
            }
        }

        private void btnAtrasMovimiento_Click(object sender, EventArgs e)
        {
           // tipoCuentaElegido = tipoCuentaElegido.Substring(0, tipoCuentaElegido.Length - 2);


        }



        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido += "Ac";
            hacerInvicibleInterme();
        }

        private void btnDebitar_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido += "De";
            hacerInvicibleInterme();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido += "Tr";
            hacerInvicibleInterme();
        }

        
    }
}
