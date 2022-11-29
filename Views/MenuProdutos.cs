using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaBlitz;

namespace BlitzLogin.Views
{
    public partial class MenuProdutos : Form
    {
        int idSelecionado = 0;
        Usuario usuario;
        //Popular o combobox com as categorias 
        
        public MenuProdutos(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblInformacao.Text = "Você entrou como " + usuario.NomeCompleto;

            //Mostrar informações dos produtos no dgv 
            AtualizarDgvProd();
            

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbCategoriaCad.DataSource = rows;
            //cmbCategoriaEdi.DataSource = rows.Clone();
            // Atribuir a tabela de produtos no dgv:
            dgvProduto.DataSource = Banco.ProdutoDAO.ListarTudo();

            
                    /* Ao chamar obterIDdaString("12 - Alimentação")
                * o resultador será 12
                * Show?
                */

            }

      
        //CATEGORIAS 

        private int obterIDdaString(string texto)
        {
            /* Ao chamar obterIDdaString("12 - Alimentação")
             * o resultador será 12
             * Show?
             */
            return int.Parse(texto.Split(' ')[0]);
        }
        public void AtualizarDgvProd()
        {
            //Carregar os dados do banco no dgv:
            dgvProduto.DataSource = Banco.ProdutoDAO.ListarTudo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Botão sair 
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja remover o seguinte produto \n" +
                "" + lblRemover.Text + "?", "CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                //Apagar o produto
                if (Banco.ProdutoDAO.Remover(idSelecionado) != -1)
                {
                    MessageBox.Show("Produto removido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Atualizar o dgb
                    AtualizarDgvProd();
                    //Desativar groupBox:
                    grbEditar.Enabled = false;
                    grbRemover.Enabled = false;


                }
                else
                {
                    MessageBox.Show("Erro ao remover o produto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos estão vazios: 
            if (txbNomeCad.Text.Length > 5 && txbPrecoCad.Text.Length > 2 )
            {
                //Instanciar usuario
                Produto p = new Produto();
                //obter as informações dos campos: 
                p.Nome = txbNomeCad.Text;
                p.Preco = double.Parse(txbPrecoCad.Text);
                p.IdCategoria = 1;
                p.IdRespCadastro = usuario.Id;
                

                //Enviar para o banco e verificar se deu certo. 
                if (Banco.ProdutoDAO.Cadastrar(p))
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    txbNomeCad.Clear();
                    
                   
                    //Atualizar o dgv. 
                    AtualizarDgvProd();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o produto.");

                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas");
            }

        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar os groupboxes 
            grbEditar.Enabled = true;
            grbRemover.Enabled = true;

            //Obter o numero da linha selecionada 
            int LinhaSelecionada = dgvProduto.CurrentCell.RowIndex;
            //Obter toda linha selecionada: 
            var dadosLinha = dgvProduto.Rows[LinhaSelecionada];

            //Popular os campos do editar: 
            txbNomeEdi.Text = dadosLinha.Cells[1].Value.ToString();
            txbPrecoEdi.Text = dadosLinha.Cells[2].Value.ToString();


            //Popular o remover: 
            lblRemover.Text = dadosLinha.Cells[0].Value.ToString() + " - " + dadosLinha.Cells[1].Value.ToString();

            //Salvar o id na variavel global 
            idSelecionado = (int)dadosLinha.Cells[0].Value;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbPrecoEdi.Text.Length > 1 && txbNomeEdi.Text.Length > 2)
            {
                Usuario usuario = new Usuario();
                Produto p = new Produto();

                p.Id = idSelecionado;
                p.Nome = txbNomeEdi.Text;
                p.Preco = double.Parse(txbPrecoEdi.Text);
                p.IdCategoria = 1;
                //Chamar o DAO 

                if (Banco.ProdutoDAO.Editar(p, usuario ))
                {
                    MessageBox.Show("Produto modificado com sucesso!");

                    /*if (chbSenha.Checked && txbEdi.Text == "")
                    {
                        MessageBox.Show("A senha não foi modificada.");
                    }*/

                    txbNomeEdi.Clear();
                    txbPrecoEdi.Clear();
                    
                    //Atualizar o dgv. 
                    AtualizarDgvProd();
                    //Desativar groupBox:
                    grbEditar.Enabled = false;
                    grbRemover.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro ao editar o produto!.");

                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
        }
    }
}



