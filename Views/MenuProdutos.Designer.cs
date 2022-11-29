namespace BlitzLogin.Views
{
    partial class MenuProdutos
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
            this.grbRemover = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblRemover = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbPrecoEdi = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblPrecoEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.cmbCategoriaCad = new System.Windows.Forms.ComboBox();
            this.pbxIcone = new System.Windows.Forms.PictureBox();
            this.grbRemover.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // grbRemover
            // 
            this.grbRemover.Controls.Add(this.btnRemover);
            this.grbRemover.Controls.Add(this.lblRemover);
            this.grbRemover.Enabled = false;
            this.grbRemover.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRemover.Location = new System.Drawing.Point(334, 487);
            this.grbRemover.Name = "grbRemover";
            this.grbRemover.Size = new System.Drawing.Size(344, 62);
            this.grbRemover.TabIndex = 22;
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
            this.lblRemover.Location = new System.Drawing.Point(6, 27);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(82, 17);
            this.lblRemover.TabIndex = 0;
            this.lblRemover.Text = "ID - NOME ";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbPrecoEdi);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.lblPrecoEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(601, 304);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(364, 151);
            this.grbEditar.TabIndex = 21;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(116, 74);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(234, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbPrecoEdi
            // 
            this.txbPrecoEdi.Location = new System.Drawing.Point(116, 43);
            this.txbPrecoEdi.Name = "txbPrecoEdi";
            this.txbPrecoEdi.Size = new System.Drawing.Size(234, 22);
            this.txbPrecoEdi.TabIndex = 11;
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Location = new System.Drawing.Point(116, 12);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(234, 22);
            this.txbNomeEdi.TabIndex = 10;
            // 
            // lblPrecoEdi
            // 
            this.lblPrecoEdi.AutoSize = true;
            this.lblPrecoEdi.Location = new System.Drawing.Point(6, 46);
            this.lblPrecoEdi.Name = "lblPrecoEdi";
            this.lblPrecoEdi.Size = new System.Drawing.Size(45, 16);
            this.lblPrecoEdi.TabIndex = 8;
            this.lblPrecoEdi.Text = "Preço:";
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Location = new System.Drawing.Point(6, 18);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(45, 16);
            this.lblNomeEdi.TabIndex = 7;
            this.lblNomeEdi.Text = "Nome:";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.cmbCategoriaCad);
            this.grbCadastro.Controls.Add(this.lblCategoriaCad);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbPrecoCad);
            this.grbCadastro.Controls.Add(this.txbNomeCad);
            this.grbCadastro.Controls.Add(this.lblPrecoCad);
            this.grbCadastro.Controls.Add(this.lblNomeCad);
            this.grbCadastro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(43, 304);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(364, 151);
            this.grbCadastro.TabIndex = 20;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Location = new System.Drawing.Point(5, 73);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(66, 16);
            this.lblCategoriaCad.TabIndex = 14;
            this.lblCategoriaCad.Text = "Categoria:";
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
            // txbPrecoCad
            // 
            this.txbPrecoCad.Location = new System.Drawing.Point(116, 43);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(234, 22);
            this.txbPrecoCad.TabIndex = 11;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(116, 15);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(234, 22);
            this.txbNomeCad.TabIndex = 10;
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Location = new System.Drawing.Point(6, 45);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(45, 16);
            this.lblPrecoCad.TabIndex = 8;
            this.lblPrecoCad.Text = "Preço:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 18);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(94, 16);
            this.lblNomeCad.TabIndex = 7;
            this.lblNomeCad.Text = "Nome Produto:";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(43, 58);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(922, 240);
            this.dgvProduto.TabIndex = 19;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(313, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(343, 24);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Blitz ⚡ Gerenciamento de Produtos";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(958, 615);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(7, 625);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(226, 16);
            this.lblInformacao.TabIndex = 16;
            this.lblInformacao.Text = "Você está logado como Administrador";
            // 
            // cmbCategoriaCad
            // 
            this.cmbCategoriaCad.FormattingEnabled = true;
            this.cmbCategoriaCad.Location = new System.Drawing.Point(116, 73);
            this.cmbCategoriaCad.Name = "cmbCategoriaCad";
            this.cmbCategoriaCad.Size = new System.Drawing.Size(234, 24);
            this.cmbCategoriaCad.TabIndex = 15;
            // 
            // pbxIcone
            // 
            this.pbxIcone.Image = global::BlitzLogin.Properties.Resources.BLITZ_1iconeBLCK;
            this.pbxIcone.Location = new System.Drawing.Point(413, 325);
            this.pbxIcone.Name = "pbxIcone";
            this.pbxIcone.Size = new System.Drawing.Size(182, 111);
            this.pbxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIcone.TabIndex = 23;
            this.pbxIcone.TabStop = false;
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 649);
            this.Controls.Add(this.pbxIcone);
            this.Controls.Add(this.grbRemover);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInformacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuProdutos";
            this.grbRemover.ResumeLayout(false);
            this.grbRemover.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRemover;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbPrecoEdi;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblPrecoEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.ComboBox cmbCategoriaCad;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.PictureBox pbxIcone;
    }
}