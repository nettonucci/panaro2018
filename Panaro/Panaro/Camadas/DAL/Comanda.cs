using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Comanda
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Comanda> Select()
        {
            List<Model.Comanda> lstComanda = new List<Model.Comanda>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from camadas;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Comanda comanda = new Model.Comanda();
                    comanda.id = Convert.ToInt32(reader["id"]);
                    comanda.cliente = reader["cliente"].ToString();
                    comanda.status = reader["status"].ToString();
                    lstComanda.Add(comanda);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Comandas nao localizados");
            }
            finally
            {
                conexao.Close();
            }

            return lstComanda;
        }

        public void Insert(Model.Comanda comanda)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into comandas values ";
            sql = sql + " (@cliente, @status);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cliente", comanda.cliente);
            cmd.Parameters.AddWithValue("@status", comanda.status);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar a comanda");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
