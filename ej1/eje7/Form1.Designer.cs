namespace eje7
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
            this.textBoxIngresarText = new System.Windows.Forms.TextBox();
            this.comboBoxEncriptadores = new System.Windows.Forms.ComboBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.textBEncrip = new System.Windows.Forms.TextBox();
            this.textBDesencrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIngresarText
            // 
            this.textBoxIngresarText.Location = new System.Drawing.Point(135, 18);
            this.textBoxIngresarText.Name = "textBoxIngresarText";
            this.textBoxIngresarText.Size = new System.Drawing.Size(146, 20);
            this.textBoxIngresarText.TabIndex = 0;
            // 
            // comboBoxEncriptadores
            // 
            this.comboBoxEncriptadores.FormattingEnabled = true;
            this.comboBoxEncriptadores.Location = new System.Drawing.Point(135, 55);
            this.comboBoxEncriptadores.Name = "comboBoxEncriptadores";
            this.comboBoxEncriptadores.Size = new System.Drawing.Size(146, 21);
            this.comboBoxEncriptadores.TabIndex = 1;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(12, 89);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 2;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto Encriptado:";
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(160, 89);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencriptar.TabIndex = 7;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // textBEncrip
            // 
            this.textBEncrip.Location = new System.Drawing.Point(135, 127);
            this.textBEncrip.Name = "textBEncrip";
            this.textBEncrip.Size = new System.Drawing.Size(146, 20);
            this.textBEncrip.TabIndex = 8;
            // 
            // textBDesencrip
            // 
            this.textBDesencrip.Location = new System.Drawing.Point(135, 160);
            this.textBDesencrip.Name = "textBDesencrip";
            this.textBDesencrip.Size = new System.Drawing.Size(146, 20);
            this.textBDesencrip.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto Desencriptado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese Texto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccione Encriptador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 388);
            this.Controls.Add(this.textBDesencrip);
            this.Controls.Add(this.textBEncrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.comboBoxEncriptadores);
            this.Controls.Add(this.textBoxIngresarText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIngresarText;
        private System.Windows.Forms.ComboBox comboBoxEncriptadores;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.TextBox textBEncrip;
        private System.Windows.Forms.TextBox textBDesencrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

