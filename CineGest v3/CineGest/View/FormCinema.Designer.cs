namespace WindowsFormsApp1.View
{
    partial class FormCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCinema));
            this.pbGestao = new System.Windows.Forms.PictureBox();
            this.lblgestao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.pbSessoes = new System.Windows.Forms.PictureBox();
            this.pbFilmes = new System.Windows.Forms.PictureBox();
            this.pbCinema = new System.Windows.Forms.PictureBox();
            this.pbLogoMenu = new System.Windows.Forms.PictureBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.painelContentor = new System.Windows.Forms.Panel();
            this.lbSalasExistentes = new System.Windows.Forms.ListBox();
            this.gbConfigCinema = new System.Windows.Forms.GroupBox();
            this.updownQuantSalas = new System.Windows.Forms.NumericUpDown();
            this.gbTamanhoSala = new System.Windows.Forms.GroupBox();
            this.btnAdicionarSala = new System.Windows.Forms.Button();
            this.updownLinhas = new System.Windows.Forms.NumericUpDown();
            this.updownColunas = new System.Windows.Forms.NumericUpDown();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.lblColunas = new System.Windows.Forms.Label();
            this.lblQuantSalas = new System.Windows.Forms.Label();
            this.pbAtendimento = new System.Windows.Forms.PictureBox();
            this.lblUpperMenu = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblSessoes = new System.Windows.Forms.Label();
            this.lblFilmes = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblAtendimento = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblMenuMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).BeginInit();
            this.painelContentor.SuspendLayout();
            this.gbConfigCinema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownQuantSalas)).BeginInit();
            this.gbTamanhoSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGestao
            // 
            this.pbGestao.Image = ((System.Drawing.Image)(resources.GetObject("pbGestao.Image")));
            this.pbGestao.Location = new System.Drawing.Point(47, 459);
            this.pbGestao.Margin = new System.Windows.Forms.Padding(2);
            this.pbGestao.Name = "pbGestao";
            this.pbGestao.Size = new System.Drawing.Size(33, 38);
            this.pbGestao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGestao.TabIndex = 54;
            this.pbGestao.TabStop = false;
            this.pbGestao.Visible = false;
            this.pbGestao.Click += new System.EventHandler(this.lblgestao_Click);
            // 
            // lblgestao
            // 
            this.lblgestao.AutoSize = true;
            this.lblgestao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestao.ForeColor = System.Drawing.Color.White;
            this.lblgestao.Location = new System.Drawing.Point(87, 463);
            this.lblgestao.Name = "lblgestao";
            this.lblgestao.Size = new System.Drawing.Size(79, 24);
            this.lblgestao.TabIndex = 53;
            this.lblgestao.Text = "Gestão";
            this.lblgestao.Visible = false;
            this.lblgestao.Click += new System.EventHandler(this.lblgestao_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 567);
            this.label1.TabIndex = 52;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(11, 525);
            this.pbSair.Margin = new System.Windows.Forms.Padding(2);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(36, 28);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 51;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.pbSair_Click);
            // 
            // pbClientes
            // 
            this.pbClientes.Image = ((System.Drawing.Image)(resources.GetObject("pbClientes.Image")));
            this.pbClientes.Location = new System.Drawing.Point(47, 413);
            this.pbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(33, 38);
            this.pbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClientes.TabIndex = 50;
            this.pbClientes.TabStop = false;
            this.pbClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // pbDashboard
            // 
            this.pbDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pbDashboard.Image")));
            this.pbDashboard.Location = new System.Drawing.Point(45, 181);
            this.pbDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(33, 38);
            this.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDashboard.TabIndex = 45;
            this.pbDashboard.TabStop = false;
            this.pbDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // pbSessoes
            // 
            this.pbSessoes.Image = ((System.Drawing.Image)(resources.GetObject("pbSessoes.Image")));
            this.pbSessoes.Location = new System.Drawing.Point(46, 228);
            this.pbSessoes.Margin = new System.Windows.Forms.Padding(2);
            this.pbSessoes.Name = "pbSessoes";
            this.pbSessoes.Size = new System.Drawing.Size(33, 38);
            this.pbSessoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSessoes.TabIndex = 47;
            this.pbSessoes.TabStop = false;
            this.pbSessoes.Click += new System.EventHandler(this.lblSessoes_Click);
            // 
            // pbFilmes
            // 
            this.pbFilmes.Image = ((System.Drawing.Image)(resources.GetObject("pbFilmes.Image")));
            this.pbFilmes.Location = new System.Drawing.Point(46, 368);
            this.pbFilmes.Margin = new System.Windows.Forms.Padding(2);
            this.pbFilmes.Name = "pbFilmes";
            this.pbFilmes.Size = new System.Drawing.Size(33, 38);
            this.pbFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilmes.TabIndex = 48;
            this.pbFilmes.TabStop = false;
            this.pbFilmes.Click += new System.EventHandler(this.lblFilmes_Click);
            // 
            // pbCinema
            // 
            this.pbCinema.Image = ((System.Drawing.Image)(resources.GetObject("pbCinema.Image")));
            this.pbCinema.Location = new System.Drawing.Point(46, 320);
            this.pbCinema.Margin = new System.Windows.Forms.Padding(2);
            this.pbCinema.Name = "pbCinema";
            this.pbCinema.Size = new System.Drawing.Size(33, 38);
            this.pbCinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCinema.TabIndex = 49;
            this.pbCinema.TabStop = false;
            // 
            // pbLogoMenu
            // 
            this.pbLogoMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoMenu.Image")));
            this.pbLogoMenu.Location = new System.Drawing.Point(23, 18);
            this.pbLogoMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoMenu.Name = "pbLogoMenu";
            this.pbLogoMenu.Size = new System.Drawing.Size(196, 86);
            this.pbLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoMenu.TabIndex = 44;
            this.pbLogoMenu.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.BackColor = System.Drawing.Color.Silver;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(245, 6);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(207, 20);
            this.lb_data.TabIndex = 43;
            // 
            // painelContentor
            // 
            this.painelContentor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.painelContentor.Controls.Add(this.lbSalasExistentes);
            this.painelContentor.Controls.Add(this.gbConfigCinema);
            this.painelContentor.Location = new System.Drawing.Point(246, 30);
            this.painelContentor.Name = "painelContentor";
            this.painelContentor.Size = new System.Drawing.Size(782, 537);
            this.painelContentor.TabIndex = 42;
            // 
            // lbSalasExistentes
            // 
            this.lbSalasExistentes.FormattingEnabled = true;
            this.lbSalasExistentes.Location = new System.Drawing.Point(103, 273);
            this.lbSalasExistentes.Name = "lbSalasExistentes";
            this.lbSalasExistentes.Size = new System.Drawing.Size(576, 238);
            this.lbSalasExistentes.TabIndex = 4;
            // 
            // gbConfigCinema
            // 
            this.gbConfigCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbConfigCinema.Controls.Add(this.updownQuantSalas);
            this.gbConfigCinema.Controls.Add(this.gbTamanhoSala);
            this.gbConfigCinema.Controls.Add(this.lblQuantSalas);
            this.gbConfigCinema.Location = new System.Drawing.Point(103, 26);
            this.gbConfigCinema.Name = "gbConfigCinema";
            this.gbConfigCinema.Size = new System.Drawing.Size(576, 223);
            this.gbConfigCinema.TabIndex = 3;
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
            this.btnAdicionarSala.Click += new System.EventHandler(this.btnAdicionarSala_Click);
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
            // pbAtendimento
            // 
            this.pbAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("pbAtendimento.Image")));
            this.pbAtendimento.Location = new System.Drawing.Point(40, 272);
            this.pbAtendimento.Margin = new System.Windows.Forms.Padding(2);
            this.pbAtendimento.Name = "pbAtendimento";
            this.pbAtendimento.Size = new System.Drawing.Size(40, 39);
            this.pbAtendimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtendimento.TabIndex = 46;
            this.pbAtendimento.TabStop = false;
            this.pbAtendimento.Click += new System.EventHandler(this.lblAtendimento_Click);
            // 
            // lblUpperMenu
            // 
            this.lblUpperMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.lblUpperMenu.Location = new System.Drawing.Point(246, 0);
            this.lblUpperMenu.Name = "lblUpperMenu";
            this.lblUpperMenu.Size = new System.Drawing.Size(782, 31);
            this.lblUpperMenu.TabIndex = 41;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(87, 417);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(86, 24);
            this.lblClientes.TabIndex = 40;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // lblSessoes
            // 
            this.lblSessoes.AutoSize = true;
            this.lblSessoes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessoes.ForeColor = System.Drawing.Color.White;
            this.lblSessoes.Location = new System.Drawing.Point(86, 232);
            this.lblSessoes.Name = "lblSessoes";
            this.lblSessoes.Size = new System.Drawing.Size(93, 24);
            this.lblSessoes.TabIndex = 39;
            this.lblSessoes.Text = "Sessões";
            this.lblSessoes.Click += new System.EventHandler(this.lblSessoes_Click);
            // 
            // lblFilmes
            // 
            this.lblFilmes.AutoSize = true;
            this.lblFilmes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmes.ForeColor = System.Drawing.Color.White;
            this.lblFilmes.Location = new System.Drawing.Point(86, 373);
            this.lblFilmes.Name = "lblFilmes";
            this.lblFilmes.Size = new System.Drawing.Size(71, 24);
            this.lblFilmes.TabIndex = 38;
            this.lblFilmes.Text = "Filmes";
            this.lblFilmes.Click += new System.EventHandler(this.lblFilmes_Click);
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.ForeColor = System.Drawing.Color.White;
            this.lblCinema.Location = new System.Drawing.Point(86, 325);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(81, 24);
            this.lblCinema.TabIndex = 37;
            this.lblCinema.Text = "Cinema";
            // 
            // lblAtendimento
            // 
            this.lblAtendimento.AutoSize = true;
            this.lblAtendimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimento.ForeColor = System.Drawing.Color.White;
            this.lblAtendimento.Location = new System.Drawing.Point(85, 280);
            this.lblAtendimento.Name = "lblAtendimento";
            this.lblAtendimento.Size = new System.Drawing.Size(125, 24);
            this.lblAtendimento.TabIndex = 36;
            this.lblAtendimento.Text = "Atendimento";
            this.lblAtendimento.Click += new System.EventHandler(this.lblAtendimento_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(85, 190);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(112, 24);
            this.lblDashboard.TabIndex = 35;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // lblMenuMenu
            // 
            this.lblMenuMenu.AutoSize = true;
            this.lblMenuMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenuMenu.Location = new System.Drawing.Point(27, 150);
            this.lblMenuMenu.Name = "lblMenuMenu";
            this.lblMenuMenu.Size = new System.Drawing.Size(43, 17);
            this.lblMenuMenu.TabIndex = 34;
            this.lblMenuMenu.Text = "Menu";
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1027, 564);
            this.Controls.Add(this.pbGestao);
            this.Controls.Add(this.lblgestao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSair);
            this.Controls.Add(this.pbClientes);
            this.Controls.Add(this.pbDashboard);
            this.Controls.Add(this.pbSessoes);
            this.Controls.Add(this.pbFilmes);
            this.Controls.Add(this.pbCinema);
            this.Controls.Add(this.pbLogoMenu);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.painelContentor);
            this.Controls.Add(this.pbAtendimento);
            this.Controls.Add(this.lblUpperMenu);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblSessoes);
            this.Controls.Add(this.lblFilmes);
            this.Controls.Add(this.lblCinema);
            this.Controls.Add(this.lblAtendimento);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.lblMenuMenu);
            this.Name = "FormCinema";
            this.Text = "FormCinema";
            this.Load += new System.EventHandler(this.FormCinema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).EndInit();
            this.painelContentor.ResumeLayout(false);
            this.gbConfigCinema.ResumeLayout(false);
            this.gbConfigCinema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownQuantSalas)).EndInit();
            this.gbTamanhoSala.ResumeLayout(false);
            this.gbTamanhoSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGestao;
        private System.Windows.Forms.Label lblgestao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.PictureBox pbSessoes;
        private System.Windows.Forms.PictureBox pbFilmes;
        private System.Windows.Forms.PictureBox pbCinema;
        private System.Windows.Forms.PictureBox pbLogoMenu;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Panel painelContentor;
        private System.Windows.Forms.PictureBox pbAtendimento;
        private System.Windows.Forms.Label lblUpperMenu;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblSessoes;
        private System.Windows.Forms.Label lblFilmes;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lblAtendimento;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblMenuMenu;
        private System.Windows.Forms.ListBox lbSalasExistentes;
        private System.Windows.Forms.GroupBox gbConfigCinema;
        private System.Windows.Forms.NumericUpDown updownQuantSalas;
        private System.Windows.Forms.GroupBox gbTamanhoSala;
        private System.Windows.Forms.Button btnAdicionarSala;
        private System.Windows.Forms.NumericUpDown updownLinhas;
        private System.Windows.Forms.NumericUpDown updownColunas;
        private System.Windows.Forms.Label lblLinhas;
        private System.Windows.Forms.Label lblColunas;
        private System.Windows.Forms.Label lblQuantSalas;
    }
}