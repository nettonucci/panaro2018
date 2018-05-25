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

        public List<Model.Produtos> SelectById(int id)
        {
            List<Model.Produtos> lstProduto = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from produtos where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
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

        public List<Model.Produtos> SelectByNome(string descricao)
        {
            List<Model.Produtos> lstProduto = new List<Model.Produtos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from produtos where (descricao like @descricao);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", descricao.Trim() + "%");
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

        public void Update(Model.Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Update produtos set quantidade=@quantidade, valor=@valor where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            cmd.Parameters.AddWithValue("@id", produto.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualizacao de produtos");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Model.Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Delete from produtos where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro na remocao de produto");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
