using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1
{
    public partial class FormArquivoTexto : Form
    {
        string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.txt");//O arquivo estará localizado no mesmo diretório da aplicação 

        public FormArquivoTexto()
        {
            InitializeComponent();
        }

        private void btnAdicionarLinha_Click(object sender, EventArgs e)
        {
            lbxLinhas.Items.Add($"Linha adicionada em: {DateTime.Now.ToLongDateString()} às " + $"{DateTime.Now.ToLongTimeString()}.");
        }

        private void btnExcluirLinha_Click(object sender, EventArgs e)
        {
            lbxLinhas.Items.Remove(lbxLinhas.SelectedItem);
        }
        #region Linha a Linha

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(caminhoArquivo);

            foreach (string linha in lbxLinhas.Items)
            {
                sw.WriteLine(linha);
            }
            sw.Close();
            MessageBox.Show("Arquivo criado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoArquivo))
            {
                lbxLinhas.Items.Clear();

                StreamReader sr = new StreamReader(caminhoArquivo);

                while (!sr.EndOfStream)
                {
                    lbxLinhas.Items.Add(sr.ReadLine());
                }
                sr.Close();

                MessageBox.Show("Arquivo lido com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Arquivo de texto não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizarArquivo_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoArquivo))
            {
                StreamWriter sw = new StreamWriter(caminhoArquivo, true);

                foreach (string linha in lbxLinhas.Items)
                {
                    sw.WriteLine(linha);
                }
                sw.Close();
                MessageBox.Show("Arquivo Atualizado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Arquivo de Texto não encontrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        } 
        #endregion

        #region Conteúdo Integral
        private void btnCriarArquivo2_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(caminhoArquivo, lbxLinhas.Items.OfType<string>().ToArray());

            MessageBox.Show("Arquivo criado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLerArquivo2_Click(object sender, EventArgs e)
        {
            lbxLinhas.Items.Clear();

            if (File.Exists(caminhoArquivo))
            {
                lbxLinhas.Items.AddRange(File.ReadAllLines(caminhoArquivo));

                MessageBox.Show("Arquivo lido com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Arquivo de Texto não encontrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAtualizarArquivo2_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoArquivo))
            {
                File.AppendAllLines(caminhoArquivo, lbxLinhas.Items.OfType<string>().ToArray());

                MessageBox.Show("Arquivo Atualizado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Arquivo de Texto não encontrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion
    }
}
