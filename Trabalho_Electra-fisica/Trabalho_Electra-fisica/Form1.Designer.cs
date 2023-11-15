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
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(776, 91);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Software da Galera";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnfis
            // 
            this.btnfis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfis.Location = new System.Drawing.Point(12, 257);
            this.btnfis.Name = "btnfis";
            this.btnfis.Size = new System.Drawing.Size(273, 181);
            this.btnfis.TabIndex = 1;
            this.btnfis.Text = "Balística";
            this.btnfis.UseVisualStyleBackColor = true;
            this.btnfis.Click += new System.EventHandler(this.btnfis_Click);
            // 
            // btnelet
            // 
            this.btnelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelet.Location = new System.Drawing.Point(515, 257);
            this.btnelet.Name = "btnelet";
            this.btnelet.Size = new System.Drawing.Size(273, 181);
            this.btnelet.TabIndex = 2;
            this.btnelet.Text = "Eletricidade";
            this.btnelet.UseVisualStyleBackColor = true;
            this.btnelet.Click += new System.EventHandler(this.btnelet_Click);
            // 
            // lblModo
            // 
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblModo.Location = new System.Drawing.Point(12, 100);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(776, 75);
            this.lblModo.TabIndex = 3;
            this.lblModo.Text = "Selecione o modo que deseja utilizar:";
            this.lblModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.btnelet);
            this.Controls.Add(this.btnfis);
            this.Controls.Add(this.lblTitulo);
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

