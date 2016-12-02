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
    public partial class intermedio : Form
    {
        private string tipoTransferenciaElegida;

        private string valor;

        public VentanaPrincipal iVentana { get; set; }

        

        public intermedio()
        {
            InitializeComponent();
        }

        private void intermedio_Load(object sender, EventArgs e)
        {



            if (tipoTransferenciaElegida == "Cc")
            {
                btnTransferencia.Text = "Transferencia a Caja de Ahorro";
            }
        }

        public void Show(string pOption)
        {
            this.tipoTransferenciaElegida = pOption;
            this.Show();
                
        }
            
        private void btnTransferencia_Click(object sender, EventArgs e)
        {

            tipoTransferenciaElegida += "Tr";
            PonerNumeros Nums1 = new PonerNumeros();
            Nums1.iIntermedio = this;
                Nums1.Show(tipoTransferenciaElegida);
             
        }

        private void btnAcreditar_Click(object sender, EventArgs e)
        {
            tipoTransferenciaElegida += "Ac";
            PonerNumeros Nums1 = new PonerNumeros();
            Nums1.iIntermedio = this;
            Nums1.Show(tipoTransferenciaElegida);
        }

        private void btnDebitar_Click(object sender, EventArgs e)
        {
            tipoTransferenciaElegida += "De";
            PonerNumeros Nums1 = new PonerNumeros();
            Nums1.iIntermedio = this;
            Nums1.Show(tipoTransferenciaElegida);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            

            tipoTransferenciaElegida = tipoTransferenciaElegida.Substring(0, tipoTransferenciaElegida.Length - 2);
            this.iVentana.SetValor(tipoTransferenciaElegida);


            base.OnFormClosing(e);
            // Application.Restart();

            //private void intermedio_FormClosing(Object sender, FormClosingEventArgs e)
            //{
            //if (opcion != string.Empty)
            //{
            // }
        }


        public void SetValor(string pValor)
        {
            this.valor = pValor;
        }

        private void intermedio_Load_1(object sender, EventArgs e)
        {

        }
    }
}
