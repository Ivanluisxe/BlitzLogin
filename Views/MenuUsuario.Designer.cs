namespace BlitzLogin.Views
{
    partial class MenuUsuario
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
            this.btnSair = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbSenhaCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.chbSenha = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenhaEdi = new System.Windows.Forms.TextBox();
            this.txbEmailEdi = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblSenhaEdi = new System.Windows.Forms.Label();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.grbRemover = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblRemover = new System.Windows.Forms.Label();
            this.pbxIcone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(963, 619);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(12, 629);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(226, 16);
            this.lblInformacao.TabIndex = 2;
            this.lblInformacao.Text = "Você está logado como Administrador";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(318, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(348, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Blitz ⚡ Gerenciamento de Usuários ";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToOrderColumns = true;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(48, 62);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(922, 240);
            this.dgvUsuario.TabIndex = 5;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbSenhaCad);
            this.grbCadastro.Controls.Add(this.txbEmailCad);
            this.grbCadastro.Controls.Add(this.txbNomeCad);
            this.grbCadastro.Controls.Add(this.lblSenhaCad);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.lblNomeCad);
            this.grbCadastro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(48, 308);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(364, 151);
            this.grbCadastro.TabIndex = 6;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(116, 107);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(234, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbSenhaCad
            // 
            this.txbSenhaCad.Location = new System.Drawing.Point(116, 73);
            this.txbSenhaCad.Name = "txbSenhaCad";
            this.txbSenhaCad.Size = new System.Drawing.Size(234, 22);
            this.txbSenhaCad.TabIndex = 12;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(116, 43);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(234, 22);
            this.txbEmailCad.TabIndex = 11;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(116, 15);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(234, 22);
            this.txbNomeCad.TabIndex = 10;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(6, 73);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(48, 16);
            this.lblSenhaCad.TabIndex = 9;
            this.lblSenhaCad.Text = "Senha:";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(6, 45);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(44, 16);
            this.lblEmailCad.TabIndex = 8;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 18);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(104, 16);
            this.lblNomeCad.TabIndex = 7;
            this.lblNomeCad.Text = "Nome Completo:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.chbSenha);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbSenhaEdi);
            this.grbEditar.Controls.Add(this.txbEmailEdi);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.lblSenhaEdi);
            this.grbEditar.Controls.Add(this.lblEmailEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(606, 308);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(364, 151);
            this.grbEditar.TabIndex = 14;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // chbSenha
            // 
            this.chbSenha.AutoSize = true;
            this.chbSenha.Checked = true;
            this.chbSenha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSenha.Location = new System.Drawing.Point(116, 69);
            this.chbSenha.Name = "chbSenha";
            this.chbSenha.Size = new System.Drawing.Size(105, 20);
            this.chbSenha.TabIndex = 14;
            this.chbSenha.Text = "Mudar senha ";
            this.chbSenha.UseVisualStyleBackColor = true;
            this.chbSenha.CheckedChanged += new System.EventHandler(this.chbSenha_CheckedChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(116, 118);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(234, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbSenhaEdi
            // 
            this.txbSenhaEdi.Location = new System.Drawing.Point(116, 94);
            this.txbSenhaEdi.Name = "txbSenhaEdi";
            this.txbSenhaEdi.Size = new System.Drawing.Size(234, 22);
            this.txbSenhaEdi.TabIndex = 12;
            // 
            // txbEmailEdi
            // 
            this.txbEmailEdi.Location = new System.Drawing.Point(116, 42);
            this.txbEmailEdi.Name = "txbEmailEdi";
            this.txbEmailEdi.Size = new System.Drawing.Size(234, 22);
            this.txbEmailEdi.TabIndex = 11;
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Location = new System.Drawing.Point(116, 12);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(234, 22);
            this.txbNomeEdi.TabIndex = 10;
            // 
            // lblSenhaEdi
            // 
            this.lblSenhaEdi.AutoSize = true;
            this.lblSenhaEdi.Location = new System.Drawing.Point(6, 94);
            this.lblSenhaEdi.Name = "lblSenhaEdi";
            this.lblSenhaEdi.Size = new System.Drawing.Size(48, 16);
            this.lblSenhaEdi.TabIndex = 9;
            this.lblSenhaEdi.Text = "Senha:";
            // 
            // lblEmailEdi
            // 
            this.lblEmailEdi.AutoSize = true;
            this.lblEmailEdi.Location = new System.Drawing.Point(6, 45);
            this.lblEmailEdi.Name = "lblEmailEdi";
            this.lblEmailEdi.Size = new System.Drawing.Size(44, 16);
            this.lblEmailEdi.TabIndex = 8;
            this.lblEmailEdi.Text = "Email:";
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Location = new System.Drawing.Point(6, 18);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(104, 16);
            this.lblNomeEdi.TabIndex = 7;
            this.lblNomeEdi.Text = "Nome Completo:";
            // 
            // grbRemover
            // 
            this.grbRemover.Controls.Add(this.btnRemover);
            this.grbRemover.Controls.Add(this.lblRemover);
            this.grbRemover.Enabled = false;
            this.grbRemover.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRemover.Location = new System.Drawing.Point(339, 491);
            this.grbRemover.Name = "grbRemover";
            this.grbRemover.Size = new System.Drawing.Size(344, 62);
            this.grbRemover.TabIndex = 15;
            this.grbRemover.TabStop = false;
            this.grbRemover.Text = "Remover";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemover.Location = new System.Drawing.Point(227, 24);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRemover.Location = new System.Drawing.Point(6, 21);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(156, 17);
            this.lblRemover.TabIndex = 0;
            this.lblRemover.Text = "ID - NOME - USUARIO";
            // 
            // pbxIcone
            // 
            this.pbxIcone.Image = global::BlitzLogin.Properties.Resources.BLITZ_1iconeBLCK;
            this.pbxIcone.Location = new System.Drawing.Point(415, 343);
            this.pbxIcone.Name = "pbxIcone";
            this.pbxIcone.Size = new System.Drawing.Size(188, 95);
            this.pbxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIcone.TabIndex = 16;
            this.pbxIcone.TabStop = false;
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 654);
            this.Controls.Add(this.pbxIcone);
            this.Controls.Add(this.grbRemover);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInformacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbRemover.ResumeLayout(false);
            this.grbRemover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbSenhaCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenhaEdi;
        private System.Windows.Forms.TextBox txbEmailEdi;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblSenhaEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.GroupBox grbRemover;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.CheckBox chbSenha;
        private System.Windows.Forms.PictureBox pbxIcone;
    }
}