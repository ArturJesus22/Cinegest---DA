namespace WindowsFormsApp1.View
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.pbSessoes = new System.Windows.Forms.PictureBox();
            this.pbFilmes = new System.Windows.Forms.PictureBox();
            this.pbCinema = new System.Windows.Forms.PictureBox();
            this.pbLogoMenu = new System.Windows.Forms.PictureBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.pbAtendimento = new System.Windows.Forms.PictureBox();
            this.lblUpperMenu = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblSessoes = new System.Windows.Forms.Label();
            this.lblFilmes = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblAtendimento = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblMenuMenu = new System.Windows.Forms.Label();
            this.gbRegUsers = new System.Windows.Forms.GroupBox();
            this.cbPerms = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblAdicionarPermissoes = new System.Windows.Forms.Label();
            this.bt_registaruser = new System.Windows.Forms.Button();
            this.lblAdicionarPassword = new System.Windows.Forms.Label();
            this.lblAdicionarUsername = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lblUtilizadoresRegistados = new System.Windows.Forms.Label();
            this.painelContentor = new System.Windows.Forms.Panel();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet = new WindowsFormsApp1.CineGestDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet_Cinema = new WindowsFormsApp1.CineGestDataSet_Cinema();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCriarCinema = new System.Windows.Forms.Button();
            this.txtEmailCinema = new System.Windows.Forms.TextBox();
            this.lblCinemaEmail = new System.Windows.Forms.Label();
            this.lblMoradaCinema = new System.Windows.Forms.Label();
            this.lblNomeCinema = new System.Windows.Forms.Label();
            this.txtNomeCinema = new System.Windows.Forms.TextBox();
            this.txtMoradaCinema = new System.Windows.Forms.TextBox();
            this.pbGestao = new System.Windows.Forms.PictureBox();
            this.lblgestao = new System.Windows.Forms.Label();
            this.loginTableAdapter = new WindowsFormsApp1.CineGestDataSetTableAdapters.LoginTableAdapter();
            this.cinemaTableAdapter = new WindowsFormsApp1.CineGestDataSet_CinemaTableAdapters.CinemaTableAdapter();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).BeginInit();
            this.gbRegUsers.SuspendLayout();
            this.painelContentor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet_Cinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 567);
            this.label1.TabIndex = 52;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(12, 525);
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
            this.pbClientes.Location = new System.Drawing.Point(48, 413);
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
            this.pbDashboard.Location = new System.Drawing.Point(46, 181);
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
            this.pbSessoes.Location = new System.Drawing.Point(47, 228);
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
            this.pbFilmes.Location = new System.Drawing.Point(47, 368);
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
            this.pbCinema.Location = new System.Drawing.Point(47, 320);
            this.pbCinema.Margin = new System.Windows.Forms.Padding(2);
            this.pbCinema.Name = "pbCinema";
            this.pbCinema.Size = new System.Drawing.Size(33, 38);
            this.pbCinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCinema.TabIndex = 49;
            this.pbCinema.TabStop = false;
            this.pbCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // pbLogoMenu
            // 
            this.pbLogoMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoMenu.Image")));
            this.pbLogoMenu.Location = new System.Drawing.Point(24, 18);
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
            this.lb_data.Location = new System.Drawing.Point(250, 7);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(207, 20);
            this.lb_data.TabIndex = 43;
            // 
            // pbAtendimento
            // 
            this.pbAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("pbAtendimento.Image")));
            this.pbAtendimento.Location = new System.Drawing.Point(41, 272);
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
            this.lblUpperMenu.Location = new System.Drawing.Point(247, 0);
            this.lblUpperMenu.Name = "lblUpperMenu";
            this.lblUpperMenu.Size = new System.Drawing.Size(789, 31);
            this.lblUpperMenu.TabIndex = 41;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(88, 417);
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
            this.lblSessoes.Location = new System.Drawing.Point(87, 232);
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
            this.lblFilmes.Location = new System.Drawing.Point(87, 373);
            this.lblFilmes.Name = "lblFilmes";
            this.lblFilmes.Size = new System.Drawing.Size(71, 24);
            this.lblFilmes.TabIndex = 38;
            this.lblFilmes.Text = "Filmes";
            this.lblFilmes.Click += new System.EventHandler(this.lblFilmes_Click);
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.ForeColor = System.Drawing.Color.White;
            this.lblCinema.Location = new System.Drawing.Point(87, 325);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(81, 24);
            this.lblCinema.TabIndex = 37;
            this.lblCinema.Text = "Cinema";
            this.lblCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // lblAtendimento
            // 
            this.lblAtendimento.AutoSize = true;
            this.lblAtendimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimento.ForeColor = System.Drawing.Color.White;
            this.lblAtendimento.Location = new System.Drawing.Point(86, 280);
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
            this.lblDashboard.Location = new System.Drawing.Point(86, 190);
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
            this.lblMenuMenu.Location = new System.Drawing.Point(28, 150);
            this.lblMenuMenu.Name = "lblMenuMenu";
            this.lblMenuMenu.Size = new System.Drawing.Size(43, 17);
            this.lblMenuMenu.TabIndex = 34;
            this.lblMenuMenu.Text = "Menu";
            // 
            // gbRegUsers
            // 
            this.gbRegUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbRegUsers.Controls.Add(this.cbPerms);
            this.gbRegUsers.Controls.Add(this.btnModificar);
            this.gbRegUsers.Controls.Add(this.lblAdicionarPermissoes);
            this.gbRegUsers.Controls.Add(this.bt_registaruser);
            this.gbRegUsers.Controls.Add(this.lblAdicionarPassword);
            this.gbRegUsers.Controls.Add(this.lblAdicionarUsername);
            this.gbRegUsers.Controls.Add(this.txt_usuario);
            this.gbRegUsers.Controls.Add(this.txt_password);
            this.gbRegUsers.ForeColor = System.Drawing.Color.Black;
            this.gbRegUsers.Location = new System.Drawing.Point(25, 35);
            this.gbRegUsers.Margin = new System.Windows.Forms.Padding(2);
            this.gbRegUsers.Name = "gbRegUsers";
            this.gbRegUsers.Padding = new System.Windows.Forms.Padding(2);
            this.gbRegUsers.Size = new System.Drawing.Size(429, 176);
            this.gbRegUsers.TabIndex = 55;
            this.gbRegUsers.TabStop = false;
            this.gbRegUsers.Text = "Registar Utilizadores";
            // 
            // cbPerms
            // 
            this.cbPerms.FormattingEnabled = true;
            this.cbPerms.Location = new System.Drawing.Point(130, 114);
            this.cbPerms.Name = "cbPerms";
            this.cbPerms.Size = new System.Drawing.Size(121, 21);
            this.cbPerms.TabIndex = 12;
            this.cbPerms.SelectedIndexChanged += new System.EventHandler(this.cbPerms_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(280, 98);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 54);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar Utilizador";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblAdicionarPermissoes
            // 
            this.lblAdicionarPermissoes.AutoSize = true;
            this.lblAdicionarPermissoes.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblAdicionarPermissoes.ForeColor = System.Drawing.Color.Black;
            this.lblAdicionarPermissoes.Location = new System.Drawing.Point(33, 116);
            this.lblAdicionarPermissoes.Name = "lblAdicionarPermissoes";
            this.lblAdicionarPermissoes.Size = new System.Drawing.Size(91, 17);
            this.lblAdicionarPermissoes.TabIndex = 10;
            this.lblAdicionarPermissoes.Text = "Permissões:";
            // 
            // bt_registaruser
            // 
            this.bt_registaruser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.bt_registaruser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.bt_registaruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_registaruser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registaruser.Location = new System.Drawing.Point(280, 20);
            this.bt_registaruser.Name = "bt_registaruser";
            this.bt_registaruser.Size = new System.Drawing.Size(114, 54);
            this.bt_registaruser.TabIndex = 3;
            this.bt_registaruser.Text = "Registar Utilizador";
            this.bt_registaruser.UseVisualStyleBackColor = false;
            this.bt_registaruser.Click += new System.EventHandler(this.bt_registaruser_Click);
            // 
            // lblAdicionarPassword
            // 
            this.lblAdicionarPassword.AutoSize = true;
            this.lblAdicionarPassword.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblAdicionarPassword.ForeColor = System.Drawing.Color.Black;
            this.lblAdicionarPassword.Location = new System.Drawing.Point(33, 76);
            this.lblAdicionarPassword.Name = "lblAdicionarPassword";
            this.lblAdicionarPassword.Size = new System.Drawing.Size(78, 17);
            this.lblAdicionarPassword.TabIndex = 9;
            this.lblAdicionarPassword.Text = "Password:";
            // 
            // lblAdicionarUsername
            // 
            this.lblAdicionarUsername.AutoSize = true;
            this.lblAdicionarUsername.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblAdicionarUsername.ForeColor = System.Drawing.Color.Black;
            this.lblAdicionarUsername.Location = new System.Drawing.Point(33, 37);
            this.lblAdicionarUsername.Name = "lblAdicionarUsername";
            this.lblAdicionarUsername.Size = new System.Drawing.Size(51, 17);
            this.lblAdicionarUsername.TabIndex = 8;
            this.lblAdicionarUsername.Text = "Nome:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(130, 37);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(121, 20);
            this.txt_usuario.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(130, 75);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(121, 20);
            this.txt_password.TabIndex = 5;
            // 
            // lblUtilizadoresRegistados
            // 
            this.lblUtilizadoresRegistados.AutoSize = true;
            this.lblUtilizadoresRegistados.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblUtilizadoresRegistados.ForeColor = System.Drawing.Color.Black;
            this.lblUtilizadoresRegistados.Location = new System.Drawing.Point(21, 224);
            this.lblUtilizadoresRegistados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUtilizadoresRegistados.Name = "lblUtilizadoresRegistados";
            this.lblUtilizadoresRegistados.Size = new System.Drawing.Size(236, 24);
            this.lblUtilizadoresRegistados.TabIndex = 57;
            this.lblUtilizadoresRegistados.Text = "Utilizadores Registados:";
            // 
            // painelContentor
            // 
            this.painelContentor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.painelContentor.Controls.Add(this.dataGridView_Users);
            this.painelContentor.Controls.Add(this.groupBox1);
            this.painelContentor.Controls.Add(this.lblUtilizadoresRegistados);
            this.painelContentor.Controls.Add(this.gbRegUsers);
            this.painelContentor.Location = new System.Drawing.Point(247, 30);
            this.painelContentor.Name = "painelContentor";
            this.painelContentor.Size = new System.Drawing.Size(782, 537);
            this.painelContentor.TabIndex = 42;
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AutoGenerateColumns = false;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.utilizadorDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.permissoesDataGridViewTextBoxColumn});
            this.dataGridView_Users.DataSource = this.loginBindingSource;
            this.dataGridView_Users.Location = new System.Drawing.Point(25, 251);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.Size = new System.Drawing.Size(429, 259);
            this.dataGridView_Users.TabIndex = 58;
            this.dataGridView_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Users_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilizadorDataGridViewTextBoxColumn
            // 
            this.utilizadorDataGridViewTextBoxColumn.DataPropertyName = "Utilizador";
            this.utilizadorDataGridViewTextBoxColumn.HeaderText = "Utilizador";
            this.utilizadorDataGridViewTextBoxColumn.Name = "utilizadorDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // permissoesDataGridViewTextBoxColumn
            // 
            this.permissoesDataGridViewTextBoxColumn.DataPropertyName = "Permissoes";
            this.permissoesDataGridViewTextBoxColumn.HeaderText = "Permissoes";
            this.permissoesDataGridViewTextBoxColumn.Name = "permissoesDataGridViewTextBoxColumn";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.cineGestDataSet;
            // 
            // cineGestDataSet
            // 
            this.cineGestDataSet.DataSetName = "CineGestDataSet";
            this.cineGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCriarCinema);
            this.groupBox1.Controls.Add(this.txtEmailCinema);
            this.groupBox1.Controls.Add(this.lblCinemaEmail);
            this.groupBox1.Controls.Add(this.lblMoradaCinema);
            this.groupBox1.Controls.Add(this.lblNomeCinema);
            this.groupBox1.Controls.Add(this.txtNomeCinema);
            this.groupBox1.Controls.Add(this.txtMoradaCinema);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(472, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(291, 475);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinema";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cinemaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(281, 187);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            // 
            // cinemaBindingSource
            // 
            this.cinemaBindingSource.DataMember = "Cinema";
            this.cinemaBindingSource.DataSource = this.cineGestDataSet_Cinema;
            // 
            // cineGestDataSet_Cinema
            // 
            this.cineGestDataSet_Cinema.DataSetName = "CineGestDataSet_Cinema";
            this.cineGestDataSet_Cinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Alterar Cinema";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCriarCinema
            // 
            this.btnCriarCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnCriarCinema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnCriarCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarCinema.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarCinema.Location = new System.Drawing.Point(21, 395);
            this.btnCriarCinema.Name = "btnCriarCinema";
            this.btnCriarCinema.Size = new System.Drawing.Size(114, 54);
            this.btnCriarCinema.TabIndex = 12;
            this.btnCriarCinema.Text = "Criar Cinema";
            this.btnCriarCinema.UseVisualStyleBackColor = false;
            this.btnCriarCinema.Click += new System.EventHandler(this.btnCriarCinema_Click);
            // 
            // txtEmailCinema
            // 
            this.txtEmailCinema.Location = new System.Drawing.Point(104, 106);
            this.txtEmailCinema.Name = "txtEmailCinema";
            this.txtEmailCinema.Size = new System.Drawing.Size(149, 20);
            this.txtEmailCinema.TabIndex = 11;
            // 
            // lblCinemaEmail
            // 
            this.lblCinemaEmail.AutoSize = true;
            this.lblCinemaEmail.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblCinemaEmail.ForeColor = System.Drawing.Color.Black;
            this.lblCinemaEmail.Location = new System.Drawing.Point(33, 107);
            this.lblCinemaEmail.Name = "lblCinemaEmail";
            this.lblCinemaEmail.Size = new System.Drawing.Size(49, 17);
            this.lblCinemaEmail.TabIndex = 10;
            this.lblCinemaEmail.Text = "Email:";
            // 
            // lblMoradaCinema
            // 
            this.lblMoradaCinema.AutoSize = true;
            this.lblMoradaCinema.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblMoradaCinema.ForeColor = System.Drawing.Color.Black;
            this.lblMoradaCinema.Location = new System.Drawing.Point(33, 73);
            this.lblMoradaCinema.Name = "lblMoradaCinema";
            this.lblMoradaCinema.Size = new System.Drawing.Size(60, 17);
            this.lblMoradaCinema.TabIndex = 9;
            this.lblMoradaCinema.Text = "Morada:";
            // 
            // lblNomeCinema
            // 
            this.lblNomeCinema.AutoSize = true;
            this.lblNomeCinema.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblNomeCinema.ForeColor = System.Drawing.Color.Black;
            this.lblNomeCinema.Location = new System.Drawing.Point(33, 37);
            this.lblNomeCinema.Name = "lblNomeCinema";
            this.lblNomeCinema.Size = new System.Drawing.Size(51, 17);
            this.lblNomeCinema.TabIndex = 8;
            this.lblNomeCinema.Text = "Nome:";
            // 
            // txtNomeCinema
            // 
            this.txtNomeCinema.Location = new System.Drawing.Point(104, 37);
            this.txtNomeCinema.Name = "txtNomeCinema";
            this.txtNomeCinema.Size = new System.Drawing.Size(149, 20);
            this.txtNomeCinema.TabIndex = 4;
            // 
            // txtMoradaCinema
            // 
            this.txtMoradaCinema.Location = new System.Drawing.Point(104, 72);
            this.txtMoradaCinema.Name = "txtMoradaCinema";
            this.txtMoradaCinema.Size = new System.Drawing.Size(149, 20);
            this.txtMoradaCinema.TabIndex = 5;
            // 
            // pbGestao
            // 
            this.pbGestao.Image = ((System.Drawing.Image)(resources.GetObject("pbGestao.Image")));
            this.pbGestao.Location = new System.Drawing.Point(48, 456);
            this.pbGestao.Margin = new System.Windows.Forms.Padding(2);
            this.pbGestao.Name = "pbGestao";
            this.pbGestao.Size = new System.Drawing.Size(33, 38);
            this.pbGestao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGestao.TabIndex = 54;
            this.pbGestao.TabStop = false;
            this.pbGestao.Visible = false;
            // 
            // lblgestao
            // 
            this.lblgestao.AutoSize = true;
            this.lblgestao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestao.ForeColor = System.Drawing.Color.White;
            this.lblgestao.Location = new System.Drawing.Point(88, 460);
            this.lblgestao.Name = "lblgestao";
            this.lblgestao.Size = new System.Drawing.Size(79, 24);
            this.lblgestao.TabIndex = 53;
            this.lblgestao.Text = "Gestão";
            this.lblgestao.Visible = false;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // cinemaTableAdapter
            // 
            this.cinemaTableAdapter.ClearBeforeFill = true;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Silver;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(746, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(271, 20);
            this.lblInfo.TabIndex = 62;
            // 
            // FormAdmin
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
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblSessoes);
            this.Controls.Add(this.lblFilmes);
            this.Controls.Add(this.lblCinema);
            this.Controls.Add(this.lblAtendimento);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.lblMenuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinegest - AdminPanel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).EndInit();
            this.gbRegUsers.ResumeLayout(false);
            this.gbRegUsers.PerformLayout();
            this.painelContentor.ResumeLayout(false);
            this.painelContentor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet_Cinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.PictureBox pbSessoes;
        private System.Windows.Forms.PictureBox pbFilmes;
        private System.Windows.Forms.PictureBox pbCinema;
        private System.Windows.Forms.PictureBox pbLogoMenu;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.PictureBox pbAtendimento;
        private System.Windows.Forms.Label lblUpperMenu;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblSessoes;
        private System.Windows.Forms.Label lblFilmes;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lblAtendimento;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblMenuMenu;
        private System.Windows.Forms.GroupBox gbRegUsers;
        private System.Windows.Forms.Label lblAdicionarPermissoes;
        private System.Windows.Forms.Button bt_registaruser;
        private System.Windows.Forms.Label lblAdicionarPassword;
        private System.Windows.Forms.Label lblAdicionarUsername;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lblUtilizadoresRegistados;
        private System.Windows.Forms.Panel painelContentor;
        private System.Windows.Forms.PictureBox pbGestao;
        private System.Windows.Forms.Label lblgestao;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCinemaEmail;
        private System.Windows.Forms.Label lblMoradaCinema;
        private System.Windows.Forms.Label lblNomeCinema;
        private System.Windows.Forms.TextBox txtNomeCinema;
        private System.Windows.Forms.TextBox txtMoradaCinema;
        private System.Windows.Forms.TextBox txtEmailCinema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCriarCinema;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private CineGestDataSet cineGestDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private CineGestDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CineGestDataSet_Cinema cineGestDataSet_Cinema;
        private System.Windows.Forms.BindingSource cinemaBindingSource;
        private CineGestDataSet_CinemaTableAdapters.CinemaTableAdapter cinemaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbPerms;
        private System.Windows.Forms.Label lblInfo;
    }
}