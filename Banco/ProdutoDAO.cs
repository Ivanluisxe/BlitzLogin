using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaBlitz;
using MySqlConnector;

namespace BlitzLogin.Banco
{
    internal class ProdutoDAO
    {

        Usuario u = new Usuario();
        Produto p = new Produto();

        public static DataTable ListarTudo()
        {
           

            string comando = "SELECT * FROM view_produtos ";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Prepare();

            //Declarar tabela que irá receber o resultado: 

            DataTable tabela = new DataTable();
            //preencher a tabela com o resultado da consulta 
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);

            return tabela;
        }

        public static bool Cadastrar(Produto p)
        {
            string comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) " +
                "VALUES (@nome, @preco, @id_categoria, @id_respcadastro)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@preco", p.Preco);
            //Resolver isso depois 
            cmd.Parameters.AddWithValue("@id_categoria", p.IdCategoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", p.IdRespCadastro);

            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }

        public static int Remover(int id)
        {



            //WHERE
            string comando = "DELETE FROM produtos WHERE id = @id ";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@id", id);

            cmd.Prepare();

            try
            {
                int linhasremovidas = cmd.ExecuteNonQuery();
                conexaoBD.Desconectar(con);
                return linhasremovidas;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                //Em caso de erro devolver -1 
                return -1;
            }

        }

        public static bool Editar(Produto p, Usuario u)
        {

            string comando = "UPDATE produtos SET nome = @nome, preco = @preco,  id_respcadastro = @id_respcadastro WHERE id = @id";
            //Caso o usuario não altere a categoria 
            /*if (p.IdCategoria == "")
            {
                comando = "UPDATE usuarios SET nome_completo = @nome_completo, email = @email WHERE id = @id";
            }*/

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@preco", p.Preco);
           // cmd.Parameters.AddWithValue("@id_categoria", p.IdCategoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", u.Id);

            /*if (u.Senha != "")
            {
                //Tirar hash da senha; 
                string senhaHash = EasyEncryption.SHA.ComputeSHA256Hash(u.Senha);
                cmd.Parameters.AddWithValue("@senha", senhaHash);
            }

            */
            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }





    }

    
    
}

