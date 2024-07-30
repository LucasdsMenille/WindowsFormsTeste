using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSomar_CLick(object sender, EventArgs e)
        {
            //Entrada de Dados
            int n1 = int.Parse(txN1.Text);
            int n2 = int.Parse(txN2.Text);

            //Processamento
            int resultado = n1 + n2;

            //Saída de Dados
            lblResultado.Text = resultado.ToString();

        }

        private void btnLimpar_CLick(object sender, EventArgs e)
        {
            //Limpa as caixas de texto
            txN1.Clear();
            txN2.Clear();

            //Move o texto para zero na Label
            lblResultado.Text = "0";

            //Move o cursor para o text box
            txN1.Focus();

        }
    }
}
