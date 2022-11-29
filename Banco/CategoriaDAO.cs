using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlitzLogin.Banco
{
    internal class CategoriaDAO
    {

        public static DataTable ListarTudo()
        {
            string comando = "SELECT id, nome FROM categorias ";

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
    }
}
