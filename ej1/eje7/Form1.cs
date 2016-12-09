using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje7
{
    public partial class Form1 : Form
    {
        ControladorFachada fachada;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (textBoxIngresarText.Text!=string.Empty)
            {
                textBDesencrip.Text = textBoxIngresarText.Text;
                textBEncrip.Text = fachada.EncriptarCadena(textBoxIngresarText.Text, Convert.ToString(comboBoxEncriptadores.SelectedItem));
                MessageBox.Show("Encriptado");
            }
            else { MessageBox.Show("Ingrese texto por favor"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fachada = new ControladorFachada();
            comboBoxEncriptadores.DataSource = new string[] { "AES", "Cesar", "Null", "Nuestro" };
            
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            if (textBoxIngresarText.Text != string.Empty)
            {
                textBEncrip.Text = textBoxIngresarText.Text;
                textBDesencrip.Text = fachada.DesencriptarCadena(textBoxIngresarText.Text, Convert.ToString(comboBoxEncriptadores.SelectedItem));
                MessageBox.Show("Desencriptado");
            }
            else { MessageBox.Show("Ingrese texto por favor"); }
        }
    }
}
