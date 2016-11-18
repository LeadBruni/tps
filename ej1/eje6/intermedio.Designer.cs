namespace eje6
{
    partial class intermedio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcreditar = new System.Windows.Forms.Button();
            this.btnDebitar = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcreditar
            // 
            this.btnAcreditar.Location = new System.Drawing.Point(12, 30);
            this.btnAcreditar.Name = "btnAcreditar";
            this.btnAcreditar.Size = new System.Drawing.Size(75, 23);
            this.btnAcreditar.TabIndex = 0;
            this.btnAcreditar.Text = "Acreditar";
            this.btnAcreditar.UseVisualStyleBackColor = true;
            this.btnAcreditar.Click += new System.EventHandler(this.btnAcreditar_Click);
            // 
            // btnDebitar
            // 
            this.btnDebitar.Location = new System.Drawing.Point(118, 30);
            this.btnDebitar.Name = "btnDebitar";
            this.btnDebitar.Size = new System.Drawing.Size(75, 23);
            this.btnDebitar.TabIndex = 1;
            this.btnDebitar.Text = "Debitar";
            this.btnDebitar.UseVisualStyleBackColor = true;
            this.btnDebitar.Click += new System.EventHandler(this.btnDebitar_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(222, 30);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(221, 23);
            this.btnTransferencia.TabIndex = 2;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            this.btnTransferencia.Leave += new System.EventHandler(this.intermedio_Load);
            // 
            // intermedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 86);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnDebitar);
            this.Controls.Add(this.btnAcreditar);
            this.MaximizeBox = false;
            this.Name = "intermedio";
            this.Text = "intermedio";
            this.Load += new System.EventHandler(this.intermedio_Load_1);
            this.Leave += new System.EventHandler(this.intermedio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcreditar;
        private System.Windows.Forms.Button btnDebitar;
        private System.Windows.Forms.Button btnTransferencia;
    }
}