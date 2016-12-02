namespace eje6
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCajaAhorro = new System.Windows.Forms.Button();
            this.BtnCtaCorriente = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.groupBoxSaldos = new System.Windows.Forms.GroupBox();
            this.labelCC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnDebitar = new System.Windows.Forms.Button();
            this.btnAcreditar = new System.Windows.Forms.Button();
            this.groupBoxMovimientos = new System.Windows.Forms.GroupBox();
            this.groupBoxOperacion = new System.Windows.Forms.GroupBox();
            this.groupBoxCuentas = new System.Windows.Forms.GroupBox();
            this.groupBoxSaldos.SuspendLayout();
            this.groupBoxMovimientos.SuspendLayout();
            this.groupBoxOperacion.SuspendLayout();
            this.groupBoxCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCajaAhorro
            // 
            this.btnCajaAhorro.Location = new System.Drawing.Point(6, 47);
            this.btnCajaAhorro.Name = "btnCajaAhorro";
            this.btnCajaAhorro.Size = new System.Drawing.Size(137, 23);
            this.btnCajaAhorro.TabIndex = 0;
            this.btnCajaAhorro.Text = "Caja de Ahorro";
            this.btnCajaAhorro.UseVisualStyleBackColor = true;
            this.btnCajaAhorro.Click += new System.EventHandler(this.btnCajaAhorro_Click);
            // 
            // BtnCtaCorriente
            // 
            this.BtnCtaCorriente.Location = new System.Drawing.Point(149, 47);
            this.BtnCtaCorriente.Name = "BtnCtaCorriente";
            this.BtnCtaCorriente.Size = new System.Drawing.Size(137, 23);
            this.BtnCtaCorriente.TabIndex = 1;
            this.BtnCtaCorriente.Text = "Cuenta Corriente";
            this.BtnCtaCorriente.UseVisualStyleBackColor = true;
            this.BtnCtaCorriente.Click += new System.EventHandler(this.BtnCtaCorriente_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(15, 12);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(34, 13);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "fecha";
            // 
            // groupBoxSaldos
            // 
            this.groupBoxSaldos.Controls.Add(this.labelCC);
            this.groupBoxSaldos.Controls.Add(this.label3);
            this.groupBoxSaldos.Controls.Add(this.labelCA);
            this.groupBoxSaldos.Controls.Add(this.label1);
            this.groupBoxSaldos.Location = new System.Drawing.Point(6, 272);
            this.groupBoxSaldos.Name = "groupBoxSaldos";
            this.groupBoxSaldos.Size = new System.Drawing.Size(219, 66);
            this.groupBoxSaldos.TabIndex = 21;
            this.groupBoxSaldos.TabStop = false;
            this.groupBoxSaldos.Text = "Saldos";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Location = new System.Drawing.Point(101, 16);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(35, 13);
            this.labelCC.TabIndex = 4;
            this.labelCC.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caja de Ahorro:";
            // 
            // labelCA
            // 
            this.labelCA.AutoSize = true;
            this.labelCA.Location = new System.Drawing.Point(101, 45);
            this.labelCA.Name = "labelCA";
            this.labelCA.Size = new System.Drawing.Size(35, 13);
            this.labelCA.TabIndex = 6;
            this.labelCA.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cuenta Corriente:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(156, 162);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "Aceptar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(98, 129);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(37, 28);
            this.buttonBorrar.TabIndex = 8;
            this.buttonBorrar.Text = "<-";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(55, 129);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(37, 28);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 28);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(55, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 28);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(98, 95);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(37, 28);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(98, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 28);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(55, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 28);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(156, 192);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.Text = "Ir Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(15, 48);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(156, 23);
            this.btnTransferencia.TabIndex = 25;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnDebitar
            // 
            this.btnDebitar.Location = new System.Drawing.Point(96, 19);
            this.btnDebitar.Name = "btnDebitar";
            this.btnDebitar.Size = new System.Drawing.Size(75, 23);
            this.btnDebitar.TabIndex = 24;
            this.btnDebitar.Text = "Debitar";
            this.btnDebitar.UseVisualStyleBackColor = true;
            this.btnDebitar.Click += new System.EventHandler(this.btnDebitar_Click);
            // 
            // btnAcreditar
            // 
            this.btnAcreditar.Location = new System.Drawing.Point(6, 19);
            this.btnAcreditar.Name = "btnAcreditar";
            this.btnAcreditar.Size = new System.Drawing.Size(75, 23);
            this.btnAcreditar.TabIndex = 23;
            this.btnAcreditar.Text = "Acreditar";
            this.btnAcreditar.UseVisualStyleBackColor = true;
            this.btnAcreditar.Click += new System.EventHandler(this.btnAcreditar_Click);
            // 
            // groupBoxMovimientos
            // 
            this.groupBoxMovimientos.Controls.Add(this.btnAcreditar);
            this.groupBoxMovimientos.Controls.Add(this.btnTransferencia);
            this.groupBoxMovimientos.Controls.Add(this.btnDebitar);
            this.groupBoxMovimientos.Location = new System.Drawing.Point(12, 153);
            this.groupBoxMovimientos.Name = "groupBoxMovimientos";
            this.groupBoxMovimientos.Size = new System.Drawing.Size(200, 89);
            this.groupBoxMovimientos.TabIndex = 26;
            this.groupBoxMovimientos.TabStop = false;
            this.groupBoxMovimientos.Text = "Movimientos";
            this.groupBoxMovimientos.Visible = false;
            // 
            // groupBoxOperacion
            // 
            this.groupBoxOperacion.Controls.Add(this.groupBoxSaldos);
            this.groupBoxOperacion.Controls.Add(this.button2);
            this.groupBoxOperacion.Controls.Add(this.btnAtras);
            this.groupBoxOperacion.Controls.Add(this.button3);
            this.groupBoxOperacion.Controls.Add(this.button10);
            this.groupBoxOperacion.Controls.Add(this.button4);
            this.groupBoxOperacion.Controls.Add(this.textBox1);
            this.groupBoxOperacion.Controls.Add(this.button1);
            this.groupBoxOperacion.Controls.Add(this.buttonBorrar);
            this.groupBoxOperacion.Controls.Add(this.button5);
            this.groupBoxOperacion.Controls.Add(this.button0);
            this.groupBoxOperacion.Controls.Add(this.button6);
            this.groupBoxOperacion.Controls.Add(this.button7);
            this.groupBoxOperacion.Controls.Add(this.button9);
            this.groupBoxOperacion.Controls.Add(this.button8);
            this.groupBoxOperacion.Location = new System.Drawing.Point(359, 12);
            this.groupBoxOperacion.Name = "groupBoxOperacion";
            this.groupBoxOperacion.Size = new System.Drawing.Size(258, 344);
            this.groupBoxOperacion.TabIndex = 27;
            this.groupBoxOperacion.TabStop = false;
            this.groupBoxOperacion.Text = "Operacion";
            this.groupBoxOperacion.Visible = false;
            // 
            // groupBoxCuentas
            // 
            this.groupBoxCuentas.Controls.Add(this.btnCajaAhorro);
            this.groupBoxCuentas.Controls.Add(this.BtnCtaCorriente);
            this.groupBoxCuentas.Location = new System.Drawing.Point(12, 35);
            this.groupBoxCuentas.Name = "groupBoxCuentas";
            this.groupBoxCuentas.Size = new System.Drawing.Size(309, 100);
            this.groupBoxCuentas.TabIndex = 28;
            this.groupBoxCuentas.TabStop = false;
            this.groupBoxCuentas.Text = "Elija Tipo de Cuenta";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 368);
            this.Controls.Add(this.groupBoxCuentas);
            this.Controls.Add(this.groupBoxOperacion);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.groupBoxMovimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.groupBoxSaldos.ResumeLayout(false);
            this.groupBoxSaldos.PerformLayout();
            this.groupBoxMovimientos.ResumeLayout(false);
            this.groupBoxOperacion.ResumeLayout(false);
            this.groupBoxOperacion.PerformLayout();
            this.groupBoxCuentas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCajaAhorro;
        private System.Windows.Forms.Button BtnCtaCorriente;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.GroupBox groupBoxSaldos;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Button btnDebitar;
        private System.Windows.Forms.Button btnAcreditar;
        private System.Windows.Forms.GroupBox groupBoxMovimientos;
        private System.Windows.Forms.GroupBox groupBoxOperacion;
        private System.Windows.Forms.GroupBox groupBoxCuentas;
    }
}

