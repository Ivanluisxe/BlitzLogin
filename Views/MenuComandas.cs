using BibliotecaBlitz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlitzLogin.Views
{
    public partial class MenuComandas : Form
    {
        Usuario u;
        public MenuComandas(Usuario usuario)
        {
            InitializeComponent();
            this.u = usuario;
            AtualizarDgv();

        }
        public void AtualizarDgv()
        {
            dgvProduto.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        public void Resetar()
        {
            //Limpar campos
            txbProdutoLancar.Clear();
            txbProduto.Clear();
            txbQtdLancar.Clear();
            txbComanda.Clear();
            //Resetar groupbox
            grbLancar.Enabled = false;
            grbInformacoes.Enabled = true;
        }
        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            //Obter o numero da linha selecionada 
            int LinhaSelecionada = dgvProduto.CurrentCell.RowIndex;
            //Obter toda linha selecionada: 
            var dadosLinha = dgvProduto.Rows[LinhaSelecionada];

            //Popular os campos do editar: 
            txbProdutoLancar.Text = dadosLinha.Cells[1].Value.ToString();
            txbProduto.Text = dadosLinha.Cells[0].Value.ToString();
            txbProdutoLancar.Text += " R$ "+ dadosLinha.Cells[2].Value.ToString();


        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if(txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o numero da comanda!");
            }else if (txbProduto.Text.Length == 0 )
            {
                MessageBox.Show("Informe o código do produto!");
            }
            else
            {
                //Ativar o GRB debaixo:
                grbLancar.Enabled = true;
                //Desativar o GRB atual: 
                grbInformacoes.Enabled = false;
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (txbQtdLancar.Text == "")
            {
                MessageBox.Show("Informe a quantidade de produtos!");
            }else if (int.Parse(txbQtdLancar.Text) < 1)
            {
                MessageBox.Show("Verifique a quantidade informada!");
            }
            else
            {
                //Efetuar o lançamento
                Ordem o = new Ordem();
                o.Quantidade = int.Parse(txbQtdLancar.Text);
                o.IdFicha = int.Parse(txbComanda.Text);
                o.IdProduto = int.Parse(txbProduto.Text);
                o.IdResponsavel = u.Id;

                var r = MessageBox.Show("Você deseja lançar " + o.Quantidade + " unidades de" + txbProdutoLancar.Text + "na comanda" + o.IdFicha + "?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(r == DialogResult.Yes)
                {
                    if(Banco.OrdemDAO.Lancar(o))
                    {
                        MessageBox.Show("O produto foi lançado na comanda!");
                        Resetar();

                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao lançar.");
                    }
                }
                else
                {
                    Resetar();
                }
            }

        }
    }
}
