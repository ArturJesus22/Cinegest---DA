namespace WindowsFormsApp1
{
    partial class ucHome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtTipoUser = new System.Windows.Forms.Label();
            this.lbSessoes = new System.Windows.Forms.ListBox();
            this.btnAdicionarBilhete = new System.Windows.Forms.Button();
            this.lblSessoesHoje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblWelcome.Location = new System.Drawing.Point(328, 38);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bem vindo,";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.txtUsername.Location = new System.Drawing.Point(345, 79);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(71, 24);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "{user}!";
            // 
            // txtTipoUser
            // 
            this.txtTipoUser.AutoSize = true;
            this.txtTipoUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUser.Location = new System.Drawing.Point(344, 114);
            this.txtTipoUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTipoUser.Name = "txtTipoUser";
            this.txtTipoUser.Size = new System.Drawing.Size(74, 18);
            this.txtTipoUser.TabIndex = 2;
            this.txtTipoUser.Text = "{tipouser}";
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.Location = new System.Drawing.Point(90, 172);
            this.lbSessoes.Margin = new System.Windows.Forms.Padding(2);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(392, 303);
            this.lbSessoes.TabIndex = 3;
            // 
            // btnAdicionarBilhete
            // 
            this.btnAdicionarBilhete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarBilhete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarBilhete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarBilhete.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAdicionarBilhete.Location = new System.Drawing.Point(520, 272);
            this.btnAdicionarBilhete.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarBilhete.Name = "btnAdicionarBilhete";
            this.btnAdicionarBilhete.Size = new System.Drawing.Size(143, 76);
            this.btnAdicionarBilhete.TabIndex = 4;
            this.btnAdicionarBilhete.Text = "ADICIONAR BILHETE";
            this.btnAdicionarBilhete.UseVisualStyleBackColor = false;
            // 
            // lblSessoesHoje
            // 
            this.lblSessoesHoje.AutoSize = true;
            this.lblSessoesHoje.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblSessoesHoje.Location = new System.Drawing.Point(86, 146);
            this.lblSessoesHoje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSessoesHoje.Name = "lblSessoesHoje";
            this.lblSessoesHoje.Size = new System.Drawing.Size(195, 24);
            this.lblSessoesHoje.TabIndex = 5;
            this.lblSessoesHoje.Text = "Sessões para Hoje:";
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.lblSessoesHoje);
            this.Controls.Add(this.btnAdicionarBilhete);
            this.Controls.Add(this.lbSessoes);
            this.Controls.Add(this.txtTipoUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(773, 566);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtTipoUser;
        private System.Windows.Forms.ListBox lbSessoes;
        private System.Windows.Forms.Button btnAdicionarBilhete;
        private System.Windows.Forms.Label lblSessoesHoje;
    }
}
