using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.DAL
{
    public class Usuarios
    {
        private string strcon = Conexao.getConexao();

        public List<Model.Usuarios> Select()
        {
            List<Model.Usuarios> lstUsuarios = new List<Model.Usuarios>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from usuario;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Usuarios usuarios = new Model.Usuarios();
                    usuarios.id = Convert.ToInt32(reader["id"]);
                    usuarios.nome = reader["nome"].ToString();
                    usuarios.usuario = reader["usuario"].ToString();
                    usuarios.senha = reader["senha"].ToString();
                    lstUsuarios.Add(usuarios);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Usuario nao localizados");
            }
            finally
            {
                conexao.Close();
            }

            return lstUsuarios;
        }

        public void Insert(Model.Usuarios usuarios)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Insert into usuario values ";
            sql = sql + " (@nome, @usuario, @senha);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", usuarios.nome);
            cmd.Parameters.AddWithValue("@usuario", usuarios.usuario);
            cmd.Parameters.AddWithValue("@senha", usuarios.senha);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu Erro ao cadastrar o usuario");
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}