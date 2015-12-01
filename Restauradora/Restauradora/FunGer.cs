using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        //public static void inserirDB(string _tabela, int _id, string _nome, string _cpf, string _nacimento, string _telefone, int _ativo)
        //string sql = "INSERT INTO " + _tabela + " (id,nome,cpfcnpj,datanacimento,telefone,ativo) VALUES (@id,@nome,@cpfcnpj,@datanacimento,@telefone,@ativo)";
        //con = new MySqlConnection(GetConnectionString());
        //MySqlCommand cmd = new MySqlCommand(sql, con);
        //cmd.Parameters.AddWithValue("@id", _id);
        //cmd.Parameters.AddWithValue("@nome", _nome);
        //cmd.Parameters.AddWithValue("@cpfcnpj", _cpf);
        //cmd.Parameters.AddWithValue("@datanacimento", _nacimento);
        //cmd.Parameters.AddWithValue("@telefone", _telefone);
        //cmd.Parameters.AddWithValue("@ativo", _ativo);

        public static void ExecutaSQL(string _sql)
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection(GetConnectionString());
                MySqlCommand cmd = new MySqlCommand(_sql, con);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable selectDB(string _sql)
        {
            MySqlConnection con = null;
            try
            {
                string sql = _sql;
                con = new MySqlConnection(GetConnectionString());
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        public static MySqlDataReader selectDB2(string _sql)
        {
            MySqlConnection con = null;
            try
            {
                string sql = _sql;
                con = new MySqlConnection(GetConnectionString());
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader leitor = cmd.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        public static string cryptographyPass(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static string validCryptographyPass(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
