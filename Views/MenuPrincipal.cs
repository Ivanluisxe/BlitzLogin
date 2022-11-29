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
    public partial class MenuPrincipal : Form
    {
        //Usuario global 
        Usuario usuario = new Usuario();
        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();

            lblInformacao.Text = "Você entrou como " + usuario.NomeCompleto;
            this.usuario = usuario;
            //Verificar privilegios do usuário
            if(usuario.Id != 1)
            {
                btnUsuario.Enabled = false;
            }
        }

        private void lblInformacao_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MenuUsuario menuUsuario = new MenuUsuario(usuario);
            menuUsuario.ShowDialog();


        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            MenuProdutos menuProdutos = new MenuProdutos(usuario);
                menuProdutos.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Botão sair 
            Close();
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            MenuComandas menuComandas = new MenuComandas(usuario);
            menuComandas.ShowDialog();
        }
    }
}
