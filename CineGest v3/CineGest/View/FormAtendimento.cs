﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class FormAtendimento : Form
    {
        private MainController mainController;
        public FormAtendimento()
        {
            InitializeComponent();
            mainController = new MainController();
        }

        private void FormAtendimento_Load(object sender, EventArgs e)
        {
            string diaDaSemana = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            string data = diaDaSemana;
            lb_data.Text = data;
        }

        private void btnModificarSala_Click(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormPrincipal();
        }

        private void lblCinema_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormCinema();
        }

        private void lblFilmes_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormFilmes();
        }
        private void lblSessoes_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormSessoes();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormCliente();

        }

        public void lblgestao_Click(object sender, EventArgs e)
        {
            this.Close();
            mainController.initFormAdmin();
        }

        //Botão de Exit
        private void pbSair_Click(object sender, EventArgs e)
        {
            mainController.mostrarOpcoesSaida(pbSair);
        }

        private void FormAtendimento_Load_1(object sender, EventArgs e)
        {
            string dia = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            lb_data.Text = dia;
            string permissao = DBConnection.permissaoUsuario;


            if (permissao == "1")
            {
                lblgestao.Visible = false;
                pbGestao.Visible = false;
            }
            else if (permissao == "2")
            {
                lblgestao.Visible = true;
                pbGestao.Visible = true;
            }
        }
    }
}
