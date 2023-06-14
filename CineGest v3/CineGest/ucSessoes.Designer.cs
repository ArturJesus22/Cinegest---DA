namespace WindowsFormsApp1
{
    partial class ucSessoes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbConfigSessoes = new System.Windows.Forms.GroupBox();
            this.lblEscolherSala = new System.Windows.Forms.Label();
            this.lblEscolherFilme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionarSessão = new System.Windows.Forms.Button();
            this.lbSessoesDisp = new System.Windows.Forms.ListBox();
            this.comboBoxSalas = new System.Windows.Forms.ComboBox();
            this.comboBoxFilmes = new System.Windows.Forms.ComboBox();
            this.gbConfigSessoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfigSessoes
            // 
            this.gbConfigSessoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbConfigSessoes.Controls.Add(this.comboBoxFilmes);
            this.gbConfigSessoes.Controls.Add(this.comboBoxSalas);
            this.gbConfigSessoes.Controls.Add(this.btnAdicionarSessão);
            this.gbConfigSessoes.Controls.Add(this.label2);
            this.gbConfigSessoes.Controls.Add(this.label1);
            this.gbConfigSessoes.Controls.Add(this.lblEscolherFilme);
            this.gbConfigSessoes.Controls.Add(this.lblEscolherSala);
            this.gbConfigSessoes.Location = new System.Drawing.Point(92, 58);
            this.gbConfigSessoes.Name = "gbConfigSessoes";
            this.gbConfigSessoes.Size = new System.Drawing.Size(576, 177);
            this.gbConfigSessoes.TabIndex = 2;
            this.gbConfigSessoes.TabStop = false;
            this.gbConfigSessoes.Text = "Criar Sessões";
            // 
            // lblEscolherSala
            // 
            this.lblEscolherSala.AutoSize = true;
            this.lblEscolherSala.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblEscolherSala.Location = new System.Drawing.Point(23, 54);
            this.lblEscolherSala.Name = "lblEscolherSala";
            this.lblEscolherSala.Size = new System.Drawing.Size(41, 17);
            this.lblEscolherSala.TabIndex = 0;
            this.lblEscolherSala.Text = "Sala:";
            // 
            // lblEscolherFilme
            // 
            this.lblEscolherFilme.AutoSize = true;
            this.lblEscolherFilme.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblEscolherFilme.Location = new System.Drawing.Point(23, 90);
            this.lblEscolherFilme.Name = "lblEscolherFilme";
            this.lblEscolherFilme.Size = new System.Drawing.Size(48, 17);
            this.lblEscolherFilme.TabIndex = 1;
            this.lblEscolherFilme.Text = "Filme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.75F);
            this.label1.Location = new System.Drawing.Point(215, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.75F);
            this.label2.Location = new System.Drawing.Point(215, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora:";
            // 
            // btnAdicionarSessão
            // 
            this.btnAdicionarSessão.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarSessão.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarSessão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSessão.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAdicionarSessão.Location = new System.Drawing.Point(409, 54);
            this.btnAdicionarSessão.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarSessão.Name = "btnAdicionarSessão";
            this.btnAdicionarSessão.Size = new System.Drawing.Size(143, 76);
            this.btnAdicionarSessão.TabIndex = 5;
            this.btnAdicionarSessão.Text = "ADICIONAR SESSÃO";
            this.btnAdicionarSessão.UseVisualStyleBackColor = false;
            // 
            // lbSessoesDisp
            // 
            this.lbSessoesDisp.FormattingEnabled = true;
            this.lbSessoesDisp.Location = new System.Drawing.Point(92, 274);
            this.lbSessoesDisp.Name = "lbSessoesDisp";
            this.lbSessoesDisp.Size = new System.Drawing.Size(575, 225);
            this.lbSessoesDisp.TabIndex = 3;
            // 
            // comboBoxSalas
            // 
            this.comboBoxSalas.FormattingEnabled = true;
            this.comboBoxSalas.Location = new System.Drawing.Point(70, 53);
            this.comboBoxSalas.Name = "comboBoxSalas";
            this.comboBoxSalas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSalas.TabIndex = 6;
            // 
            // comboBoxFilmes
            // 
            this.comboBoxFilmes.FormattingEnabled = true;
            this.comboBoxFilmes.Location = new System.Drawing.Point(70, 89);
            this.comboBoxFilmes.Name = "comboBoxFilmes";
            this.comboBoxFilmes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmes.TabIndex = 7;
            // 
            // ucSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.lbSessoesDisp);
            this.Controls.Add(this.gbConfigSessoes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucSessoes";
            this.Size = new System.Drawing.Size(773, 566);
            this.gbConfigSessoes.ResumeLayout(false);
            this.gbConfigSessoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfigSessoes;
        private System.Windows.Forms.Label lblEscolherSala;
        private System.Windows.Forms.Label lblEscolherFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarSessão;
        private System.Windows.Forms.ListBox lbSessoesDisp;
        private System.Windows.Forms.ComboBox comboBoxSalas;
        private System.Windows.Forms.ComboBox comboBoxFilmes;
    }
}
