using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Tipos
    {
        private string strcon = Conexao.getConexao();

        public void Insert(Model.Tipos tipos)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into tipos values ";
            sql = sql + " (@descricao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", tipos.descricao);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar o tipo");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
