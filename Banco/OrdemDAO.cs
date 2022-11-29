using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaBlitz;
using MySqlConnector;
using System.Data;
namespace BlitzLogin.Banco
{
    public static class OrdemDAO
    {
        public static bool Lancar(Ordem o)
        {
            string comando = "INSERT INTO ordens_comandas (id_ficha, id_produto, quantidade, id_resp) " +
                "VALUES (@id_ficha, @id_produto, @quantidade, @id_resp)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_ficha", o.IdFicha);
            cmd.Parameters.AddWithValue("@id_produto", o.IdProduto);            
            cmd.Parameters.AddWithValue("@quantidade", o.Quantidade);
            cmd.Parameters.AddWithValue("@id_resp", o.IdResponsavel);

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
