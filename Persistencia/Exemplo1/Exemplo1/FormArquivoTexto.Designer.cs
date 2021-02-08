namespace Exemplo1
{
    partial class FormArquivoTexto
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
            this.btnAdicionarLinha = new System.Windows.Forms.Button();
            this.btnExcluirLinha = new System.Windows.Forms.Button();
            this.lbxLinhas = new System.Windows.Forms.ListBox();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnLerArquivo = new System.Windows.Forms.Button();
            this.btnAtualizarArquivo = new System.Windows.Forms.Button();
            this.btnCriarArquivo2 = new System.Windows.Forms.Button();
            this.btnLerArquivo2 = new System.Windows.Forms.Button();
            this.btnAtualizarArquivo2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionarLinha
            // 
            this.btnAdicionarLinha.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionarLinha.Name = "btnAdicionarLinha";
            this.btnAdicionarLinha.Size = new System.Drawing.Size(75, 33);
            this.btnAdicionarLinha.TabIndex = 0;
            this.btnAdicionarLinha.Text = "Adicionar Linha";
            this.btnAdicionarLinha.UseVisualStyleBackColor = true;
            this.btnAdicionarLinha.Click += new System.EventHandler(this.btnAdicionarLinha_Click);
            // 
            // btnExcluirLinha
            // 
            this.btnExcluirLinha.Location = new System.Drawing.Point(3, 42);
            this.btnExcluirLinha.Name = "btnExcluirLinha";
            this.btnExcluirLinha.Size = new System.Drawing.Size(75, 21);
            this.btnExcluirLinha.TabIndex = 1;
            this.btnExcluirLinha.Text = "Excluir Linha";
            this.btnExcluirLinha.UseVisualStyleBackColor = true;
            this.btnExcluirLinha.Click += new System.EventHandler(this.btnExcluirLinha_Click);
            // 
            // lbxLinhas
            // 
            this.lbxLinhas.FormattingEnabled = true;
            this.lbxLinhas.ItemHeight = 12;
            this.lbxLinhas.Location = new System.Drawing.Point(84, 6);
            this.lbxLinhas.Name = "lbxLinhas";
            this.lbxLinhas.Size = new System.Drawing.Size(345, 340);
            this.lbxLinhas.TabIndex = 2;
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(3, 92);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(75, 21);
            this.btnCriarArquivo.TabIndex = 3;
            this.btnCriarArquivo.Text = "Criar Arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnLerArquivo
            // 
            this.btnLerArquivo.Location = new System.Drawing.Point(3, 119);
            this.btnLerArquivo.Name = "btnLerArquivo";
            this.btnLerArquivo.Size = new System.Drawing.Size(75, 21);
            this.btnLerArquivo.TabIndex = 4;
            this.btnLerArquivo.Text = "Ler Arquivo";
            this.btnLerArquivo.UseVisualStyleBackColor = true;
            this.btnLerArquivo.Click += new System.EventHandler(this.btnLerArquivo_Click);
            // 
            // btnAtualizarArquivo
            // 
            this.btnAtualizarArquivo.Location = new System.Drawing.Point(3, 146);
            this.btnAtualizarArquivo.Name = "btnAtualizarArquivo";
            this.btnAtualizarArquivo.Size = new System.Drawing.Size(75, 39);
            this.btnAtualizarArquivo.TabIndex = 5;
            this.btnAtualizarArquivo.Text = "Atualizar Arquivo";
            this.btnAtualizarArquivo.UseVisualStyleBackColor = true;
            this.btnAtualizarArquivo.Click += new System.EventHandler(this.btnAtualizarArquivo_Click);
            // 
            // btnCriarArquivo2
            // 
            this.btnCriarArquivo2.Location = new System.Drawing.Point(3, 241);
            this.btnCriarArquivo2.Name = "btnCriarArquivo2";
            this.btnCriarArquivo2.Size = new System.Drawing.Size(75, 21);
            this.btnCriarArquivo2.TabIndex = 6;
            this.btnCriarArquivo2.Text = "Criar Arquivo";
            this.btnCriarArquivo2.UseVisualStyleBackColor = true;
            this.btnCriarArquivo2.Click += new System.EventHandler(this.btnCriarArquivo2_Click);
            // 
            // btnLerArquivo2
            // 
            this.btnLerArquivo2.Location = new System.Drawing.Point(3, 268);
            this.btnLerArquivo2.Name = "btnLerArquivo2";
            this.btnLerArquivo2.Size = new System.Drawing.Size(75, 21);
            this.btnLerArquivo2.TabIndex = 7;
            this.btnLerArquivo2.Text = "Ler Arquivo";
            this.btnLerArquivo2.UseVisualStyleBackColor = true;
            this.btnLerArquivo2.Click += new System.EventHandler(this.btnLerArquivo2_Click);
            // 
            // btnAtualizarArquivo2
            // 
            this.btnAtualizarArquivo2.Location = new System.Drawing.Point(3, 294);
            this.btnAtualizarArquivo2.Name = "btnAtualizarArquivo2";
            this.btnAtualizarArquivo2.Size = new System.Drawing.Size(75, 42);
            this.btnAtualizarArquivo2.TabIndex = 8;
            this.btnAtualizarArquivo2.Text = "Atualizar Arquivo";
            this.btnAtualizarArquivo2.UseVisualStyleBackColor = true;
            this.btnAtualizarArquivo2.Click += new System.EventHandler(this.btnAtualizarArquivo2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Linha a Linha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.3F);
            this.label2.Location = new System.Drawing.Point(1, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Conteúdo Integral";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormArquivoTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizarArquivo2);
            this.Controls.Add(this.btnLerArquivo2);
            this.Controls.Add(this.btnCriarArquivo2);
            this.Controls.Add(this.btnAtualizarArquivo);
            this.Controls.Add(this.btnLerArquivo);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.lbxLinhas);
            this.Controls.Add(this.btnExcluirLinha);
            this.Controls.Add(this.btnAdicionarLinha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Name = "FormArquivoTexto";
            this.Text = "Persistência de Dados em Arquivo Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarLinha;
        private System.Windows.Forms.Button btnExcluirLinha;
        private System.Windows.Forms.ListBox lbxLinhas;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnLerArquivo;
        private System.Windows.Forms.Button btnAtualizarArquivo;
        private System.Windows.Forms.Button btnCriarArquivo2;
        private System.Windows.Forms.Button btnLerArquivo2;
        private System.Windows.Forms.Button btnAtualizarArquivo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

