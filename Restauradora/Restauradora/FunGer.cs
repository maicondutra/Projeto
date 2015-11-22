using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Restauradora
{
     class FunGer
    {
        public static string GetConnectionString()
        {
            // Para evitar armazenar a seqüência de conexão em seu código, 
            // Você pode recuperá-lo a partir de um arquivo de configuração, usando o
            // Propriedade System.Configuration.ConfigurationSettings.AppSettings
            // define string de conexao e cria a conexao, string de conexão nada mais é que uma instrução para se conectar ao banco,
            // onde Server é o nome do servidor, nosso caso LocalHost, Database é o nome do banco, uid é o nome do usuário
            // pwd é a sua senha
            return "Data Source=localhost;"
                    + "Initial Catalog=restauradb;"
                    + "Pwd=root;user id=root;"
                    + "Integrated Security=false;"
                    + "connection timeout=10";
        }

        public static void inserirDB(string _tabela, int _id, string _nome, string _cpf, string _nacimento, string _telefone, int _ativo)
        {
            MySqlConnection con = null;
            try
            {
                string sql = "INSERT INTO " + _tabela + " (id,nome,cpf,nacimento,telefone,ativo) VALUES (@id,@nome,@cpf,@nacimento,@telefone,@ativo)";
                con = new MySqlConnection(GetConnectionString());
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.Parameters.AddWithValue("@nome", _nome);
                cmd.Parameters.AddWithValue("@cpf", _cpf);
                cmd.Parameters.AddWithValue("@nacimento", _nacimento);
                cmd.Parameters.AddWithValue("@telefone", _telefone);
                cmd.Parameters.AddWithValue("@ativo", _ativo);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        public static void updateDB(string _tabela, int _ID, string _nome, string _nacimento)
        {
            MySqlConnection con = null;
            try
            {
                string sql = "UPDATE " + _tabela + " SET nome= @nome ,preco=@preco WHERE id = @id ";
                con = new MySqlConnection(GetConnectionString());
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", _ID);
                cmd.Parameters.AddWithValue("@nome", _nome);
                cmd.Parameters.AddWithValue("@preco", _nacimento);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        public static void deleteDB(string _tabela, int _ID)
        {
            MySqlConnection con = null;
            try
            {
                string sql = "DELETE FROM " + _tabela + " WHERE id = @id ";
                con = new MySqlConnection(GetConnectionString());
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", _ID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        public static DataTable selectDB(string _tabela, string _campo)
        {
            MySqlConnection con = null;
            try
            {
                string sql = "SELECT " + _campo + " FROM " + _tabela;
                con = new MySqlConnection(GetConnectionString());
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Fill(dt).ToString();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
