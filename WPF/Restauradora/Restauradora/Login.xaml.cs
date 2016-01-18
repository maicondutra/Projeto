using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Restauradora
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public bool logado = false;
        public bool clos = false;

        public Login()
        {
            InitializeComponent();
            CriaUsuarioAdmin();
            LerUsuarioSalvo();
        }

        private void Fechar_Click(object sender, RoutedEventArgs e)
        {
            clos = true;
            Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            ValidarUsuarioSenha();
            if (logado)
            {
                SalvaUsuario();
                MainWindow A = new MainWindow();
                A.Show();
                this.Close();
            }
        }

        private void ValidarUsuarioSenha()
        {
            string login = tbxLogin.Text;
            string senha = FunGer.validCryptographyPass(tbxSenha.Text);
            string loginBanco = "";
            string senhaBanco = "";

            while (FunGer.selectDB2("SELECT nome FROM USUARIO WHERE nome = '" + login + "' AND senha = '" + senha + "'").Read())
            {
                loginBanco = FunGer.selectDB("SELECT nome FROM USUARIO WHERE nome = '" + login + "' AND senha = '" + senha + "'").Rows[0]["nome"].ToString();
                break;
            }
            while (FunGer.selectDB2("SELECT senha FROM USUARIO WHERE nome = '" + login + "' AND senha = '" + senha + "'").Read())
            {
                senhaBanco = FunGer.selectDB("SELECT senha FROM USUARIO WHERE nome = '" + login + "' AND senha = '" + senha + "'").Rows[0]["senha"].ToString();
                break;
            }


            //Comparando as informações
            if ((login != "") && (senha != ""))
            {
                if ((login == loginBanco) && (senha == senhaBanco))
                {
                    // this.DialogResult = DialogResult.OK;
                    logado = true;            
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos!", "Verifique os Campos", MessageBoxButton.OK, MessageBoxImage.Error);
                    tbxLogin.Clear();
                    tbxSenha.Clear();
                    tbxLogin.Focus();
                    logado = false;
                }
            }
            else
            {
                MessageBox.Show("Insira Login e Senha!", "Verifique os Campos", MessageBoxButton.OK, MessageBoxImage.Warning);
                tbxLogin.Focus();
                logado = false;
            }

        }

        private void CriaUsuarioAdmin()
        {
            bool senhaBanco;
            senhaBanco = FunGer.selectDB2("SELECT id FROM USUARIO").Read();

            if (!senhaBanco)
            {
                string id = FunGer.selectDB("SELECT MAX(id) as id FROM USUARIO").Rows[0]["id"].ToString();
                if (id == "") { id = "0"; }
                int idconv = Convert.ToInt32(id) + 1;

                FunGer.ExecutaSQL("INSERT INTO USUARIO (id,nome,senha,ativo,email,datanacimento,datahora) VALUES ('" + idconv + "','root','" + FunGer.cryptographyPass("root") + "',1,'','','" + DateTime.Now + "')");
            }
        }

        private void SalvaUsuario()
        {
            if (cbxLembrar.IsChecked == true)
            {
                ZeraLogin();
                FunGer.ExecutaSQL("UPDATE USUARIO SET lembralogin = 1 WHERE  nome = '" + tbxLogin.Text + "' AND senha = '" + FunGer.cryptographyPass(tbxSenha.Text) + "'");
            }
            else
            {
                ZeraLogin();
            }

        }

        private void LerUsuarioSalvo()
        {
            try
            {
                tbxLogin.Text = FunGer.selectDB("SELECT nome FROM USUARIO WHERE lembralogin = 1").Rows[0]["nome"].ToString();
                cbxLembrar.IsChecked = true;
                tbxSenha.Focus();
              //  tbxSenha.Select();
            }
            catch
            {
                tbxLogin.Text = "";
            }
        }

        private void ZeraLogin()
        {
            FunGer.ExecutaSQL("UPDATE USUARIO SET lembralogin = 0");
        }
    }
}
