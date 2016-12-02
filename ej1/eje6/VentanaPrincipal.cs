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
           // this.Enabled = true;

        }

        public void btnCajaAhorro_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido += "Ca";
            hacerInvisibleVentPrinc();


            //intermedio1.iVentana = this;
            //intermedio1.Show(tipoCuentaElegido);
            //instancia de form2 pasandole el valor del textbox
            //using (intermedio frm1 = new intermedio(btnTransferencia.Text))
            //{
            //    frm1.ShowDialog();
            //}
        }

        public void BtnCtaCorriente_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido += "Cc";
            hacerInvisibleVentPrinc();

            //MessageBox.Show();

            //intermedio1.iVentana = this;
            //intermedio1.Show(tipoCuentaElegido);
            //this.Enabled = false;

        }
        public void SetValor(string pValor)
        {
            this.valor = pValor;
        }

        public void hacerVisibleVentPrinc()
        {
            groupBoxCuentas.Visible = true;
            groupBoxMovimientos.Visible = false;

            //btnCajaAhorro.Visible = true;
            //BtnCtaCorriente.Visible = true;

            //btnAcreditar.Visible = false;
            //btnDebitar.Visible = false;
            //btnTransferencia.Visible = false;
            //btnAtras.Visible = false;
        }

        public void hacerInvisibleVentPrinc()
        {
            groupBoxMovimientos.Visible = true;
            groupBoxCuentas.Visible = false;

            //btnCajaAhorro.Visible = false;
            //BtnCtaCorriente.Visible = false;

            //btnAcreditar.Visible = true;
            //btnDebitar.Visible = true;
            //btnTransferencia.Visible = true;
            //btnAtras.Visible = true;
        }


        public void hacerInvicibleInterme()
        {
            //btnTransferencia.Visible = false;
            //btnDebitar.Visible = false;
            //btnAcreditar.Visible = false;

            //button0.Visible = true;
            //button1.Visible = true;
            //button2.Visible = true;
            //button3.Visible = true;
            //button4.Visible = true;
            //button5.Visible = true;
            //button6.Visible = true;
            //button7.Visible = true;
            //button8.Visible = true;
            //button9.Visible = true;
            //button10.Visible = true;
            //buttonBorrar.Visible = true;
            //textBox1.Visible = true;
            //labelCA.Visible = true;
            //labelCC.Visible = true;
            groupBoxMovimientos.Visible = false;
            groupBoxOperacion.Visible = true;

            labelCA.Text = Convert.ToString(Fachada.saldoCajaAhorro());
            labelCC.Text = Convert.ToString(Fachada.saldoCuentaCorriente());
            
        }

        public void hacerVisibleInterme()
        {
            groupBoxMovimientos.Visible = true;
            groupBoxOperacion.Visible = false;

            //btnTransferencia.Visible = true;
            //btnDebitar.Visible = true;
            //btnAcreditar.Visible = true;

            //button0.Visible = false;
            //button1.Visible = false;
            //button2.Visible = false;
            //button3.Visible = false;
            //button4.Visible = false;
            //button5.Visible = false;
            //button6.Visible = false;
            //button7.Visible = false;
            //button8.Visible = false;
            //button9.Visible = false;
            //button10.Visible = false;
            //buttonBorrar.Visible = false;
            //textBox1.Visible = false;
            //labelCA.Visible = false;
            //labelCC.Visible = false;
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
                //if ((Fachada.saldoCajaAhorro)>  0)
                //{

                    switch (tipoCuentaElegido)
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
                textBox1.Text = String.Empty;
                labelCA.Text = Convert.ToString(Fachada.saldoCajaAhorro());
                labelCC.Text = Convert.ToString(Fachada.saldoCuentaCorriente());
            }
        //}

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
