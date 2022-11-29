using System;
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
    
    public partial class MenuUsuario : Form
    {
        //Global
        Usuario usuario;
        int idselecionado = 0;
        public MenuUsuario(Usuario usuario)
        {
            InitializeComponent();
            //Atribuir o local no global: 
            this.usuario = usuario;
            //Mudar o label 
            lblInformacao.Text = "Você entrou como " + usuario.NomeCompleto;
            AtualizarDgv();
             
            
        }
        public void AtualizarDgv()
        {
            //Carregar os dados do banco no dgv:
            dgvUsuario.DataSource = Banco.UsuarioDAO.ListarTudo();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos estão vazios: 
            if(txbEmailCad.Text.Length > 5 && txbNomeCad.Text.Length > 2 && txbSenhaCad.Text.Length > 3)
            {
                //Instanciar usuario
                Usuario usuario = new Usuario();
                //obter as informações dos campos: 
                usuario.NomeCompleto = txbNomeCad.Text;
                usuario.Email = txbEmailCad.Text;
                usuario.Senha = txbSenhaCad.Text;

                //Enviar para o banco e verificar se deu certo. 
                if(Banco.UsuarioDAO.Cadastrar(usuario))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    txbNomeCad.Clear();
                    txbEmailCad.Clear();
                    txbSenhaCad.Clear();
                    //Atualizar o dgv. 
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.");

                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas");
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar os groupboxes 
            grbEditar.Enabled = true; 
            grbRemover.Enabled = true;

            //Obter o numero da linha selecionada 
            int LinhaSelecionada = dgvUsuario.CurrentCell.RowIndex;
            //Obter toda linha selecionada: 
            var dadosLinha = dgvUsuario.Rows[LinhaSelecionada];

            //Popular os campos do editar: 
            txbNomeEdi.Text = dadosLinha.Cells[1].Value.ToString();
            txbEmailEdi.Text = dadosLinha.Cells[2].Value.ToString();


            //Popular o remover: 
            lblRemover.Text = dadosLinha.Cells[0].Value.ToString() + " - " + dadosLinha.Cells[1].Value.ToString();

            //Salvar o id na variavel global 
            idselecionado = (int)dadosLinha.Cells[0].Value;        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
           var r =  MessageBox.Show("Tem certeza que deseja remover o seguinte usuário \n" +
                "" + lblRemover.Text + "?", "CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r == DialogResult.Yes && idselecionado != 1)
            {
                //Apagar o usuário 
                if(Banco.UsuarioDAO.Remover(idselecionado) != -1 )
                {
                    MessageBox.Show("Usuário removido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Atualizar o dgb
                    AtualizarDgv();
                    //Desativar groupBox:
                    grbEditar.Enabled = false;
                    grbRemover.Enabled = false;

                      
                }
                else 
                {
                    MessageBox.Show("Erro ao remover usuário", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (idselecionado == 1)
            {
                MessageBox.Show("O Administrador não pode ser removido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbEmailEdi.Text.Length > 5 && txbNomeEdi.Text.Length > 2 )
            {
                Usuario usuario = new Usuario();
                usuario.Id = idselecionado;
                usuario.NomeCompleto = txbNomeEdi.Text;
                usuario.Email = txbEmailEdi.Text;
                usuario.Senha = txbSenhaEdi.Text;
                //Chamar o DAO 

                if (Banco.UsuarioDAO.Editar(usuario))
                {
                    MessageBox.Show("Usuário modificado com sucesso!");
                        if(chbSenha.Checked && txbSenhaEdi.Text == "")
                    {
                        MessageBox.Show("A senha não foi modificada.");
                    }
                    txbNomeEdi.Clear();
                    txbEmailEdi.Clear();
                    txbSenhaEdi.Clear();
                    //Atualizar o dgv. 
                    AtualizarDgv();
                    //Desativar groupBox:
                    grbEditar.Enabled = false;
                    grbRemover.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário.");

                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
        }

        private void chbSenha_CheckedChanged(object sender, EventArgs e)
        {
            txbSenhaEdi.Enabled = chbSenha.Checked;
            txbSenhaEdi.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Botão sair 
            Close();
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
