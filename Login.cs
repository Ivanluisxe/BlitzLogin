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


namespace BlitzLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text.Length >= 6 && txbSenha.Text.Length >= 1)
            {
                //Fazer validação
                //Instanciar o usuario 
                Usuario usuario = new Usuario();

                //Atribuir os valores dos campos no usuario:
                usuario.Email =txbEmail.Text;
                usuario.Senha =txbSenha.Text;

                //Consultar os dados no banco e obter o resultado em uma tabela 
                DataTable resultado = Banco.UsuarioDAO.Logar(usuario);

                //Verificar se houve resultado na consulta: 
                if(resultado.Rows.Count > 0)
                {
                    //Limpar os campos: 
                    txbEmail.Clear();
                    txbSenha.Clear();

                    //Atribuir os resultados da consulta no objeto usuário:
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    usuario.Id = (int)resultado.Rows[0]["id"];


                    //Ir para o menu principal 
                    Views.MenuPrincipal menuPrincipal = new Views.MenuPrincipal(usuario);
                    //Esconder o form atual 
                    Hide();
                    //Mostrar o menu principal 
                    menuPrincipal.ShowDialog();

                    //Mostrar a tela de login após fechar o menu 
                    Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senhas inválidos!");
                }

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas e tente novamente!");
            }
        }
    }
}
