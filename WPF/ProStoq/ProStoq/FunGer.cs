using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
//using MySql.Data.MySqlClient;      //Conexão com o MySQL
using Npgsql;                        //Conexão com o PostgreSQL

namespace ProStoq
{
    class FunGer
    {
        #region Consts

            public const string cCliente = "Cliente";
            public const string cVeiculo = "Veículo";
            public const string cFornecedor = "Fornecedor";
            public const string cProduto = "Produto";
            public const string cPedido = "Pedido";
            public const string cNuvem = "Nuvem";
            public const string cUsuario = "Usuário";

        #endregion

        #region conexao MySQL

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

        #endregion

        #region Conexao PostgreSQL

        public static string GetConnectionStringPostgreSQL()
        {
            // Para evitar armazenar a seqüência de conexão em seu código, 
            // Você pode recuperá-lo a partir de um arquivo de configuração, usando o
            // Propriedade System.Configuration.ConfigurationSettings.AppSettings
            // define string de conexao e cria a conexao, string de conexão nada mais é que uma instrução para se conectar ao banco,
            // onde Server é o nome do servidor, nosso caso LocalHost, Database é o nome do banco, uid é o nome do usuário
            // pwd é a sua senha
            return "Server = 127.0.0.1;"
                    + "Port = 5432;"
                    + "Database = restauradb;"
                    + "Password = root;User Id = postgres";
        }

        #endregion

        #region conexao Nuvem

        public static string GetConnectionStringNuvem()
        {
            // Para evitar armazenar a seqüência de conexão em seu código, 
            // Você pode recuperá-lo a partir de um arquivo de configuração, usando o
            // Propriedade System.Configuration.ConfigurationSettings.AppSettings
            // define string de conexao e cria a conexao, string de conexão nada mais é que uma instrução para se conectar ao banco,
            // onde Server é o nome do servidor, nosso caso LocalHost, Database é o nome do banco, uid é o nome do usuário
            // pwd é a sua senha
            return "Data Source=br-cdbr-azure-south-a.cloudapp.net;"
                    + "Initial Catalog=acsm_3205009d9d6fc65;"
                    + "Pwd=16739578;user id=ba6e0c3234645b;"
                    + "Integrated Security=false;"
                    + "connection timeout=10";
        }

        #endregion

        //#region Comandos MySQL

        //public static void ExecutaSQL(string _sql)
        //{
        //    MySqlConnection con = null;
        //    try
        //    {
        //        con = new MySqlConnection(GetConnectionString());
        //        MySqlCommand cmd = new MySqlCommand(_sql, con);

        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        //public static DataTable selectDB(string _sql)
        //{
        //    MySqlConnection con = null;
        //    try
        //    {
        //        string sql = _sql;
        //        con = new MySqlConnection(GetConnectionString());
        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        MySqlDataAdapter da = new MySqlDataAdapter();
        //        da.SelectCommand = cmd;
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //        throw ex;
        //    }
        //}

        //public static DataTable selectDBNuvem(string _sql)
        //{
        //    MySqlConnection con = null;
        //    try
        //    {
        //        string sql = _sql;
        //        con = new MySqlConnection(GetConnectionStringNuvem());
        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        MySqlDataAdapter da = new MySqlDataAdapter();
        //        da.SelectCommand = cmd;
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //        throw ex;
        //    }
        //}

        //public static MySqlDataReader selectDB2(string _sql)
        //{
        //    MySqlConnection con = null;
        //    try
        //    {
        //        string sql = _sql;
        //        con = new MySqlConnection(GetConnectionString());
        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        con.Open();
        //        MySqlDataReader leitor = cmd.ExecuteReader();
        //        return leitor;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //        throw ex;
        //    }
        //}

        //#endregion

        #region Comandos PostgreSQL

        public static void ExecutaSQL(string _sql)
        {
            NpgsqlConnection con = null;
            try
            {
                con = new NpgsqlConnection(GetConnectionStringPostgreSQL());
                NpgsqlCommand cmd = new NpgsqlCommand(_sql, con);

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
            NpgsqlConnection con = null;
            try
            {
                string sql = _sql;
                con = new NpgsqlConnection(GetConnectionStringPostgreSQL());
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
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

        public static DataTable selectDBNuvem(string _sql)
        {
            NpgsqlConnection con = null;
            try
            {
                string sql = _sql;
                con = new NpgsqlConnection(GetConnectionStringNuvem());
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
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

        public static NpgsqlDataReader selectDB2(string _sql)
        {
            NpgsqlConnection con = null;
            try
            {
                string sql = _sql;
                con = new NpgsqlConnection(GetConnectionStringPostgreSQL());
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                con.Open();
                NpgsqlDataReader leitor = cmd.ExecuteReader();
                return leitor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        #endregion

        #region Criptografia

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

        #endregion

        #region SelecionaMaximoID
        public static string SelecionaMaximoID(string _tabela)
        {
            string idPadrao = selectDB("SELECT MAX(id) as id FROM " + _tabela).Rows[0]["id"].ToString();
            if (idPadrao == "") { idPadrao = "0"; }
            int idconUsu = Convert.ToInt32(idPadrao) + 1;
            return Convert.ToString(idconUsu);
        }
        #endregion

        #region Testes de código

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

        #endregion
    }
}
