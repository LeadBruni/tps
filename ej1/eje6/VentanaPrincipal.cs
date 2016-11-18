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
            intermedio1.iVentana = this;
            intermedio1.Show(tipoCuentaElegido);
            //instancia de form2 pasandole el valor del textbox
            //using (intermedio frm1 = new intermedio(btnTransferencia.Text))
            //{
            //    frm1.ShowDialog();
            //}
        }

        public void BtnCtaCorriente_Click(object sender, EventArgs e)
        {
            tipoCuentaElegido += "Cc";
            //MessageBox.Show();
           
            intermedio1.iVentana = this;
            intermedio1.Show(tipoCuentaElegido);
            //this.Enabled = false;

        }
        public void SetValor(string pValor)
        {
            this.valor = pValor;
        }
    }
}
