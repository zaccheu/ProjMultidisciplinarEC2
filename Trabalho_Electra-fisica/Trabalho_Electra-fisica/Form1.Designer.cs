namespace Trabalho_Electra_fisica
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnfis = new System.Windows.Forms.Button();
            this.btnelet = new System.Windows.Forms.Button();
            this.lblModo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1035, 112);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Projeto Mult-Diciplinar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnfis
            // 
            this.btnfis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfis.Location = new System.Drawing.Point(16, 316);
            this.btnfis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfis.Name = "btnfis";
            this.btnfis.Size = new System.Drawing.Size(364, 223);
            this.btnfis.TabIndex = 1;
            this.btnfis.Text = "Balística";
            this.btnfis.UseVisualStyleBackColor = true;
            this.btnfis.Click += new System.EventHandler(this.btnfis_Click);
            // 
            // btnelet
            // 
            this.btnelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelet.Location = new System.Drawing.Point(687, 316);
            this.btnelet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnelet.Name = "btnelet";
            this.btnelet.Size = new System.Drawing.Size(364, 223);
            this.btnelet.TabIndex = 2;
            this.btnelet.Text = "Eletricidade";
            this.btnelet.UseVisualStyleBackColor = true;
            this.btnelet.Click += new System.EventHandler(this.btnelet_Click);
            // 
            // lblModo
            // 
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblModo.Location = new System.Drawing.Point(16, 123);
            this.lblModo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(1035, 92);
            this.lblModo.TabIndex = 3;
            this.lblModo.Text = "Selecione o modo que deseja utilizar:";
            this.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.btnelet);
            this.Controls.Add(this.btnfis);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnfis;
        private System.Windows.Forms.Button btnelet;
        private System.Windows.Forms.Label lblModo;
    }
}

