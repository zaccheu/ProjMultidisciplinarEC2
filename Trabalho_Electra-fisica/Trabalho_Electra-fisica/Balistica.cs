using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            theta = theta * Math.PI / 180;
            lblError.Visible = false;
            lblError.Text = "";
            if (x == 2)
            {
                lblError.Text = "Erro!";
                lblError.Visible = true;
            }
            if (theta < Math.Atan(y/x))
            {
                lblError.Text = "O ângulo inserido é menor que o mínimo para atingir o alvo! Digite outro!";
                lblError.Visible = true;
            }
        }
    }
}
