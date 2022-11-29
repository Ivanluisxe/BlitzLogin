namespace BlitzLogin.Views
{
    partial class MenuComandas
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
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.grbLancar = new System.Windows.Forms.GroupBox();
            this.lblQtdLancar = new System.Windows.Forms.Label();
            this.lblProdutoLancar = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.txbProduto = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbProdutoLancar = new System.Windows.Forms.TextBox();
            this.txbQtdLancar = new System.Windows.Forms.TextBox();
            this.btnLancar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(329, 77);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(389, 333);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(137, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(359, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Blitz ⚡ Gerenciamento de Comandas";
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbProduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.lblProduto);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Location = new System.Drawing.Point(13, 86);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(305, 218);
            this.grbInformacoes.TabIndex = 6;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(16, 47);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(114, 24);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(19, 106);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(98, 24);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // grbLancar
            // 
            this.grbLancar.Controls.Add(this.btnLancar);
            this.grbLancar.Controls.Add(this.txbQtdLancar);
            this.grbLancar.Controls.Add(this.txbProdutoLancar);
            this.grbLancar.Controls.Add(this.lblQtdLancar);
            this.grbLancar.Controls.Add(this.lblProdutoLancar);
            this.grbLancar.Enabled = false;
            this.grbLancar.Location = new System.Drawing.Point(13, 416);
            this.grbLancar.Name = "grbLancar";
            this.grbLancar.Size = new System.Drawing.Size(756, 198);
            this.grbLancar.TabIndex = 7;
            this.grbLancar.TabStop = false;
            this.grbLancar.Text = "Lançamentos";
            // 
            // lblQtdLancar
            // 
            this.lblQtdLancar.AutoSize = true;
            this.lblQtdLancar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdLancar.Location = new System.Drawing.Point(12, 98);
            this.lblQtdLancar.Name = "lblQtdLancar";
            this.lblQtdLancar.Size = new System.Drawing.Size(133, 24);
            this.lblQtdLancar.TabIndex = 1;
            this.lblQtdLancar.Text = "Quantidade:";
            // 
            // lblProdutoLancar
            // 
            this.lblProdutoLancar.AutoSize = true;
            this.lblProdutoLancar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLancar.Location = new System.Drawing.Point(38, 51);
            this.lblProdutoLancar.Name = "lblProdutoLancar";
            this.lblProdutoLancar.Size = new System.Drawing.Size(98, 24);
            this.lblProdutoLancar.TabIndex = 0;
            this.lblProdutoLancar.Text = "Produto:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(147, 39);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(100, 38);
            this.txbComanda.TabIndex = 2;
            // 
            // txbProduto
            // 
            this.txbProduto.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProduto.Location = new System.Drawing.Point(147, 99);
            this.txbProduto.Name = "txbProduto";
            this.txbProduto.Size = new System.Drawing.Size(100, 38);
            this.txbProduto.TabIndex = 3;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(84, 161);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(127, 40);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbProdutoLancar
            // 
            this.txbProdutoLancar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutoLancar.Location = new System.Drawing.Point(147, 37);
            this.txbProdutoLancar.Name = "txbProdutoLancar";
            this.txbProdutoLancar.ReadOnly = true;
            this.txbProdutoLancar.Size = new System.Drawing.Size(593, 39);
            this.txbProdutoLancar.TabIndex = 2;
            this.txbProdutoLancar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbQtdLancar
            // 
            this.txbQtdLancar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQtdLancar.Location = new System.Drawing.Point(147, 95);
            this.txbQtdLancar.Name = "txbQtdLancar";
            this.txbQtdLancar.Size = new System.Drawing.Size(593, 38);
            this.txbQtdLancar.TabIndex = 3;
            this.txbQtdLancar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLancar
            // 
            this.btnLancar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(147, 148);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(593, 40);
            this.btnLancar.TabIndex = 5;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // MenuComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 671);
            this.Controls.Add(this.grbLancar);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvProduto);
            this.Name = "MenuComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuComandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancar.ResumeLayout(false);
            this.grbLancar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLancar;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQtdLancar;
        private System.Windows.Forms.TextBox txbProdutoLancar;
        private System.Windows.Forms.Label lblQtdLancar;
        private System.Windows.Forms.Label lblProdutoLancar;
    }
}