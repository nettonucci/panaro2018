using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Produtos
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Produtos> Select()
        {
            List<Model.Produtos> lstProduto = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from produtos;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produtos produto = new Model.Produtos();
                    produto.id = Convert.ToInt32(reader["id"]);
                    produto.produto = reader["produto"].ToString();
                    produto.descricao = reader["descricao"].ToString();
                    produto.valor = reader["valor"].ToString();
                    produto.quantidade = reader["quantidade"].ToString();
                    lstProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Produtos nao localizados");
            }
            finally
            {
                conexao.Close();
            }

            return lstProduto;
        }

        public void Insert(Model.Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into produtos values ";
            sql = sql + " (@produto, @descricao, @valor, @quantidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@produto", produto.produto);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar o produto");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
