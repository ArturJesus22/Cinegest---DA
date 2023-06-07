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
            this.lblOcupacoes = new System.Windows.Forms.Label();
            this.bgConfigSala = new System.Windows.Forms.GroupBox();
            this.lblSessao = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.bgConfigSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOcupacoes
            // 
            this.lblOcupacoes.AutoSize = true;
            this.lblOcupacoes.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblOcupacoes.Location = new System.Drawing.Point(141, 394);
            this.lblOcupacoes.Name = "lblOcupacoes";
            this.lblOcupacoes.Size = new System.Drawing.Size(242, 32);
            this.lblOcupacoes.TabIndex = 6;
            this.lblOcupacoes.Text = "Ocupação da sala:";
            // 
            // bgConfigSala
            // 
            this.bgConfigSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.bgConfigSala.Controls.Add(this.lblSala);
            this.bgConfigSala.Controls.Add(this.lblSessao);
            this.bgConfigSala.Location = new System.Drawing.Point(147, 100);
            this.bgConfigSala.Name = "bgConfigSala";
            this.bgConfigSala.Size = new System.Drawing.Size(687, 234);
            this.bgConfigSala.TabIndex = 7;
            this.bgConfigSala.TabStop = false;
            this.bgConfigSala.Text = "Configurar Sala";
            // 
            // lblSessao
            // 
            this.lblSessao.AutoSize = true;
            this.lblSessao.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblSessao.Location = new System.Drawing.Point(26, 50);
            this.lblSessao.Name = "lblSessao";
            this.lblSessao.Size = new System.Drawing.Size(75, 21);
            this.lblSessao.TabIndex = 0;
            this.lblSessao.Text = "Sessão:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblSala.Location = new System.Drawing.Point(26, 99);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(51, 21);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala:";
            // 
            // ucAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.bgConfigSala);
            this.Controls.Add(this.lblOcupacoes);
            this.Name = "ucAtendimento";
            this.Size = new System.Drawing.Size(1031, 696);
            this.bgConfigSala.ResumeLayout(false);
            this.bgConfigSala.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOcupacoes;
        private System.Windows.Forms.GroupBox bgConfigSala;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblSessao;
    }
}
