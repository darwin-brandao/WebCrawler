namespace WebCrawler
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
            this.btnIR = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lstLINKS = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIR
            // 
            this.btnIR.Location = new System.Drawing.Point(713, 12);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(75, 23);
            this.btnIR.TabIndex = 0;
            this.btnIR.Text = "button1";
            this.btnIR.UseVisualStyleBackColor = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 14);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(695, 20);
            this.txtURL.TabIndex = 1;
            // 
            // lstLINKS
            // 
            this.lstLINKS.FormattingEnabled = true;
            this.lstLINKS.Location = new System.Drawing.Point(12, 40);
            this.lstLINKS.Name = "lstLINKS";
            this.lstLINKS.Size = new System.Drawing.Size(776, 394);
            this.lstLINKS.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLINKS);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnIR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIR;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ListBox lstLINKS;
    }
}

