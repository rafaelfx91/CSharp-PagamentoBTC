namespace PagamentoBitCoin
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCotarBtc = new System.Windows.Forms.TextBox();
            this.btnCotar = new System.Windows.Forms.Button();
            this.lblCotacaoBTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar pagamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCotarBtc
            // 
            this.txtCotarBtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCotarBtc.Location = new System.Drawing.Point(12, 12);
            this.txtCotarBtc.Name = "txtCotarBtc";
            this.txtCotarBtc.Size = new System.Drawing.Size(143, 31);
            this.txtCotarBtc.TabIndex = 1;
            // 
            // btnCotar
            // 
            this.btnCotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotar.Location = new System.Drawing.Point(161, 12);
            this.btnCotar.Name = "btnCotar";
            this.btnCotar.Size = new System.Drawing.Size(97, 31);
            this.btnCotar.TabIndex = 2;
            this.btnCotar.Text = "Cotar";
            this.btnCotar.UseVisualStyleBackColor = true;
            this.btnCotar.Click += new System.EventHandler(this.btnCotar_Click);
            // 
            // lblCotacaoBTC
            // 
            this.lblCotacaoBTC.AutoSize = true;
            this.lblCotacaoBTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCotacaoBTC.Location = new System.Drawing.Point(12, 46);
            this.lblCotacaoBTC.Name = "lblCotacaoBTC";
            this.lblCotacaoBTC.Size = new System.Drawing.Size(71, 25);
            this.lblCotacaoBTC.TabIndex = 3;
            this.lblCotacaoBTC.Text = "BTC: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 201);
            this.Controls.Add(this.lblCotacaoBTC);
            this.Controls.Add(this.btnCotar);
            this.Controls.Add(this.txtCotarBtc);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCotarBtc;
        private System.Windows.Forms.Button btnCotar;
        private System.Windows.Forms.Label lblCotacaoBTC;
    }
}

