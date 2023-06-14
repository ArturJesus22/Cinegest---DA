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
            this.gbConfigCinema = new System.Windows.Forms.GroupBox();
            this.updownQuantSalas = new System.Windows.Forms.NumericUpDown();
            this.gbTamanhoSala = new System.Windows.Forms.GroupBox();
            this.updownLinhas = new System.Windows.Forms.NumericUpDown();
            this.updownColunas = new System.Windows.Forms.NumericUpDown();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.lblColunas = new System.Windows.Forms.Label();
            this.lblQuantSalas = new System.Windows.Forms.Label();
            this.lbSalasExistentes = new System.Windows.Forms.ListBox();
            this.btnAdicionarSala = new System.Windows.Forms.Button();
            this.gbConfigCinema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownQuantSalas)).BeginInit();
            this.gbTamanhoSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConfigCinema
            // 
            this.gbConfigCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbConfigCinema.Controls.Add(this.updownQuantSalas);
            this.gbConfigCinema.Controls.Add(this.gbTamanhoSala);
            this.gbConfigCinema.Controls.Add(this.lblQuantSalas);
            this.gbConfigCinema.Location = new System.Drawing.Point(84, 31);
            this.gbConfigCinema.Name = "gbConfigCinema";
            this.gbConfigCinema.Size = new System.Drawing.Size(576, 223);
            this.gbConfigCinema.TabIndex = 1;
            this.gbConfigCinema.TabStop = false;
            this.gbConfigCinema.Text = "Configurar Sala";
            // 
            // updownQuantSalas
            // 
            this.updownQuantSalas.Location = new System.Drawing.Point(188, 33);
            this.updownQuantSalas.Name = "updownQuantSalas";
            this.updownQuantSalas.Size = new System.Drawing.Size(57, 20);
            this.updownQuantSalas.TabIndex = 3;
            // 
            // gbTamanhoSala
            // 
            this.gbTamanhoSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.gbTamanhoSala.Controls.Add(this.btnAdicionarSala);
            this.gbTamanhoSala.Controls.Add(this.updownLinhas);
            this.gbTamanhoSala.Controls.Add(this.updownColunas);
            this.gbTamanhoSala.Controls.Add(this.lblLinhas);
            this.gbTamanhoSala.Controls.Add(this.lblColunas);
            this.gbTamanhoSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTamanhoSala.Location = new System.Drawing.Point(38, 73);
            this.gbTamanhoSala.Name = "gbTamanhoSala";
            this.gbTamanhoSala.Size = new System.Drawing.Size(503, 127);
            this.gbTamanhoSala.TabIndex = 2;
            this.gbTamanhoSala.TabStop = false;
            this.gbTamanhoSala.Text = "Tamanho da Sala";
            // 
            // updownLinhas
            // 
            this.updownLinhas.Location = new System.Drawing.Point(101, 69);
            this.updownLinhas.Name = "updownLinhas";
            this.updownLinhas.Size = new System.Drawing.Size(57, 20);
            this.updownLinhas.TabIndex = 5;
            // 
            // updownColunas
            // 
            this.updownColunas.Location = new System.Drawing.Point(101, 35);
            this.updownColunas.Name = "updownColunas";
            this.updownColunas.Size = new System.Drawing.Size(57, 20);
            this.updownColunas.TabIndex = 4;
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblLinhas.Location = new System.Drawing.Point(18, 69);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(55, 17);
            this.lblLinhas.TabIndex = 2;
            this.lblLinhas.Text = "Linhas:";
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblColunas.Location = new System.Drawing.Point(18, 35);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(66, 17);
            this.lblColunas.TabIndex = 1;
            this.lblColunas.Text = "Colunas:";
            // 
            // lblQuantSalas
            // 
            this.lblQuantSalas.AutoSize = true;
            this.lblQuantSalas.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblQuantSalas.Location = new System.Drawing.Point(23, 33);
            this.lblQuantSalas.Name = "lblQuantSalas";
            this.lblQuantSalas.Size = new System.Drawing.Size(148, 17);
            this.lblQuantSalas.TabIndex = 0;
            this.lblQuantSalas.Text = "Quantidade de Salas:";
            // 
            // lbSalasExistentes
            // 
            this.lbSalasExistentes.FormattingEnabled = true;
            this.lbSalasExistentes.Location = new System.Drawing.Point(84, 278);
            this.lbSalasExistentes.Name = "lbSalasExistentes";
            this.lbSalasExistentes.Size = new System.Drawing.Size(576, 238);
            this.lbSalasExistentes.TabIndex = 2;
            // 
            // btnAdicionarSala
            // 
            this.btnAdicionarSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarSala.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSala.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAdicionarSala.Location = new System.Drawing.Point(336, 18);
            this.btnAdicionarSala.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarSala.Name = "btnAdicionarSala";
            this.btnAdicionarSala.Size = new System.Drawing.Size(143, 76);
            this.btnAdicionarSala.TabIndex = 6;
            this.btnAdicionarSala.Text = "ADICIONAR SALA";
            this.btnAdicionarSala.UseVisualStyleBackColor = false;
            // 
            // ucCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.lbSalasExistentes);
            this.Controls.Add(this.gbConfigCinema);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucCinema";
            this.Size = new System.Drawing.Size(773, 566);
            this.gbConfigCinema.ResumeLayout(false);
            this.gbConfigCinema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownQuantSalas)).EndInit();
            this.gbTamanhoSala.ResumeLayout(false);
            this.gbTamanhoSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownColunas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfigCinema;
        private System.Windows.Forms.NumericUpDown updownQuantSalas;
        private System.Windows.Forms.GroupBox gbTamanhoSala;
        private System.Windows.Forms.NumericUpDown updownColunas;
        private System.Windows.Forms.Label lblLinhas;
        private System.Windows.Forms.Label lblColunas;
        private System.Windows.Forms.Label lblQuantSalas;
        private System.Windows.Forms.NumericUpDown updownLinhas;
        private System.Windows.Forms.ListBox lbSalasExistentes;
        private System.Windows.Forms.Button btnAdicionarSala;
    }
}
