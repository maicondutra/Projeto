using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauradora
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Restauradora A = new Restauradora();
            A.Show();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {

            ValidarUsuarioSenha();
        }


        //rever o codigo e alterar a meu modo
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.login = this.txtLogin.Text;
                this.senha = cryptographyPass(this.txtSenha.Text);
                this.cpf = this.MaskCpf.Text;
                this.nome = this.txtNome.Text;
                this.flagTipoUser = byte.Parse(this.CbTipoUser.SelectedIndex.ToString());

                BD.inserirUsuario(this.getUsuario());
                MessageBox.Show("Usuário Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public string cryptographyPass(string input)
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


        private void ValidarUsuarioSenha()
        {
            string login = txtLogin.Text;
            string senha = validCryptographyPass(txtSenha.Text);

            //Variáveis que serão preenchidas com as informações do banco
            string loginBanco = "";
            string senhaBanco = "";

            //String de Conexão com o banco
            string strConexao = "server=localhost;User Id=root;Persist Security Info=True;database=mercado";

            //Comando que vai ser enviado para o banco
            string comandoConsulta = @"SELECT login, senha FROM usuario WHERE login = @login";

            //Objeto MySqlConnection e MySqlCommand
            MySqlConnection Connection = new MySql.Data.MySqlClient.MySqlConnection(strConexao);
            MySqlCommand objComando = new MySqlCommand(comandoConsulta, Connection);

            //Adicionando o parametro a sua consulta
            objComando.Parameters.Add("@login", MySqlDbType.VarChar).Value = txtLogin.Text;

            //Abre a Conexão
            Connection.Open();

            //Executando o leitor ou melhor, executando o comando MySql no banco
            MySqlDataReader leitor = objComando.ExecuteReader();

            //Lendo as informações do banco
            while (leitor.Read())
            {
                loginBanco = leitor["login"].ToString();
                senhaBanco = leitor["senha"].ToString();
            }

            //Fechando a Conexão
            Connection.Close();

            //Comparando as informações
            if ((login != "") && (senha != ""))
            {
                if ((login == loginBanco) && (senha == senhaBanco))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Clear();
                    txtSenha.Clear();
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Insira Login e Senha!", "Verifique os Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
            }

        }


        public string validCryptographyPass(string input)
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
