using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration.Assemblies;

namespace Restauradora
{
    public partial class Restauradora : Form
    {
        public Restauradora()
        {
            InitializeComponent();
            ConectaDB();
        }

        private MySqlDataAdapter Adapter; // Adapter é a nossa variável que será responsavel por acessar os dados na tabela
        private DataSet DSet;
        private string connectionString = null; // Conection é o nome da variavel de conexao, poderia ser qualquer nome, mas escolhi esse pra facilitar o entendimento

        public void ConectaDB()
        {
            DSet = new DataSet();//define o dataset
            connectionString = GetConnectionString();
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open(); //abre a conexao
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            //verifica se a conexão esta aberta
            if (conexao.State == ConnectionState.Open)
            {
                //cria um adapter usando a instrução SQL para acessar a tabela Clientes
                Adapter = new MySqlDataAdapter("SELECT * FROM CLIENTES", conexao);
                //preenche o dataset via adapter
                Adapter.Fill(DSet, "Cliente");
                //atribui a resultado a propriedade DataSource do DataGrid
                dataGridView1.DataSource = DSet;
                dataGridView1.DataMember = "Cliente";
            }
        }

        public string GetConnectionString()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes A = new Clientes();
            A.Show();
        }
    }
}
