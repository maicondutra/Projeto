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

        public void ConectaDB()
        {
            DSet = new DataSet();//define o dataset
            MySqlConnection conexao = new MySqlConnection(FunGer.GetConnectionString());

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

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes A = new Clientes();
            A.Show();
        }
    }
}
