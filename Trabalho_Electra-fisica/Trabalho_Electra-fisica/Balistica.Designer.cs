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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.NumericUpDown();
            this.textBoxY = new System.Windows.Forms.NumericUpDown();
            this.textBoxTheta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTheta)).BeginInit();
            this.SuspendLayout();
            // 
            // txcoordenadas
            // 
            this.txcoordenadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcoordenadas.Location = new System.Drawing.Point(16, 11);
            this.txcoordenadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txcoordenadas.Name = "txcoordenadas";
            this.txcoordenadas.Size = new System.Drawing.Size(280, 57);
            this.txcoordenadas.TabIndex = 3;
            this.txcoordenadas.Text = "Digite as coordenadas (X,Y) do alvo:";
            this.txcoordenadas.Click += new System.EventHandler(this.XAlvo_Click);
            // 
            // theta
            // 
            this.theta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theta.Location = new System.Drawing.Point(16, 118);
            this.theta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.theta.Name = "theta";
            this.theta.Size = new System.Drawing.Size(215, 57);
            this.theta.TabIndex = 4;
            this.theta.Text = "Digite o ângulo de lançamento do projétil:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(26, 65);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(36, 29);
            this.lblX.TabIndex = 5;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(156, 65);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 29);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "θ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "°";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(304, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Black;
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Equação da Trajetória";
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1405, 708);
            this.chart1.TabIndex = 10;
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btngrafico
            // 
            this.btngrafico.Location = new System.Drawing.Point(24, 241);
            this.btngrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngrafico.Name = "btngrafico";
            this.btngrafico.Size = new System.Drawing.Size(167, 86);
            this.btngrafico.TabIndex = 11;
            this.btngrafico.Text = "Gerar Gráfico!";
            this.btngrafico.UseVisualStyleBackColor = true;
            this.btngrafico.Click += new System.EventHandler(this.btngrafico_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1405, 629);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(304, 730);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1405, 208);
            this.dataGridView2.TabIndex = 13;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(20, 352);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(240, 145);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error Label";
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelatorio.Location = new System.Drawing.Point(304, 730);
            this.txtRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.ReadOnly = true;
            this.txtRelatorio.Size = new System.Drawing.Size(1404, 207);
            this.txtRelatorio.TabIndex = 15;
            this.txtRelatorio.Visible = false;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(60, 71);
            this.textBoxX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textBoxX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(70, 22);
            this.textBoxX.TabIndex = 16;
            this.textBoxX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(190, 71);
            this.textBoxY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textBoxY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(70, 22);
            this.textBoxY.TabIndex = 17;
            this.textBoxY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxTheta
            // 
            this.textBoxTheta.Location = new System.Drawing.Point(48, 178);
            this.textBoxTheta.Maximum = new decimal(new int[] {
            8999,
            0,
            0,
            131072});
            this.textBoxTheta.Name = "textBoxTheta";
            this.textBoxTheta.Size = new System.Drawing.Size(70, 22);
            this.textBoxTheta.TabIndex = 19;
            this.textBoxTheta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Balistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 970);
            this.Controls.Add(this.textBoxTheta);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.txtRelatorio);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btngrafico);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.theta);
            this.Controls.Add(this.txcoordenadas);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Balistica";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Balistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTheta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox txtRelatorio;
        private System.Windows.Forms.NumericUpDown textBoxX;
        private System.Windows.Forms.NumericUpDown textBoxY;
        private System.Windows.Forms.NumericUpDown textBoxTheta;
    }
}