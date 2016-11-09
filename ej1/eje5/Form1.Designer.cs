namespace eje5
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioBTriangulo = new System.Windows.Forms.RadioButton();
            this.radioBCirculo = new System.Windows.Forms.RadioButton();
            this.textBoxXPto1 = new System.Windows.Forms.TextBox();
            this.textBoxXPto2 = new System.Windows.Forms.TextBox();
            this.textBoxXPto3 = new System.Windows.Forms.TextBox();
            this.textBoxRadio = new System.Windows.Forms.TextBox();
            this.labelRadio = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP3 = new System.Windows.Forms.Label();
            this.textBoxYPto1 = new System.Windows.Forms.TextBox();
            this.textBoxYPto2 = new System.Windows.Forms.TextBox();
            this.textBoxYPto3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular Perimetro y Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioBTriangulo
            // 
            this.radioBTriangulo.AutoSize = true;
            this.radioBTriangulo.Checked = true;
            this.radioBTriangulo.Location = new System.Drawing.Point(53, 39);
            this.radioBTriangulo.Name = "radioBTriangulo";
            this.radioBTriangulo.Size = new System.Drawing.Size(69, 17);
            this.radioBTriangulo.TabIndex = 1;
            this.radioBTriangulo.TabStop = true;
            this.radioBTriangulo.Text = "Triangulo";
            this.radioBTriangulo.UseVisualStyleBackColor = true;
            this.radioBTriangulo.CheckedChanged += new System.EventHandler(this.radioBTriangulo_CheckedChanged);
            // 
            // radioBCirculo
            // 
            this.radioBCirculo.AutoSize = true;
            this.radioBCirculo.Location = new System.Drawing.Point(253, 39);
            this.radioBCirculo.Name = "radioBCirculo";
            this.radioBCirculo.Size = new System.Drawing.Size(57, 17);
            this.radioBCirculo.TabIndex = 2;
            this.radioBCirculo.Text = "Circulo";
            this.radioBCirculo.UseVisualStyleBackColor = true;
            this.radioBCirculo.CheckedChanged += new System.EventHandler(this.radioBCirculo_CheckedChanged);
            // 
            // textBoxXPto1
            // 
            this.textBoxXPto1.Location = new System.Drawing.Point(62, 81);
            this.textBoxXPto1.Name = "textBoxXPto1";
            this.textBoxXPto1.Size = new System.Drawing.Size(32, 20);
            this.textBoxXPto1.TabIndex = 1;
            this.textBoxXPto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumero);
            // 
            // textBoxXPto2
            // 
            this.textBoxXPto2.Location = new System.Drawing.Point(62, 107);
            this.textBoxXPto2.Name = "textBoxXPto2";
            this.textBoxXPto2.Size = new System.Drawing.Size(32, 20);
            this.textBoxXPto2.TabIndex = 3;
            this.textBoxXPto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumero);
            // 
            // textBoxXPto3
            // 
            this.textBoxXPto3.Location = new System.Drawing.Point(62, 133);
            this.textBoxXPto3.Name = "textBoxXPto3";
            this.textBoxXPto3.Size = new System.Drawing.Size(32, 20);
            this.textBoxXPto3.TabIndex = 5;
            this.textBoxXPto3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumero);
            // 
            // textBoxRadio
            // 
            this.textBoxRadio.Location = new System.Drawing.Point(253, 81);
            this.textBoxRadio.Name = "textBoxRadio";
            this.textBoxRadio.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadio.TabIndex = 7;
            this.textBoxRadio.Visible = false;
            this.textBoxRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumero);
            // 
            // labelRadio
            // 
            this.labelRadio.AutoSize = true;
            this.labelRadio.Location = new System.Drawing.Point(207, 81);
            this.labelRadio.Name = "labelRadio";
            this.labelRadio.Size = new System.Drawing.Size(35, 13);
            this.labelRadio.TabIndex = 7;
            this.labelRadio.Text = "Radio";
            this.labelRadio.Visible = false;
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Location = new System.Drawing.Point(12, 84);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(44, 13);
            this.labelP1.TabIndex = 7;
            this.labelP1.Text = "Punto 1";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Location = new System.Drawing.Point(12, 110);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(44, 13);
            this.labelP2.TabIndex = 7;
            this.labelP2.Text = "Punto 2";
            // 
            // labelP3
            // 
            this.labelP3.AutoSize = true;
            this.labelP3.Location = new System.Drawing.Point(12, 133);
            this.labelP3.Name = "labelP3";
            this.labelP3.Size = new System.Drawing.Size(44, 13);
            this.labelP3.TabIndex = 7;
            this.labelP3.Text = "Punto 3";
            // 
            // textBoxYPto1
            // 
            this.textBoxYPto1.Location = new System.Drawing.Point(100, 81);
            this.textBoxYPto1.Name = "textBoxYPto1";
            this.textBoxYPto1.Size = new System.Drawing.Size(32, 20);
            this.textBoxYPto1.TabIndex = 2;
            this.textBoxYPto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumero);
            // 
            // textBoxYPto2
            // 
            this.textBoxYPto2.Location = new System.Drawing.Point(100, 107);
            this.textBoxYPto2.Name = "textBoxYPto2";
            this.textBoxYPto2.Size = new System.Drawing.Size(32, 20);
            this.textBoxYPto2.TabIndex = 4;
            this.textBoxYPto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumero);
            // 
            // textBoxYPto3
            // 
            this.textBoxYPto3.Location = new System.Drawing.Point(100, 133);
            this.textBoxYPto3.Name = "textBoxYPto3";
            this.textBoxYPto3.Size = new System.Drawing.Size(32, 20);
            this.textBoxYPto3.TabIndex = 6;
            this.textBoxYPto3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumero);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 238);
            this.Controls.Add(this.labelP3);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.labelRadio);
            this.Controls.Add(this.textBoxRadio);
            this.Controls.Add(this.textBoxYPto3);
            this.Controls.Add(this.textBoxXPto3);
            this.Controls.Add(this.textBoxYPto2);
            this.Controls.Add(this.textBoxXPto2);
            this.Controls.Add(this.textBoxYPto1);
            this.Controls.Add(this.textBoxXPto1);
            this.Controls.Add(this.radioBCirculo);
            this.Controls.Add(this.radioBTriangulo);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioBTriangulo;
        private System.Windows.Forms.RadioButton radioBCirculo;
        private System.Windows.Forms.TextBox textBoxXPto1;
        private System.Windows.Forms.TextBox textBoxXPto2;
        private System.Windows.Forms.TextBox textBoxXPto3;
        private System.Windows.Forms.TextBox textBoxRadio;
        private System.Windows.Forms.Label labelRadio;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP3;
        private System.Windows.Forms.TextBox textBoxYPto1;
        private System.Windows.Forms.TextBox textBoxYPto2;
        private System.Windows.Forms.TextBox textBoxYPto3;
    }
}

