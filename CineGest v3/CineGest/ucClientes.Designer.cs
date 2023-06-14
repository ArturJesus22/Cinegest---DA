namespace WindowsFormsApp1
{
    partial class ucClientes
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
            this.gbRegistarClientes = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMorada = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.btnRegistarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.gbRegistarClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistarClientes
            // 
            this.gbRegistarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbRegistarClientes.Controls.Add(this.btnRegistarCliente);
            this.gbRegistarClientes.Controls.Add(this.txtNIF);
            this.gbRegistarClientes.Controls.Add(this.txtMorada);
            this.gbRegistarClientes.Controls.Add(this.lblNif);
            this.gbRegistarClientes.Controls.Add(this.lblMorada);
            this.gbRegistarClientes.Controls.Add(this.lblNome);
            this.gbRegistarClientes.Controls.Add(this.txtNome);
            this.gbRegistarClientes.Location = new System.Drawing.Point(80, 37);
            this.gbRegistarClientes.Name = "gbRegistarClientes";
            this.gbRegistarClientes.Size = new System.Drawing.Size(616, 192);
            this.gbRegistarClientes.TabIndex = 1;
            this.gbRegistarClientes.TabStop = false;
            this.gbRegistarClientes.Text = "Registar Clientes";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(125, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblNome.Location = new System.Drawing.Point(59, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblMorada.Location = new System.Drawing.Point(59, 109);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(60, 17);
            this.lblMorada.TabIndex = 3;
            this.lblMorada.Text = "Morada:";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblNif.Location = new System.Drawing.Point(59, 148);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(107, 17);
            this.lblNif.TabIndex = 4;
            this.lblNif.Text = "Número Fiscal:";
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(125, 109);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(123, 20);
            this.txtMorada.TabIndex = 5;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(172, 147);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(123, 20);
            this.txtNIF.TabIndex = 6;
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.Location = new System.Drawing.Point(80, 262);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(494, 264);
            this.lbClientes.TabIndex = 7;
            // 
            // btnRegistarCliente
            // 
            this.btnRegistarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnRegistarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnRegistarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarCliente.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnRegistarCliente.Location = new System.Drawing.Point(410, 63);
            this.btnRegistarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistarCliente.Name = "btnRegistarCliente";
            this.btnRegistarCliente.Size = new System.Drawing.Size(143, 76);
            this.btnRegistarCliente.TabIndex = 7;
            this.btnRegistarCliente.Text = "REGISTAR CLIENTE";
            this.btnRegistarCliente.UseVisualStyleBackColor = false;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnModificarCliente.Location = new System.Drawing.Point(585, 335);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(143, 76);
            this.btnModificarCliente.TabIndex = 8;
            this.btnModificarCliente.Text = "MODIFICAR";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            // 
            // ucClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.gbRegistarClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucClientes";
            this.Size = new System.Drawing.Size(773, 566);
            this.gbRegistarClientes.ResumeLayout(false);
            this.gbRegistarClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistarClientes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.Button btnRegistarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
    }
}
