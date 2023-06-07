namespace WindowsFormsApp1
{
    partial class ucCinema
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
            this.gbConfigurarCinema = new System.Windows.Forms.GroupBox();
            this.lblSessao = new System.Windows.Forms.Label();
            this.updownColunas = new System.Windows.Forms.NumericUpDown();
            this.updownLinhas = new System.Windows.Forms.NumericUpDown();
            this.gbConfigTamanhoSala = new System.Windows.Forms.GroupBox();
            this.lblCinemaColunas = new System.Windows.Forms.Label();
            this.lblCinemaLinhas = new System.Windows.Forms.Label();
            this.lbSalasExistentes = new System.Windows.Forms.ListBox();
            this.updownQuantSalas = new System.Windows.Forms.NumericUpDown();
            this.gbConfigurarCinema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownLinhas)).BeginInit();
            this.gbConfigTamanhoSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownQuantSalas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConfigurarCinema
            // 
            this.gbConfigurarCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbConfigurarCinema.Controls.Add(this.updownQuantSalas);
            this.gbConfigurarCinema.Controls.Add(this.gbConfigTamanhoSala);
            this.gbConfigurarCinema.Controls.Add(this.lblSessao);
            this.gbConfigurarCinema.Location = new System.Drawing.Point(103, 61);
            this.gbConfigurarCinema.Name = "gbConfigurarCinema";
            this.gbConfigurarCinema.Size = new System.Drawing.Size(773, 299);
            this.gbConfigurarCinema.TabIndex = 8;
            this.gbConfigurarCinema.TabStop = false;
            this.gbConfigurarCinema.Text = "Configurar Cinema";
            // 
            // lblSessao
            // 
            this.lblSessao.AutoSize = true;
            this.lblSessao.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblSessao.Location = new System.Drawing.Point(22, 41);
            this.lblSessao.Name = "lblSessao";
            this.lblSessao.Size = new System.Drawing.Size(183, 21);
            this.lblSessao.TabIndex = 0;
            this.lblSessao.Text = "Quantidade de Salas:";
            // 
            // updownColunas
            // 
            this.updownColunas.Location = new System.Drawing.Point(118, 35);
            this.updownColunas.Name = "updownColunas";
            this.updownColunas.Size = new System.Drawing.Size(61, 22);
            this.updownColunas.TabIndex = 2;
            // 
            // updownLinhas
            // 
            this.updownLinhas.Location = new System.Drawing.Point(118, 88);
            this.updownLinhas.Name = "updownLinhas";
            this.updownLinhas.Size = new System.Drawing.Size(61, 22);
            this.updownLinhas.TabIndex = 3;
            // 
            // gbConfigTamanhoSala
            // 
            this.gbConfigTamanhoSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.gbConfigTamanhoSala.Controls.Add(this.lblCinemaLinhas);
            this.gbConfigTamanhoSala.Controls.Add(this.lblCinemaColunas);
            this.gbConfigTamanhoSala.Controls.Add(this.updownColunas);
            this.gbConfigTamanhoSala.Controls.Add(this.updownLinhas);
            this.gbConfigTamanhoSala.Location = new System.Drawing.Point(26, 90);
            this.gbConfigTamanhoSala.Name = "gbConfigTamanhoSala";
            this.gbConfigTamanhoSala.Size = new System.Drawing.Size(698, 182);
            this.gbConfigTamanhoSala.TabIndex = 4;
            this.gbConfigTamanhoSala.TabStop = false;
            this.gbConfigTamanhoSala.Text = "Tamanho da Sala";
            // 
            // lblCinemaColunas
            // 
            this.lblCinemaColunas.AutoSize = true;
            this.lblCinemaColunas.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblCinemaColunas.Location = new System.Drawing.Point(22, 33);
            this.lblCinemaColunas.Name = "lblCinemaColunas";
            this.lblCinemaColunas.Size = new System.Drawing.Size(81, 21);
            this.lblCinemaColunas.TabIndex = 5;
            this.lblCinemaColunas.Text = "Colunas:";
            // 
            // lblCinemaLinhas
            // 
            this.lblCinemaLinhas.AutoSize = true;
            this.lblCinemaLinhas.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblCinemaLinhas.Location = new System.Drawing.Point(22, 86);
            this.lblCinemaLinhas.Name = "lblCinemaLinhas";
            this.lblCinemaLinhas.Size = new System.Drawing.Size(68, 21);
            this.lblCinemaLinhas.TabIndex = 6;
            this.lblCinemaLinhas.Text = "Linhas:";
            // 
            // lbSalasExistentes
            // 
            this.lbSalasExistentes.FormattingEnabled = true;
            this.lbSalasExistentes.ItemHeight = 16;
            this.lbSalasExistentes.Location = new System.Drawing.Point(103, 369);
            this.lbSalasExistentes.Name = "lbSalasExistentes";
            this.lbSalasExistentes.Size = new System.Drawing.Size(773, 292);
            this.lbSalasExistentes.TabIndex = 9;
            // 
            // updownQuantSalas
            // 
            this.updownQuantSalas.Location = new System.Drawing.Point(220, 41);
            this.updownQuantSalas.Name = "updownQuantSalas";
            this.updownQuantSalas.Size = new System.Drawing.Size(66, 22);
            this.updownQuantSalas.TabIndex = 7;
            // 
            // ucCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.lbSalasExistentes);
            this.Controls.Add(this.gbConfigurarCinema);
            this.Name = "ucCinema";
            this.Size = new System.Drawing.Size(1031, 696);
            this.gbConfigurarCinema.ResumeLayout(false);
            this.gbConfigurarCinema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownLinhas)).EndInit();
            this.gbConfigTamanhoSala.ResumeLayout(false);
            this.gbConfigTamanhoSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownQuantSalas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfigurarCinema;
        private System.Windows.Forms.NumericUpDown updownQuantSalas;
        private System.Windows.Forms.GroupBox gbConfigTamanhoSala;
        private System.Windows.Forms.Label lblCinemaLinhas;
        private System.Windows.Forms.Label lblCinemaColunas;
        private System.Windows.Forms.NumericUpDown updownColunas;
        private System.Windows.Forms.NumericUpDown updownLinhas;
        private System.Windows.Forms.Label lblSessao;
        private System.Windows.Forms.ListBox lbSalasExistentes;
    }
}
