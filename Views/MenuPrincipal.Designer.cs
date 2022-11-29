namespace BlitzLogin.Views
{
    partial class MenuPrincipal
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
            this.lblInformacao = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(12, 393);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(226, 16);
            this.lblInformacao.TabIndex = 0;
            this.lblInformacao.Text = "Você está logado como Administrador";
            this.lblInformacao.Click += new System.EventHandler(this.lblInformacao_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(665, 386);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(54, 63);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(654, 42);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos ";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(163, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(452, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Blitz ⚡ Sistemas de Gerenciamento Comandas";
            // 
            // btnComandas
            // 
            this.btnComandas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandas.Location = new System.Drawing.Point(54, 123);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(654, 42);
            this.btnComandas.TabIndex = 4;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = true;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Location = new System.Drawing.Point(54, 188);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(654, 42);
            this.btnCaixa.TabIndex = 5;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(54, 254);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(654, 42);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "Usuários";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlitzLogin.Properties.Resources.BLITZ_1iconeBLCK;
            this.pictureBox1.Location = new System.Drawing.Point(283, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnComandas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInformacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blitz Menu Principal ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}