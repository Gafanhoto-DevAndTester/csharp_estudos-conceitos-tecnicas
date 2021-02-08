using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeRG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string GerarRg()
        {
            // Gerar 8 números aleatórios de 0 a 9 
            // Calcular esses 8 números e gerar o Digito verificador
            // Se o resto for igual a 0 o digito verificador será 0 
            // Se o Resto for igual a 1, o digito verificador será x
            // Se não o digito verificador será igual a 11 - o resto

            Random rnd = new Random();
            int n1 = rnd.Next(0,10);
            int n2 = rnd.Next(0,10);
            int n3 = rnd.Next(0,10);
            int n4 = rnd.Next(0,10);
            int n5 = rnd.Next(0,10);
            int n6 = rnd.Next(0,10);
            int n7 = rnd.Next(0,10);
            int n8 = rnd.Next(0,10);

            int soma = (n1 * 2) +
                (n2 * 3) + (n3 * 4) +
                (n4 * 5) + (n5 * 6) +
                (n6 * 7) + (n7 * 8) +
                (n8 * 9);

            int resto = soma % 11;

            string digitoVerificador;


            if (resto == 0)
            {
                digitoVerificador = "0";
            }
            else if (resto == 1)
            {
                digitoVerificador = "x";
            }
            else
            {
                digitoVerificador = (11 - resto).ToString();
            }
            return n1.ToString() + n2 + n3 + n4+n5 + n6 + n7 + n8 + digitoVerificador;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GerarRg();
        }
    }
}
