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
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblWelcome.Location = new System.Drawing.Point(437, 47);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(149, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bem vindo,";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.txtUsername.Location = new System.Drawing.Point(460, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(93, 32);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "{user}!";
            // 
            // txtTipoUser
            // 
            this.txtTipoUser.AutoSize = true;
            this.txtTipoUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUser.Location = new System.Drawing.Point(459, 140);
            this.txtTipoUser.Name = "txtTipoUser";
            this.txtTipoUser.Size = new System.Drawing.Size(94, 23);
            this.txtTipoUser.TabIndex = 2;
            this.txtTipoUser.Text = "{tipouser}";
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.ItemHeight = 16;
            this.lbSessoes.Location = new System.Drawing.Point(120, 212);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(522, 372);
            this.lbSessoes.TabIndex = 3;
            // 
            // btnAdicionarBilhete
            // 
            this.btnAdicionarBilhete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarBilhete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarBilhete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarBilhete.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAdicionarBilhete.Location = new System.Drawing.Point(694, 335);
            this.btnAdicionarBilhete.Name = "btnAdicionarBilhete";
            this.btnAdicionarBilhete.Size = new System.Drawing.Size(191, 93);
            this.btnAdicionarBilhete.TabIndex = 4;
            this.btnAdicionarBilhete.Text = "ADICIONAR BILHETE";
            this.btnAdicionarBilhete.UseVisualStyleBackColor = false;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.btnAdicionarBilhete);
            this.Controls.Add(this.lbSessoes);
            this.Controls.Add(this.txtTipoUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblWelcome);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1031, 696);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtTipoUser;
        private System.Windows.Forms.ListBox lbSessoes;
        private System.Windows.Forms.Button btnAdicionarBilhete;
    }
}
