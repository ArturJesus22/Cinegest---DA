namespace WindowsFormsApp1
{
    partial class ucAtendimento
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
            this.gbConfigSala = new System.Windows.Forms.GroupBox();
            this.lblSessao = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblSalaOcupacao = new System.Windows.Forms.Label();
            this.cbEscolherSessao = new System.Windows.Forms.ComboBox();
            this.cbEscolherSala = new System.Windows.Forms.ComboBox();
            this.btnModificarSala = new System.Windows.Forms.Button();
            this.gbConfigSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConfigSala
            // 
            this.gbConfigSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbConfigSala.Controls.Add(this.btnModificarSala);
            this.gbConfigSala.Controls.Add(this.cbEscolherSala);
            this.gbConfigSala.Controls.Add(this.cbEscolherSessao);
            this.gbConfigSala.Controls.Add(this.lblSala);
            this.gbConfigSala.Controls.Add(this.lblSessao);
            this.gbConfigSala.Location = new System.Drawing.Point(90, 60);
            this.gbConfigSala.Name = "gbConfigSala";
            this.gbConfigSala.Size = new System.Drawing.Size(576, 231);
            this.gbConfigSala.TabIndex = 0;
            this.gbConfigSala.TabStop = false;
            this.gbConfigSala.Text = "Configurar Sala";
            // 
            // lblSessao
            // 
            this.lblSessao.AutoSize = true;
            this.lblSessao.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblSessao.Location = new System.Drawing.Point(40, 53);
            this.lblSessao.Name = "lblSessao";
            this.lblSessao.Size = new System.Drawing.Size(66, 17);
            this.lblSessao.TabIndex = 0;
            this.lblSessao.Text = "Sessão: ";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblSala.Location = new System.Drawing.Point(40, 97);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(41, 17);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala:";
            // 
            // lblSalaOcupacao
            // 
            this.lblSalaOcupacao.AutoSize = true;
            this.lblSalaOcupacao.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblSalaOcupacao.Location = new System.Drawing.Point(86, 324);
            this.lblSalaOcupacao.Name = "lblSalaOcupacao";
            this.lblSalaOcupacao.Size = new System.Drawing.Size(195, 24);
            this.lblSalaOcupacao.TabIndex = 1;
            this.lblSalaOcupacao.Text = " Ocupação da Sala:";
            // 
            // cbEscolherSessao
            // 
            this.cbEscolherSessao.FormattingEnabled = true;
            this.cbEscolherSessao.Location = new System.Drawing.Point(112, 53);
            this.cbEscolherSessao.Name = "cbEscolherSessao";
            this.cbEscolherSessao.Size = new System.Drawing.Size(121, 21);
            this.cbEscolherSessao.TabIndex = 2;
            // 
            // cbEscolherSala
            // 
            this.cbEscolherSala.FormattingEnabled = true;
            this.cbEscolherSala.Location = new System.Drawing.Point(112, 97);
            this.cbEscolherSala.Name = "cbEscolherSala";
            this.cbEscolherSala.Size = new System.Drawing.Size(121, 21);
            this.cbEscolherSala.TabIndex = 3;
            // 
            // btnModificarSala
            // 
            this.btnModificarSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificarSala.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSala.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnModificarSala.Location = new System.Drawing.Point(357, 70);
            this.btnModificarSala.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarSala.Name = "btnModificarSala";
            this.btnModificarSala.Size = new System.Drawing.Size(172, 91);
            this.btnModificarSala.TabIndex = 6;
            this.btnModificarSala.Text = "CRIAR MODIFICAÇÃO";
            this.btnModificarSala.UseVisualStyleBackColor = false;
            // 
            // ucAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.lblSalaOcupacao);
            this.Controls.Add(this.gbConfigSala);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucAtendimento";
            this.Size = new System.Drawing.Size(773, 566);
            this.gbConfigSala.ResumeLayout(false);
            this.gbConfigSala.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfigSala;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblSessao;
        private System.Windows.Forms.Label lblSalaOcupacao;
        private System.Windows.Forms.ComboBox cbEscolherSala;
        private System.Windows.Forms.ComboBox cbEscolherSessao;
        private System.Windows.Forms.Button btnModificarSala;
    }
}
