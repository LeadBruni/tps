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
            this.SuspendLayout();
            // 
            // btnCajaAhorro
            // 
            this.btnCajaAhorro.Location = new System.Drawing.Point(12, 26);
            this.btnCajaAhorro.Name = "btnCajaAhorro";
            this.btnCajaAhorro.Size = new System.Drawing.Size(137, 23);
            this.btnCajaAhorro.TabIndex = 0;
            this.btnCajaAhorro.Text = "Caja de Ahorro";
            this.btnCajaAhorro.UseVisualStyleBackColor = true;
            this.btnCajaAhorro.Click += new System.EventHandler(this.btnCajaAhorro_Click);
            // 
            // BtnCtaCorriente
            // 
            this.BtnCtaCorriente.Location = new System.Drawing.Point(175, 26);
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
            this.labelFecha.Location = new System.Drawing.Point(9, 101);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(34, 13);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "fecha";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 186);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.BtnCtaCorriente);
            this.Controls.Add(this.btnCajaAhorro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCajaAhorro;
        private System.Windows.Forms.Button BtnCtaCorriente;
        private System.Windows.Forms.Label labelFecha;
    }
}

