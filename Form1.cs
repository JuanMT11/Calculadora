using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            txtCalculadora.Text = "0";
        }
        String operador = "";
        double num1;
        double num2;
        double resultado;
        bool borrarNumeroAnterior = true;


        private void btnCero_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "0";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "0";
            }
        }

        private void btnUno_Click(object sender, EventArgs e)
        {

            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "1";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "1";
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "2";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "3";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "3";
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "4";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "5";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "6";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "6";
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "7";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "7";
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "8";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "8";
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (borrarNumeroAnterior)
            {
                txtCalculadora.Text = "9";
                borrarNumeroAnterior = false;
            }
            else
            {
                if (txtCalculadora.Text == "0") txtCalculadora.Text = "";
                txtCalculadora.Text += "9";
            }
        }


        private void btnC_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text = "0";
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            if (txtCalculadora.TextLength <= 1) txtCalculadora.Text = "0";
            else txtCalculadora.Text = txtCalculadora.Text.Substring(0, txtCalculadora.Text.Length - 1);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = double.Parse(txtCalculadora.Text);
            txtCalculadora.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            if (!borrarNumeroAnterior)
            {
                num2 = double.Parse(txtCalculadora.Text);
                switch (operador)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        resultado = num1 / num2;
                        break;
                }
                txtCalculadora.Text = resultado.ToString();
                borrarNumeroAnterior = true; // Reiniciar la pantalla para la siguiente operación
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = double.Parse(txtCalculadora.Text);
            txtCalculadora.Text = "0";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = double.Parse(txtCalculadora.Text);
            txtCalculadora.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = double.Parse(txtCalculadora.Text);
            txtCalculadora.Text = "0";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtCalculadora.Text);
            resultado = Math.Pow(num1, 2);
            txtCalculadora.Text = resultado.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtCalculadora.Text);
            resultado = Math.Sqrt(num1);
            txtCalculadora.Text = resultado.ToString();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtCalculadora.Text.Contains("."))
            {
                txtCalculadora.Text += ".";
            }
        }
    }
}
