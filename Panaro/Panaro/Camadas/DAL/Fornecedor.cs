using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Fornecedor
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Fornecedor> Select()
        {
            List<Model.Fornecedor> lstFornecedor = new List<Model.Fornecedor>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from fornecedor;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Fornecedor fornecedor = new Model.Fornecedor();
                    fornecedor.id = Convert.ToInt32(reader["id"]);
                    fornecedor.nome = reader["nome"].ToString();
                    fornecedor.marca = reader["marca"].ToString();
                    fornecedor.endereco = reader["endereco"].ToString();
                    fornecedor.numero = reader["numero"].ToString();
                    fornecedor.produto = reader["produto"].ToString();
                    fornecedor.celular = reader["celular"].ToString();
                    lstFornecedor.Add(fornecedor);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Fornecedor nao localizados");
            }
            finally
            {
                conexao.Close();
            }

            return lstFornecedor;
        }

        public void Insert(Model.Fornecedor fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into fornecedor values ";
            sql = sql + " (@nome, @marca, @endereco, @numero, @produto, @celular);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
            cmd.Parameters.AddWithValue("@marca", fornecedor.marca);
            cmd.Parameters.AddWithValue("@endereco", fornecedor.endereco);
            cmd.Parameters.AddWithValue("@numero", fornecedor.numero);
            cmd.Parameters.AddWithValue("@produto", fornecedor.produto);
            cmd.Parameters.AddWithValue("@celular", fornecedor.celular);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar o fornecedor");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}