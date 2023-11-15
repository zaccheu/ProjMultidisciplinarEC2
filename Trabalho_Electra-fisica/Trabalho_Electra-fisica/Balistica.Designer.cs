namespace Trabalho_Electra_fisica
{
    partial class Balistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxTheta = new System.Windows.Forms.TextBox();
            this.txcoordenadas = new System.Windows.Forms.Label();
            this.theta = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btngrafico = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(47, 58);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(44, 20);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBoxY.Location = new System.Drawing.Point(147, 58);
            this.textBoxY.Name = "textBox2";
            this.textBoxY.Size = new System.Drawing.Size(48, 20);
            this.textBoxY.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBoxTheta.Location = new System.Drawing.Point(47, 145);
            this.textBoxTheta.Name = "textBox3";
            this.textBoxTheta.Size = new System.Drawing.Size(44, 20);
            this.textBoxTheta.TabIndex = 2;
            // 
            // txcoordenadas
            // 
            this.txcoordenadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcoordenadas.Location = new System.Drawing.Point(12, 9);
            this.txcoordenadas.Name = "txcoordenadas";
            this.txcoordenadas.Size = new System.Drawing.Size(210, 46);
            this.txcoordenadas.TabIndex = 3;
            this.txcoordenadas.Text = "Digite as coordenadas (X,Y) do alvo:";
            this.txcoordenadas.Click += new System.EventHandler(this.XAlvo_Click);
            // 
            // theta
            // 
            this.theta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theta.Location = new System.Drawing.Point(12, 96);
            this.theta.Name = "theta";
            this.theta.Size = new System.Drawing.Size(161, 46);
            this.theta.TabIndex = 4;
            this.theta.Text = "Digite o ângulo de lançamento do projétil:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(12, 55);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(29, 24);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(116, 58);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(27, 24);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "θ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "°";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(228, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1054, 511);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btngrafico
            // 
            this.btngrafico.Location = new System.Drawing.Point(18, 196);
            this.btngrafico.Name = "btngrafico";
            this.btngrafico.Size = new System.Drawing.Size(125, 70);
            this.btngrafico.TabIndex = 11;
            this.btngrafico.Text = "Gerar Gráfico!";
            this.btngrafico.UseVisualStyleBackColor = true;
            this.btngrafico.Click += new System.EventHandler(this.btngrafico_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1054, 511);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(228, 544);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1054, 218);
            this.dataGridView2.TabIndex = 13;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 286);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(180, 118);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error Label";
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // Balistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 788);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btngrafico);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxTheta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.theta);
            this.Controls.Add(this.txcoordenadas);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Balistica";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Balistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxTheta;
        private System.Windows.Forms.Label txcoordenadas;
        private System.Windows.Forms.Label theta;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btngrafico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblError;
    }
}