using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trabalho_Electra_fisica
{
    public partial class Balistica : Form
    {

        public Balistica()
        {
            InitializeComponent();
        }

        private void Balistica_Load(object sender, EventArgs e)
        {

        }

        private void XAlvo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void btngrafico_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);
            double theta = double.Parse(textBoxTheta.Text);
            double vi;
            double tempoalvo;
            theta = theta * Math.PI / 180;
            lblError.Visible = false;
            lblError.Text = "";
            if (x == 2)
            {
                lblError.Text = "Erro!";
                lblError.Visible = true;
            }
            if (theta <= Math.Atan(y/x))
            {
                lblError.Text = $"O ângulo inserido é menor que o mínimo {Math.Round(Math.Atan(y / x) * (180 / Math.PI))}° para atingir o alvo! Digite outro!";
                lblError.Visible = true;
            }
            vi = Math.Sqrt((((-9.81 * Math.Pow(x, 2)) * (1 + Math.Pow(Math.Tan(theta), 2)))) / (2 * (y - x * Math.Tan(theta))));
            txtRelatorio.Text = txtRelatorio.Text = $"A velocidade inicial do projétil, com o ângulo de {theta * (180 / Math.PI)}°, necessária para atingir o alvo inserido, é de {Math.Round(vi, 2)} m/s.{Environment.NewLine}"; ;   
            txtRelatorio.Visible = true;

            tempoalvo = x / (vi * Math.Cos(theta));
            txtRelatorio.Text += $"O tempo gasto pelo projétil até atingir o alvo é de {Math.Round(tempoalvo, 2)}  segundos.{Environment.NewLine}"; 
            double voy = vi * Math.Sin(theta);
            double vyt = voy - 9.81 * tempoalvo;
            if (vyt > 0)
            {
                txtRelatorio.Text += $"Como a componente vertical da velocidade no tempo {Math.Round(tempoalvo, 2)} segundos é positiva ({Math.Round(vyt, 2)} m/s), o alvo é atingido na subida, como mostrado no gráfico."; 
            }
            else
            {
                txtRelatorio.Text += $"Como a componente vertical da velocidade no tempo {Math.Round(tempoalvo, 2)} segundos é negativa ({Math.Round(vyt, 2)} m/s), o alvo é atingido na descida, como mostrado no gráfico.";
            }

            double alcance = (Math.Sqrt(vi) / 9.81) * Math.Sin(theta * 2);

            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();

            for (double xgrafico = 0; xgrafico <= 600; xgrafico += 40)
            {
                if (xgrafico == x)
                {
                    xgrafico += 40;
                }
                xValues.Add(xgrafico);
                yValues.Add((xgrafico * Math.Tan(theta)) - ((9.81 * (1 + Math.Pow(Math.Tan(theta), 2)) / (Math.Pow(vi, 2) * 2)) * Math.Pow(xgrafico, 2)));

            }

            chart1.Series["Equação da Trajetória"].Points.DataBindXY(xValues, yValues);
            chart1.Visible = true;

            chart1.ChartAreas[0].AxisX.Interval = 100;
            chart1.ChartAreas[0].AxisY.Interval = 100;
            
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            for (int i = 0; i < xValues.Count; i += 1) 
            {
                chart1.Series["Equação da Trajetória"].Points[i].Label = $"({xValues[i]} / {Math.Round(yValues[i], 2)})";
            }

            double pontoalvox = x;
            double pontoalvoy = y;
            DataPoint pontoAlvo = new DataPoint(pontoalvox, pontoalvoy);
            pontoAlvo.MarkerColor = System.Drawing.Color.Red;
            pontoAlvo.Label = $"Alvo ({pontoalvox} / {pontoalvoy})";
            pontoAlvo.MarkerSize = 16;
            chart1.Series["Equação da Trajetória"].Points.Add(pontoAlvo);




        }

    }
}
