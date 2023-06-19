﻿namespace WindowsFormsApp1.View
{
    partial class FormFilmes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmes));
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblCriarNomeFilme = new System.Windows.Forms.Label();
            this.gbCriarFilmes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updownDuracao = new System.Windows.Forms.NumericUpDown();
            this.lblCriarEstadoFilme = new System.Windows.Forms.Label();
            this.txtAdicionarNomeFilme = new System.Windows.Forms.TextBox();
            this.cbCriarFilmeAtivo = new System.Windows.Forms.CheckBox();
            this.comboBoxFilmes = new System.Windows.Forms.ComboBox();
            this.btnAdicionarFilme = new System.Windows.Forms.Button();
            this.btnModificarFilme = new System.Windows.Forms.Button();
            this.lblCriarCategoriaFilme = new System.Windows.Forms.Label();
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
            this.dataGridView_Filmes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet_Filmes = new WindowsFormsApp1.CineGestDataSet_Filmes();
            this.pbAtendimento = new System.Windows.Forms.PictureBox();
            this.lblUpperMenu = new System.Windows.Forms.Label();
            this.lblAtendimento = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblMenuMenu = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblSessoes = new System.Windows.Forms.Label();
            this.lblFilmes = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.filmeTableAdapter = new WindowsFormsApp1.CineGestDataSet_FilmesTableAdapters.FilmeTableAdapter();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbCriarFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownDuracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).BeginInit();
            this.painelContentor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Filmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet_Filmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblDuracao.Location = new System.Drawing.Point(23, 127);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(68, 17);
            this.lblDuracao.TabIndex = 56;
            this.lblDuracao.Text = "Duração:";
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
            // gbCriarFilmes
            // 
            this.gbCriarFilmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbCriarFilmes.Controls.Add(this.label3);
            this.gbCriarFilmes.Controls.Add(this.lblDuracao);
            this.gbCriarFilmes.Controls.Add(this.updownDuracao);
            this.gbCriarFilmes.Controls.Add(this.lblCriarEstadoFilme);
            this.gbCriarFilmes.Controls.Add(this.txtAdicionarNomeFilme);
            this.gbCriarFilmes.Controls.Add(this.cbCriarFilmeAtivo);
            this.gbCriarFilmes.Controls.Add(this.comboBoxFilmes);
            this.gbCriarFilmes.Controls.Add(this.btnAdicionarFilme);
            this.gbCriarFilmes.Controls.Add(this.btnModificarFilme);
            this.gbCriarFilmes.Controls.Add(this.lblCriarCategoriaFilme);
            this.gbCriarFilmes.Controls.Add(this.lblCriarNomeFilme);
            this.gbCriarFilmes.Location = new System.Drawing.Point(103, 65);
            this.gbCriarFilmes.Name = "gbCriarFilmes";
            this.gbCriarFilmes.Size = new System.Drawing.Size(576, 209);
            this.gbCriarFilmes.TabIndex = 9;
            this.gbCriarFilmes.TabStop = false;
            this.gbCriarFilmes.Text = "Criar Filmes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "minutos";
            // 
            // updownDuracao
            // 
            this.updownDuracao.Location = new System.Drawing.Point(105, 124);
            this.updownDuracao.Name = "updownDuracao";
            this.updownDuracao.Size = new System.Drawing.Size(57, 20);
            this.updownDuracao.TabIndex = 55;
            // 
            // lblCriarEstadoFilme
            // 
            this.lblCriarEstadoFilme.AutoSize = true;
            this.lblCriarEstadoFilme.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblCriarEstadoFilme.Location = new System.Drawing.Point(23, 166);
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
            this.cbCriarFilmeAtivo.Location = new System.Drawing.Point(104, 165);
            this.cbCriarFilmeAtivo.Name = "cbCriarFilmeAtivo";
            this.cbCriarFilmeAtivo.Size = new System.Drawing.Size(58, 21);
            this.cbCriarFilmeAtivo.TabIndex = 8;
            this.cbCriarFilmeAtivo.Text = "Ativo";
            this.cbCriarFilmeAtivo.UseVisualStyleBackColor = true;
            // 
            // comboBoxFilmes
            // 
            this.comboBoxFilmes.FormattingEnabled = true;
            this.comboBoxFilmes.Location = new System.Drawing.Point(104, 90);
            this.comboBoxFilmes.Name = "comboBoxFilmes";
            this.comboBoxFilmes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmes.TabIndex = 7;
            // 
            // btnAdicionarFilme
            // 
            this.btnAdicionarFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarFilme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFilme.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAdicionarFilme.Location = new System.Drawing.Point(409, 18);
            this.btnAdicionarFilme.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarFilme.Name = "btnAdicionarFilme";
            this.btnAdicionarFilme.Size = new System.Drawing.Size(143, 76);
            this.btnAdicionarFilme.TabIndex = 5;
            this.btnAdicionarFilme.Text = "ADICIONAR FILME";
            this.btnAdicionarFilme.UseVisualStyleBackColor = false;
            this.btnAdicionarFilme.Click += new System.EventHandler(this.btnAdicionarFilme_Click);
            // 
            // btnModificarFilme
            // 
            this.btnModificarFilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificarFilme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificarFilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFilme.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnModificarFilme.Location = new System.Drawing.Point(409, 111);
            this.btnModificarFilme.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarFilme.Name = "btnModificarFilme";
            this.btnModificarFilme.Size = new System.Drawing.Size(143, 72);
            this.btnModificarFilme.TabIndex = 5;
            this.btnModificarFilme.Text = "MODIFICAR FILME";
            this.btnModificarFilme.UseVisualStyleBackColor = false;
            this.btnModificarFilme.Click += new System.EventHandler(this.btnModificarFilme_Click);
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
            // pbGestao
            // 
            this.pbGestao.Image = ((System.Drawing.Image)(resources.GetObject("pbGestao.Image")));
            this.pbGestao.Location = new System.Drawing.Point(47, 459);
            this.pbGestao.Margin = new System.Windows.Forms.Padding(2);
            this.pbGestao.Name = "pbGestao";
            this.pbGestao.Size = new System.Drawing.Size(33, 38);
            this.pbGestao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGestao.TabIndex = 75;
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
            this.lblgestao.TabIndex = 74;
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
            this.label1.TabIndex = 73;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(11, 525);
            this.pbSair.Margin = new System.Windows.Forms.Padding(2);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(36, 28);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 72;
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
            this.pbClientes.TabIndex = 71;
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
            this.pbDashboard.TabIndex = 66;
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
            this.pbSessoes.TabIndex = 68;
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
            this.pbFilmes.TabIndex = 69;
            this.pbFilmes.TabStop = false;
            // 
            // pbCinema
            // 
            this.pbCinema.Image = ((System.Drawing.Image)(resources.GetObject("pbCinema.Image")));
            this.pbCinema.Location = new System.Drawing.Point(46, 320);
            this.pbCinema.Margin = new System.Windows.Forms.Padding(2);
            this.pbCinema.Name = "pbCinema";
            this.pbCinema.Size = new System.Drawing.Size(33, 38);
            this.pbCinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCinema.TabIndex = 70;
            this.pbCinema.TabStop = false;
            this.pbCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // pbLogoMenu
            // 
            this.pbLogoMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoMenu.Image")));
            this.pbLogoMenu.Location = new System.Drawing.Point(23, 18);
            this.pbLogoMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoMenu.Name = "pbLogoMenu";
            this.pbLogoMenu.Size = new System.Drawing.Size(196, 86);
            this.pbLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoMenu.TabIndex = 65;
            this.pbLogoMenu.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.BackColor = System.Drawing.Color.Silver;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(245, 6);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(207, 20);
            this.lb_data.TabIndex = 64;
            // 
            // painelContentor
            // 
            this.painelContentor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.painelContentor.Controls.Add(this.dataGridView_Filmes);
            this.painelContentor.Controls.Add(this.gbCriarFilmes);
            this.painelContentor.Location = new System.Drawing.Point(246, 30);
            this.painelContentor.Name = "painelContentor";
            this.painelContentor.Size = new System.Drawing.Size(782, 537);
            this.painelContentor.TabIndex = 63;
            // 
            // dataGridView_Filmes
            // 
            this.dataGridView_Filmes.AutoGenerateColumns = false;
            this.dataGridView_Filmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Filmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.duracaoDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn});
            this.dataGridView_Filmes.DataSource = this.filmeBindingSource;
            this.dataGridView_Filmes.Location = new System.Drawing.Point(129, 290);
            this.dataGridView_Filmes.Name = "dataGridView_Filmes";
            this.dataGridView_Filmes.Size = new System.Drawing.Size(540, 232);
            this.dataGridView_Filmes.TabIndex = 10;
            this.dataGridView_Filmes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Filmes_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // duracaoDataGridViewTextBoxColumn
            // 
            this.duracaoDataGridViewTextBoxColumn.DataPropertyName = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.HeaderText = "Duracao";
            this.duracaoDataGridViewTextBoxColumn.Name = "duracaoDataGridViewTextBoxColumn";
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // filmeBindingSource
            // 
            this.filmeBindingSource.DataMember = "Filme";
            this.filmeBindingSource.DataSource = this.cineGestDataSet_Filmes;
            // 
            // cineGestDataSet_Filmes
            // 
            this.cineGestDataSet_Filmes.DataSetName = "CineGestDataSet_Filmes";
            this.cineGestDataSet_Filmes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbAtendimento
            // 
            this.pbAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("pbAtendimento.Image")));
            this.pbAtendimento.Location = new System.Drawing.Point(40, 272);
            this.pbAtendimento.Margin = new System.Windows.Forms.Padding(2);
            this.pbAtendimento.Name = "pbAtendimento";
            this.pbAtendimento.Size = new System.Drawing.Size(40, 39);
            this.pbAtendimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtendimento.TabIndex = 67;
            this.pbAtendimento.TabStop = false;
            this.pbAtendimento.Click += new System.EventHandler(this.lblAtendimento_Click);
            // 
            // lblUpperMenu
            // 
            this.lblUpperMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.lblUpperMenu.Location = new System.Drawing.Point(246, 0);
            this.lblUpperMenu.Name = "lblUpperMenu";
            this.lblUpperMenu.Size = new System.Drawing.Size(782, 31);
            this.lblUpperMenu.TabIndex = 62;
            // 
            // lblAtendimento
            // 
            this.lblAtendimento.AutoSize = true;
            this.lblAtendimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimento.ForeColor = System.Drawing.Color.White;
            this.lblAtendimento.Location = new System.Drawing.Point(85, 280);
            this.lblAtendimento.Name = "lblAtendimento";
            this.lblAtendimento.Size = new System.Drawing.Size(125, 24);
            this.lblAtendimento.TabIndex = 57;
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
            this.lblDashboard.TabIndex = 56;
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
            this.lblMenuMenu.TabIndex = 55;
            this.lblMenuMenu.Text = "Menu";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(87, 417);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(86, 24);
            this.lblClientes.TabIndex = 61;
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
            this.lblSessoes.TabIndex = 60;
            this.lblSessoes.Text = "Sessões";
            this.lblSessoes.Click += new System.EventHandler(this.lblSessoes_Click);
            // 
            // lblFilmes
            // 
            this.lblFilmes.AutoSize = true;
            this.lblFilmes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmes.ForeColor = System.Drawing.Color.White;
            this.lblFilmes.Location = new System.Drawing.Point(86, 373);
            this.lblFilmes.Name = "lblFilmes";
            this.lblFilmes.Size = new System.Drawing.Size(71, 24);
            this.lblFilmes.TabIndex = 59;
            this.lblFilmes.Text = "Filmes";
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.ForeColor = System.Drawing.Color.White;
            this.lblCinema.Location = new System.Drawing.Point(86, 325);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(81, 24);
            this.lblCinema.TabIndex = 58;
            this.lblCinema.Text = "Cinema";
            this.lblCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // filmeTableAdapter
            // 
            this.filmeTableAdapter.ClearBeforeFill = true;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Silver;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(741, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(271, 20);
            this.lblInfo.TabIndex = 76;
            // 
            // FormFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1027, 564);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
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
            this.Controls.Add(this.lblAtendimento);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.lblMenuMenu);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblSessoes);
            this.Controls.Add(this.lblFilmes);
            this.Controls.Add(this.lblCinema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFilmes";
            this.Load += new System.EventHandler(this.FormFilmes_Load);
            this.gbCriarFilmes.ResumeLayout(false);
            this.gbCriarFilmes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownDuracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).EndInit();
            this.painelContentor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Filmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet_Filmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblCriarNomeFilme;
        private System.Windows.Forms.GroupBox gbCriarFilmes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updownDuracao;
        private System.Windows.Forms.Label lblCriarEstadoFilme;
        private System.Windows.Forms.TextBox txtAdicionarNomeFilme;
        private System.Windows.Forms.CheckBox cbCriarFilmeAtivo;
        private System.Windows.Forms.ComboBox comboBoxFilmes;
        private System.Windows.Forms.Button btnAdicionarFilme;
        private System.Windows.Forms.Button btnModificarFilme;
        private System.Windows.Forms.Label lblCriarCategoriaFilme;
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
        private System.Windows.Forms.DataGridView dataGridView_Filmes;
        private System.Windows.Forms.PictureBox pbAtendimento;
        private System.Windows.Forms.Label lblUpperMenu;
        private System.Windows.Forms.Label lblAtendimento;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblMenuMenu;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblSessoes;
        private System.Windows.Forms.Label lblFilmes;
        private System.Windows.Forms.Label lblCinema;
        private CineGestDataSet_Filmes cineGestDataSet_Filmes;
        private System.Windows.Forms.BindingSource filmeBindingSource;
        private CineGestDataSet_FilmesTableAdapters.FilmeTableAdapter filmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblInfo;
    }
}