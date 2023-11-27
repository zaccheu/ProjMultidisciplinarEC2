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
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
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
            // Obter valores de entrada do usuário para x, y e theta
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);
            double theta = double.Parse(textBoxTheta.Text);
            double vi;
            double tempoalvo;

            // Converter o ângulo theta para radianos
            theta = theta * Math.PI / 180;

            // Limpar e ocultar a label de erro
            lblError.Visible = false;
            lblError.Text = "";

            // Checar possíveis erros nos valores inseridos pelo usuário

            // Se o ângulo for menor que o mínimo necessário para atingir o alvo
            if (theta <= Math.Atan(y / x))
            {
                // Exibir mensagem de erro indicando o ângulo mínimo necessário
                lblError.Text = $"O ângulo inserido é menor que o mínimo {Math.Round(Math.Atan(y / x) * (180 / Math.PI) + 1)}° para atingir o alvo! Digite outro!";
                lblError.Visible = true;
                txtRelatorio.Visible = false;
                chart1.Visible = false;
            }
            else
            {
                txtRelatorio.Visible = true;
                chart1.Visible = true;
            }

            // Verificar se o ângulo é maior ou igual a 90°
            if (theta * (180 / Math.PI) > 89.9)
            {
                lblError.Text = $"O ângulo inserido não pode ser maior ou igual que 90°";
                lblError.Visible = true;
                txtRelatorio.Visible = false;
                chart1.Visible = false;
            }

            // Verificar se o ângulo é menor ou igual a zero
            if (theta * (180 / Math.PI) <= 0)
            {
                lblError.Text = $"O ângulo inserido não pode ser menor ou igual a zero";
                lblError.Visible = true;
                txtRelatorio.Visible = false;
                chart1.Visible = false;
            }

            // Cálculo da velocidade inicial necessária para atingir o alvo
            vi = Math.Sqrt((((-9.81 * Math.Pow(x, 2)) * (1 + Math.Pow(Math.Tan(theta), 2)))) / (2 * (y - x * Math.Tan(theta))));

            // Exibir informações sobre a velocidade inicial e o tempo até atingir o alvo
            txtRelatorio.Text = $"A velocidade inicial do projétil, com o ângulo de {theta * (180 / Math.PI)}°, necessária para atingir o alvo inserido, é de {Math.Round(vi, 2)} m/s.{Environment.NewLine}"; ;

            tempoalvo = x / (vi * Math.Cos(theta));
            txtRelatorio.Text += $"O tempo gasto pelo projétil até atingir o alvo é de {Math.Round(tempoalvo, 2)}  segundos.{Environment.NewLine}";

            // Cálculo das componentes verticais da velocidade para determinar se atinge na subida ou descida
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

            // Cálculo do alcance máximo da trajetória
            double alcance = (Math.Pow(vi, 2) / 9.81) * Math.Sin(theta * 2);

            // Determinação do número de pontos a serem plotados no gráfico
            double numplot = Math.Round(alcance / 17);

            // Listas para armazenar os valores de x e y para o gráfico da trajetória
            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();

            // Loop para calcular os pontos da trajetória e adicioná-los às listas
            for (double xgrafico = 0; xgrafico <= alcance; xgrafico += numplot)
            {
                if (xgrafico == x)
                {
                    xgrafico += numplot;
                }
                xValues.Add(xgrafico);
                yValues.Add((xgrafico * Math.Tan(theta)) - ((9.81 * (1 + Math.Pow(Math.Tan(theta), 2)) / (Math.Pow(vi, 2) * 2)) * Math.Pow(xgrafico, 2)));
            }

            // Plotar a trajetória no gráfico
            chart1.Series["Equação da Trajetória"].Points.DataBindXY(xValues, yValues);

            // Configurações adicionais do gráfico (intervalos, limites etc.)
            chart1.ChartAreas[0].AxisX.Interval = Math.Round(numplot);
            chart1.ChartAreas[0].AxisY.Interval = Math.Round(numplot + 40);
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = alcance + 10;

            // Adicionar rótulos aos pontos da trajetória no gráfico
            for (int i = 0; i < xValues.Count; i += 1)
            {
                chart1.Series["Equação da Trajetória"].Points[i].Label = $"({xValues[i]} / {Math.Round(yValues[i], 2)})";
            }

            // Exibir ponto do alvo no gráfico
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
