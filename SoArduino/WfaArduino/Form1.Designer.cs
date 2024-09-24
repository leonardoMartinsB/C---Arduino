namespace WfaArduino
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesligarLed = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnLigarLed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA COM C# E ARDUINO";
            // 
            // btnDesligarLed
            // 
            this.btnDesligarLed.Location = new System.Drawing.Point(210, 204);
            this.btnDesligarLed.Name = "btnDesligarLed";
            this.btnDesligarLed.Size = new System.Drawing.Size(168, 65);
            this.btnDesligarLed.TabIndex = 2;
            this.btnDesligarLed.Text = "DESLIGAR LED";
            this.btnDesligarLed.UseVisualStyleBackColor = true;
            this.btnDesligarLed.Click += new System.EventHandler(this.btnDesligarLed_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtStatus.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtStatus.Location = new System.Drawing.Point(210, 297);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(168, 124);
            this.txtStatus.TabIndex = 3;
            // 
            // btnLigarLed
            // 
            this.btnLigarLed.Location = new System.Drawing.Point(210, 107);
            this.btnLigarLed.Name = "btnLigarLed";
            this.btnLigarLed.Size = new System.Drawing.Size(168, 65);
            this.btnLigarLed.TabIndex = 4;
            this.btnLigarLed.Text = "LIGAR LED";
            this.btnLigarLed.UseVisualStyleBackColor = true;
            this.btnLigarLed.Click += new System.EventHandler(this.btnLigarLed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.btnLigarLed);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnDesligarLed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ARDUINO  - C#";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesligarLed;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnLigarLed;
    }
}

