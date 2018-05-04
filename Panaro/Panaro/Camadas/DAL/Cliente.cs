using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Cliente
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from clientes;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.numero = reader["numero"].ToString();
                    cliente.bairro = reader["bairro"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    cliente.celular = reader["celular"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Clientes nao localizados");
            }
            finally
            {
                conexao.Close();
            }

            return lstCliente;
        }

        public void Insert(Model.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into clientes values ";
            sql = sql + " (@nome, @endereco, @numero, @bairro, @telefone, @celular);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@numero", cliente.numero);
            cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar o cliente");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
