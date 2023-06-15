namespace WindowsFormsApp1
{
    partial class ucFilmes
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
            this.gbCriarFilmes = new System.Windows.Forms.GroupBox();
            this.lblCriarEstadoFilme = new System.Windows.Forms.Label();
            this.txtAdicionarNomeFilme = new System.Windows.Forms.TextBox();
            this.cbCriarFilmeAtivo = new System.Windows.Forms.CheckBox();
            this.comboBoxFilmes = new System.Windows.Forms.ComboBox();
            this.btnAdicionarFilme = new System.Windows.Forms.Button();
            this.lblCriarCategoriaFilme = new System.Windows.Forms.Label();
            this.lblCriarNomeFilme = new System.Windows.Forms.Label();
            this.gbAlterarFilmes = new System.Windows.Forms.GroupBox();
            this.lblAlterarEstadoFilme = new System.Windows.Forms.Label();
            this.comboBoxAlterarFilmes = new System.Windows.Forms.ComboBox();
            this.cbAlterarFilmeAtivo = new System.Windows.Forms.CheckBox();
            this.lblAlterarCategoriaFilme = new System.Windows.Forms.Label();
            this.cbListaFilmesCriados = new System.Windows.Forms.ComboBox();
            this.btnModificarFilme = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCriarFilmes.SuspendLayout();
            this.gbAlterarFilmes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCriarFilmes
            // 
            this.gbCriarFilmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbCriarFilmes.Controls.Add(this.lblCriarEstadoFilme);
            this.gbCriarFilmes.Controls.Add(this.txtAdicionarNomeFilme);
            this.gbCriarFilmes.Controls.Add(this.cbCriarFilmeAtivo);
            this.gbCriarFilmes.Controls.Add(this.comboBoxFilmes);
            this.gbCriarFilmes.Controls.Add(this.btnAdicionarFilme);
            this.gbCriarFilmes.Controls.Add(this.lblCriarCategoriaFilme);
            this.gbCriarFilmes.Controls.Add(this.lblCriarNomeFilme);
            this.gbCriarFilmes.Location = new System.Drawing.Point(82, 78);
            this.gbCriarFilmes.Name = "gbCriarFilmes";
            this.gbCriarFilmes.Size = new System.Drawing.Size(576, 177);
            this.gbCriarFilmes.TabIndex = 3;
            this.gbCriarFilmes.TabStop = false;
            this.gbCriarFilmes.Text = "Criar Filmes";
            // 
            // lblCriarEstadoFilme
            // 
            this.lblCriarEstadoFilme.AutoSize = true;
            this.lblCriarEstadoFilme.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblCriarEstadoFilme.Location = new System.Drawing.Point(23, 128);
            this.lblCriarEstadoFilme.Name = "lblCriarEstadoFilme";
            this.lblCriarEstadoFilme.Size = new System.Drawing.Size(58, 17);
            this.lblCriarEstadoFilme.TabIndex = 10;
            this.lblCriarEstadoFilme.Text = "Estado:";
            // 
            // txtAdicionarNomeFilme
            // 
            this.txtAdicionarNomeFilme.Location = new System.Drawing.Point(104, 54);
            this.txtAdicionarNomeFilme.Name = "txtAdicionarNomeFilme";
            this.txtAdicionarNomeFilme.Size = new System.Drawing.Size(121, 20);
            this.txtAdicionarNomeFilme.TabIndex = 9;
            // 
            // cbCriarFilmeAtivo
            // 
            this.cbCriarFilmeAtivo.AutoSize = true;
            this.cbCriarFilmeAtivo.Font = new System.Drawing.Font("Arial", 10.75F);
            this.cbCriarFilmeAtivo.Location = new System.Drawing.Point(104, 128);
            this.cbCriarFilmeAtivo.Name = "cbCriarFilmeAtivo";
            this.cbCriarFilmeAtivo.Size = new System.Drawing.Size(58, 21);
            this.cbCriarFilmeAtivo.TabIndex = 8;
            this.cbCriarFilmeAtivo.Text = "Ativo";
            this.cbCriarFilmeAtivo.UseVisualStyleBackColor = true;
            this.cbCriarFilmeAtivo.CheckedChanged += new System.EventHandler(this.cbCriarFilmeAtivo_CheckedChanged);
            // 
            // comboBoxFilmes
            // 
            this.comboBoxFilmes.FormattingEnabled = true;
            this.comboBoxFilmes.Location = new System.Drawing.Point(104, 90);
            this.comboBoxFilmes.Name = "comboBoxFilmes";
            this.comboBoxFilmes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmes.TabIndex = 7;
            this.comboBoxFilmes.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmes_SelectedIndexChanged);
            // 
            // btnAdicionarFilme
            // 
            this.btnAdicionarFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarFilme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFilme.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAdicionarFilme.Location = new System.Drawing.Point(409, 54);
            this.btnAdicionarFilme.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarFilme.Name = "btnAdicionarFilme";
            this.btnAdicionarFilme.Size = new System.Drawing.Size(143, 76);
            this.btnAdicionarFilme.TabIndex = 5;
            this.btnAdicionarFilme.Text = "ADICIONAR FILME";
            this.btnAdicionarFilme.UseVisualStyleBackColor = false;
            this.btnAdicionarFilme.Click += new System.EventHandler(this.btnAdicionarFilme_Click);
            // 
            // lblCriarCategoriaFilme
            // 
            this.lblCriarCategoriaFilme.AutoSize = true;
            this.lblCriarCategoriaFilme.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblCriarCategoriaFilme.Location = new System.Drawing.Point(23, 90);
            this.lblCriarCategoriaFilme.Name = "lblCriarCategoriaFilme";
            this.lblCriarCategoriaFilme.Size = new System.Drawing.Size(75, 17);
            this.lblCriarCategoriaFilme.TabIndex = 1;
            this.lblCriarCategoriaFilme.Text = "Categoria:";
            // 
            // lblCriarNomeFilme
            // 
            this.lblCriarNomeFilme.AutoSize = true;
            this.lblCriarNomeFilme.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblCriarNomeFilme.Location = new System.Drawing.Point(23, 54);
            this.lblCriarNomeFilme.Name = "lblCriarNomeFilme";
            this.lblCriarNomeFilme.Size = new System.Drawing.Size(51, 17);
            this.lblCriarNomeFilme.TabIndex = 0;
            this.lblCriarNomeFilme.Text = "Nome:";
            // 
            // gbAlterarFilmes
            // 
            this.gbAlterarFilmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbAlterarFilmes.Controls.Add(this.lblAlterarEstadoFilme);
            this.gbAlterarFilmes.Controls.Add(this.comboBoxAlterarFilmes);
            this.gbAlterarFilmes.Controls.Add(this.cbAlterarFilmeAtivo);
            this.gbAlterarFilmes.Controls.Add(this.lblAlterarCategoriaFilme);
            this.gbAlterarFilmes.Controls.Add(this.cbListaFilmesCriados);
            this.gbAlterarFilmes.Controls.Add(this.btnModificarFilme);
            this.gbAlterarFilmes.Controls.Add(this.label5);
            this.gbAlterarFilmes.Location = new System.Drawing.Point(82, 308);
            this.gbAlterarFilmes.Name = "gbAlterarFilmes";
            this.gbAlterarFilmes.Size = new System.Drawing.Size(576, 177);
            this.gbAlterarFilmes.TabIndex = 8;
            this.gbAlterarFilmes.TabStop = false;
            this.gbAlterarFilmes.Text = "Alterar Filmes";
            // 
            // lblAlterarEstadoFilme
            // 
            this.lblAlterarEstadoFilme.AutoSize = true;
            this.lblAlterarEstadoFilme.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblAlterarEstadoFilme.Location = new System.Drawing.Point(23, 126);
            this.lblAlterarEstadoFilme.Name = "lblAlterarEstadoFilme";
            this.lblAlterarEstadoFilme.Size = new System.Drawing.Size(58, 17);
            this.lblAlterarEstadoFilme.TabIndex = 11;
            this.lblAlterarEstadoFilme.Text = "Estado:";
            // 
            // comboBoxAlterarFilmes
            // 
            this.comboBoxAlterarFilmes.FormattingEnabled = true;
            this.comboBoxAlterarFilmes.Location = new System.Drawing.Point(137, 86);
            this.comboBoxAlterarFilmes.Name = "comboBoxAlterarFilmes";
            this.comboBoxAlterarFilmes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlterarFilmes.TabIndex = 11;
            this.comboBoxAlterarFilmes.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlterarFilmes_SelectedIndexChanged);
            // 
            // cbAlterarFilmeAtivo
            // 
            this.cbAlterarFilmeAtivo.AutoSize = true;
            this.cbAlterarFilmeAtivo.Font = new System.Drawing.Font("Arial", 10.75F);
            this.cbAlterarFilmeAtivo.Location = new System.Drawing.Point(87, 126);
            this.cbAlterarFilmeAtivo.Name = "cbAlterarFilmeAtivo";
            this.cbAlterarFilmeAtivo.Size = new System.Drawing.Size(58, 21);
            this.cbAlterarFilmeAtivo.TabIndex = 9;
            this.cbAlterarFilmeAtivo.Text = "Ativo";
            this.cbAlterarFilmeAtivo.UseVisualStyleBackColor = true;
            this.cbAlterarFilmeAtivo.CheckedChanged += new System.EventHandler(this.cbAlterarFilmeAtivo_CheckedChanged);
            // 
            // lblAlterarCategoriaFilme
            // 
            this.lblAlterarCategoriaFilme.AutoSize = true;
            this.lblAlterarCategoriaFilme.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblAlterarCategoriaFilme.Location = new System.Drawing.Point(23, 86);
            this.lblAlterarCategoriaFilme.Name = "lblAlterarCategoriaFilme";
            this.lblAlterarCategoriaFilme.Size = new System.Drawing.Size(75, 17);
            this.lblAlterarCategoriaFilme.TabIndex = 10;
            this.lblAlterarCategoriaFilme.Text = "Categoria:";
            // 
            // cbListaFilmesCriados
            // 
            this.cbListaFilmesCriados.FormattingEnabled = true;
            this.cbListaFilmesCriados.Location = new System.Drawing.Point(137, 54);
            this.cbListaFilmesCriados.Name = "cbListaFilmesCriados";
            this.cbListaFilmesCriados.Size = new System.Drawing.Size(121, 21);
            this.cbListaFilmesCriados.TabIndex = 7;
            // 
            // btnModificarFilme
            // 
            this.btnModificarFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificarFilme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificarFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFilme.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnModificarFilme.Location = new System.Drawing.Point(409, 54);
            this.btnModificarFilme.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarFilme.Name = "btnModificarFilme";
            this.btnModificarFilme.Size = new System.Drawing.Size(143, 76);
            this.btnModificarFilme.TabIndex = 5;
            this.btnModificarFilme.Text = "MODIFICAR FILME";
            this.btnModificarFilme.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.75F);
            this.label5.Location = new System.Drawing.Point(23, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Filmes Criados:";
            // 
            // ucFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.gbAlterarFilmes);
            this.Controls.Add(this.gbCriarFilmes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucFilmes";
            this.Size = new System.Drawing.Size(773, 566);
            this.gbCriarFilmes.ResumeLayout(false);
            this.gbCriarFilmes.PerformLayout();
            this.gbAlterarFilmes.ResumeLayout(false);
            this.gbAlterarFilmes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCriarFilmes;
        private System.Windows.Forms.CheckBox cbCriarFilmeAtivo;
        private System.Windows.Forms.ComboBox comboBoxFilmes;
        private System.Windows.Forms.Button btnAdicionarFilme;
        private System.Windows.Forms.Label lblCriarCategoriaFilme;
        private System.Windows.Forms.Label lblCriarNomeFilme;
        private System.Windows.Forms.GroupBox gbAlterarFilmes;
        private System.Windows.Forms.CheckBox cbAlterarFilmeAtivo;
        private System.Windows.Forms.ComboBox cbListaFilmesCriados;
        private System.Windows.Forms.Button btnModificarFilme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdicionarNomeFilme;
        private System.Windows.Forms.Label lblCriarEstadoFilme;
        private System.Windows.Forms.Label lblAlterarEstadoFilme;
        private System.Windows.Forms.ComboBox comboBoxAlterarFilmes;
        private System.Windows.Forms.Label lblAlterarCategoriaFilme;
    }
}
