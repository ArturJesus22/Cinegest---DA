﻿using System;

namespace WindowsFormsApp1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.painelContentor = new System.Windows.Forms.Panel();
            this.lblSessoesHoje = new System.Windows.Forms.Label();
            this.lbSessoes = new System.Windows.Forms.ListBox();
            this.btnAdicionarBilhete = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtTipoUser = new System.Windows.Forms.Label();
            this.lblUpperMenu = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblSessoes = new System.Windows.Forms.Label();
            this.lblFilmes = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblAtendimento = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblMenuMenu = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.pbLogoMenu = new System.Windows.Forms.PictureBox();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.pbAtendimento = new System.Windows.Forms.PictureBox();
            this.pbSessoes = new System.Windows.Forms.PictureBox();
            this.pbFilmes = new System.Windows.Forms.PictureBox();
            this.pbCinema = new System.Windows.Forms.PictureBox();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGestao = new System.Windows.Forms.PictureBox();
            this.lblgestao = new System.Windows.Forms.Label();
            this.labelSessoes = new System.Windows.Forms.Label();
            this.painelContentor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).BeginInit();
            this.SuspendLayout();
            // 
            // painelContentor
            // 
            this.painelContentor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.painelContentor.Controls.Add(this.lblSessoesHoje);
            this.painelContentor.Controls.Add(this.lbSessoes);
            this.painelContentor.Controls.Add(this.btnAdicionarBilhete);
            this.painelContentor.Controls.Add(this.lblWelcome);
            this.painelContentor.Controls.Add(this.txtUsername);
            this.painelContentor.Controls.Add(this.txtTipoUser);
            this.painelContentor.Location = new System.Drawing.Point(246, 30);
            this.painelContentor.Name = "painelContentor";
            this.painelContentor.Size = new System.Drawing.Size(782, 537);
            this.painelContentor.TabIndex = 21;
            // 
            // lblSessoesHoje
            // 
            this.lblSessoesHoje.AutoSize = true;
            this.lblSessoesHoje.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblSessoesHoje.Location = new System.Drawing.Point(88, 138);
            this.lblSessoesHoje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSessoesHoje.Name = "lblSessoesHoje";
            this.lblSessoesHoje.Size = new System.Drawing.Size(195, 24);
            this.lblSessoesHoje.TabIndex = 39;
            this.lblSessoesHoje.Text = "Sessões para Hoje:";
            // 
            // lbSessoes
            // 
            this.lbSessoes.FormattingEnabled = true;
            this.lbSessoes.Location = new System.Drawing.Point(92, 164);
            this.lbSessoes.Margin = new System.Windows.Forms.Padding(2);
            this.lbSessoes.Name = "lbSessoes";
            this.lbSessoes.Size = new System.Drawing.Size(392, 303);
            this.lbSessoes.TabIndex = 37;
            // 
            // btnAdicionarBilhete
            // 
            this.btnAdicionarBilhete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarBilhete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarBilhete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarBilhete.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAdicionarBilhete.Location = new System.Drawing.Point(522, 264);
            this.btnAdicionarBilhete.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarBilhete.Name = "btnAdicionarBilhete";
            this.btnAdicionarBilhete.Size = new System.Drawing.Size(143, 76);
            this.btnAdicionarBilhete.TabIndex = 38;
            this.btnAdicionarBilhete.Text = "ADICIONAR BILHETE";
            this.btnAdicionarBilhete.UseVisualStyleBackColor = false;
            this.btnAdicionarBilhete.Click += new System.EventHandler(this.btnAdicionarBilhete_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 15.75F);
            this.lblWelcome.Location = new System.Drawing.Point(330, 30);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(114, 24);
            this.lblWelcome.TabIndex = 34;
            this.lblWelcome.Text = "Bem vindo,";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 15.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.txtUsername.Location = new System.Drawing.Point(347, 71);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(71, 24);
            this.txtUsername.TabIndex = 35;
            this.txtUsername.Text = "{user}!";
            // 
            // txtTipoUser
            // 
            this.txtTipoUser.AutoSize = true;
            this.txtTipoUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUser.Location = new System.Drawing.Point(328, 106);
            this.txtTipoUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTipoUser.Name = "txtTipoUser";
            this.txtTipoUser.Size = new System.Drawing.Size(74, 18);
            this.txtTipoUser.TabIndex = 36;
            this.txtTipoUser.Text = "{tipouser}";
            // 
            // lblUpperMenu
            // 
            this.lblUpperMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.lblUpperMenu.Location = new System.Drawing.Point(246, 0);
            this.lblUpperMenu.Name = "lblUpperMenu";
            this.lblUpperMenu.Size = new System.Drawing.Size(782, 31);
            this.lblUpperMenu.TabIndex = 20;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(87, 417);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(86, 24);
            this.lblClientes.TabIndex = 19;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // lblSessoes
            // 
            this.lblSessoes.Location = new System.Drawing.Point(0, 0);
            this.lblSessoes.Name = "lblSessoes";
            this.lblSessoes.Size = new System.Drawing.Size(100, 23);
            this.lblSessoes.TabIndex = 34;
            // 
            // lblFilmes
            // 
            this.lblFilmes.AutoSize = true;
            this.lblFilmes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmes.ForeColor = System.Drawing.Color.White;
            this.lblFilmes.Location = new System.Drawing.Point(86, 373);
            this.lblFilmes.Name = "lblFilmes";
            this.lblFilmes.Size = new System.Drawing.Size(71, 24);
            this.lblFilmes.TabIndex = 17;
            this.lblFilmes.Text = "Filmes";
            this.lblFilmes.Click += new System.EventHandler(this.lblFilmes_Click);
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.ForeColor = System.Drawing.Color.White;
            this.lblCinema.Location = new System.Drawing.Point(86, 325);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(81, 24);
            this.lblCinema.TabIndex = 16;
            this.lblCinema.Text = "Cinema";
            this.lblCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // lblAtendimento
            // 
            this.lblAtendimento.AutoSize = true;
            this.lblAtendimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimento.ForeColor = System.Drawing.Color.White;
            this.lblAtendimento.Location = new System.Drawing.Point(85, 280);
            this.lblAtendimento.Name = "lblAtendimento";
            this.lblAtendimento.Size = new System.Drawing.Size(125, 24);
            this.lblAtendimento.TabIndex = 15;
            this.lblAtendimento.Text = "Atendimento";
            this.lblAtendimento.Click += new System.EventHandler(this.lblAtendimento_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(87, 194);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(112, 24);
            this.lblDashboard.TabIndex = 14;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lblMenuMenu
            // 
            this.lblMenuMenu.AutoSize = true;
            this.lblMenuMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenuMenu.Location = new System.Drawing.Point(27, 150);
            this.lblMenuMenu.Name = "lblMenuMenu";
            this.lblMenuMenu.Size = new System.Drawing.Size(43, 17);
            this.lblMenuMenu.TabIndex = 13;
            this.lblMenuMenu.Text = "Menu";
            // 
            // lb_data
            // 
            this.lb_data.BackColor = System.Drawing.Color.Silver;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(245, 6);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(207, 20);
            this.lb_data.TabIndex = 22;
            // 
            // pbLogoMenu
            // 
            this.pbLogoMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoMenu.Image")));
            this.pbLogoMenu.Location = new System.Drawing.Point(23, 18);
            this.pbLogoMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoMenu.Name = "pbLogoMenu";
            this.pbLogoMenu.Size = new System.Drawing.Size(196, 86);
            this.pbLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoMenu.TabIndex = 23;
            this.pbLogoMenu.TabStop = false;
            // 
            // pbDashboard
            // 
            this.pbDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pbDashboard.Image")));
            this.pbDashboard.Location = new System.Drawing.Point(45, 181);
            this.pbDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(33, 38);
            this.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDashboard.TabIndex = 24;
            this.pbDashboard.TabStop = false;
            // 
            // pbAtendimento
            // 
            this.pbAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("pbAtendimento.Image")));
            this.pbAtendimento.Location = new System.Drawing.Point(40, 272);
            this.pbAtendimento.Margin = new System.Windows.Forms.Padding(2);
            this.pbAtendimento.Name = "pbAtendimento";
            this.pbAtendimento.Size = new System.Drawing.Size(40, 39);
            this.pbAtendimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtendimento.TabIndex = 25;
            this.pbAtendimento.TabStop = false;
            this.pbAtendimento.Click += new System.EventHandler(this.lblAtendimento_Click);
            // 
            // pbSessoes
            // 
            this.pbSessoes.Image = ((System.Drawing.Image)(resources.GetObject("pbSessoes.Image")));
            this.pbSessoes.Location = new System.Drawing.Point(46, 228);
            this.pbSessoes.Margin = new System.Windows.Forms.Padding(2);
            this.pbSessoes.Name = "pbSessoes";
            this.pbSessoes.Size = new System.Drawing.Size(33, 38);
            this.pbSessoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSessoes.TabIndex = 26;
            this.pbSessoes.TabStop = false;
            this.pbSessoes.Click += new System.EventHandler(this.labelSessoes_Click);
            // 
            // pbFilmes
            // 
            this.pbFilmes.Image = ((System.Drawing.Image)(resources.GetObject("pbFilmes.Image")));
            this.pbFilmes.Location = new System.Drawing.Point(46, 368);
            this.pbFilmes.Margin = new System.Windows.Forms.Padding(2);
            this.pbFilmes.Name = "pbFilmes";
            this.pbFilmes.Size = new System.Drawing.Size(33, 38);
            this.pbFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilmes.TabIndex = 27;
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
            this.pbCinema.TabIndex = 28;
            this.pbCinema.TabStop = false;
            this.pbCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // pbClientes
            // 
            this.pbClientes.Image = ((System.Drawing.Image)(resources.GetObject("pbClientes.Image")));
            this.pbClientes.Location = new System.Drawing.Point(47, 413);
            this.pbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(33, 38);
            this.pbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClientes.TabIndex = 29;
            this.pbClientes.TabStop = false;
            this.pbClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(11, 525);
            this.pbSair.Margin = new System.Windows.Forms.Padding(2);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(36, 28);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 30;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.pbSair_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 567);
            this.label1.TabIndex = 31;
            // 
            // pbGestao
            // 
            this.pbGestao.Image = ((System.Drawing.Image)(resources.GetObject("pbGestao.Image")));
            this.pbGestao.Location = new System.Drawing.Point(47, 459);
            this.pbGestao.Margin = new System.Windows.Forms.Padding(2);
            this.pbGestao.Name = "pbGestao";
            this.pbGestao.Size = new System.Drawing.Size(33, 38);
            this.pbGestao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGestao.TabIndex = 33;
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
            this.lblgestao.TabIndex = 32;
            this.lblgestao.Text = "Gestão";
            this.lblgestao.Visible = false;
            this.lblgestao.Click += new System.EventHandler(this.lblgestao_Click);
            // 
            // labelSessoes
            // 
            this.labelSessoes.AutoSize = true;
            this.labelSessoes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessoes.ForeColor = System.Drawing.Color.White;
            this.labelSessoes.Location = new System.Drawing.Point(87, 234);
            this.labelSessoes.Name = "labelSessoes";
            this.labelSessoes.Size = new System.Drawing.Size(93, 24);
            this.labelSessoes.TabIndex = 60;
            this.labelSessoes.Text = "Sessões";
            this.labelSessoes.Click += new System.EventHandler(this.labelSessoes_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1027, 564);
            this.Controls.Add(this.labelSessoes);
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
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painelContentor.ResumeLayout(false);
            this.painelContentor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelContentor;
        private System.Windows.Forms.Label lblUpperMenu;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblSessoes;
        private System.Windows.Forms.Label lblFilmes;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lblAtendimento;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblMenuMenu;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.PictureBox pbLogoMenu;
        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.PictureBox pbCinema;
        private System.Windows.Forms.PictureBox pbFilmes;
        private System.Windows.Forms.PictureBox pbSessoes;
        private System.Windows.Forms.PictureBox pbAtendimento;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGestao;
        private System.Windows.Forms.Label lblgestao;
        private System.Windows.Forms.Label lblSessoesHoje;
        private System.Windows.Forms.ListBox lbSessoes;
        private System.Windows.Forms.Button btnAdicionarBilhete;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtTipoUser;
        private System.Windows.Forms.Label labelSessoes;
    }
}

