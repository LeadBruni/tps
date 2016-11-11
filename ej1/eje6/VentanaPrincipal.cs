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
        private object opcion;

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        public void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            opcion = string.Empty;
            labelFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void btnCajaAhorro_Click(object sender, EventArgs e)
        {
            opcion += "Ca";
        }

        private void BtnCtaCorriente_Click(object sender, EventArgs e)
        {
            opcion += "Cc";
            
        }
    }
}
