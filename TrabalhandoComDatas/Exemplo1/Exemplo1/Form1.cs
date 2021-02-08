using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TimeSpan tempo_transcorrido;
        double idade;

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempo_transcorrido = DateTime.Now.Date - dateTimePicker1.Value;
            idade = Convert.ToDouble(tempo_transcorrido.Days /365);
            textBox1.Text = idade.ToString();
        }
    }
}
