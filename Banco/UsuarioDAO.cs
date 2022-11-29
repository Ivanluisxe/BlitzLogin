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
    public static class UsuarioDAO
    {
        public static DataTable Logar(Usuario u)
        {
            string comando = "SELECT id, nome_completo, email, senha" +
                    " FROM usuarios WHERE email = @email and senha = @senha ";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            //Substituir os "coringas":
            cmd.Parameters.AddWithValue("@email", u.Email);
            //Obter o hash da senha:
            string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(u.Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);

            cmd.Prepare();

            //Declarar tabela que irá receber o resultado: 
            DataTable tabela = new DataTable();
            //preencher a tabela com o resultado da consulta 
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);

            return tabela;
        }
        public static DataTable ListarTudo()
        {
            string comando = "SELECT id, nome_completo, email FROM usuarios ";

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

        public static bool Cadastrar(Usuario u)
        {
            string comando = "INSERT INTO usuarios (nome_completo, email, senha) " +
                "VALUES (@nome_completo, @email, @senha)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_completo", u.NomeCompleto);
            cmd.Parameters.AddWithValue("@email", u.Email);
            //Tirar hash da senha; 
            string senhaHash = EasyEncryption.SHA.ComputeSHA256Hash(u.Senha);
            cmd.Parameters.AddWithValue("@senha", senhaHash);

            cmd.Prepare();

            try
            { 
                if(cmd.ExecuteNonQuery() == 0)
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
            string comando = "DELETE FROM usuarios WHERE id = @id ";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

                        
            cmd.Parameters.AddWithValue("@id", id );

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


        public static bool Editar(Usuario u)
         {
           
            string comando = "UPDATE usuarios SET nome_completo = @nome_completo, email = @email, senha = @senha WHERE id = @id";
            //Caso o usuario não altere a senha 
            if (u.Senha == "")
            {
                comando = "UPDATE usuarios SET nome_completo = @nome_completo, email = @email WHERE id = @id";
            }
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.Parameters.AddWithValue("@nome_completo", u.NomeCompleto);
            cmd.Parameters.AddWithValue("@email", u.Email);

            if(u.Senha != "")
            {
                //Tirar hash da senha; 
                string senhaHash = EasyEncryption.SHA.ComputeSHA256Hash(u.Senha);
                cmd.Parameters.AddWithValue("@senha", senhaHash);
            }
            

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
