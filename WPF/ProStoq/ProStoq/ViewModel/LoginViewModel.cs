using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.ComponentModel;
using System.IO;

namespace ProStoq.ViewModel
{
    public class LoginViewModel : Window
    {
        public string tbxLogin;
        public string tbxSenha;
        public bool cbxLembrar;

        public bool ValidarUsuarioSenha()
        {
            string login = tbxLogin;
            string senha = FunGer.validCryptographyPass(tbxSenha);
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
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos!", "Verifique os Campos", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Insira Login e Senha!", "Verifique os Campos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

        }

        public void CriaUsuarioAdmin()
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

        public void SalvaUsuario()
        {
            if (cbxLembrar == true)
            {
                ZeraLogin();
                FunGer.ExecutaSQL("UPDATE USUARIO SET lembralogin = 1 WHERE  nome = '" + tbxLogin + "' AND senha = '" + FunGer.cryptographyPass(tbxSenha) + "'");
            }
            else
            {
                ZeraLogin();
            }

        }

        public void LerUsuarioSalvo()
        {
            try
            {
                tbxLogin = FunGer.selectDB("SELECT nome FROM USUARIO WHERE lembralogin = 1").Rows[0]["nome"].ToString();
                cbxLembrar = true;
            }
            catch
            {
                tbxLogin = "";
            }
        }

        private void ZeraLogin()
        {
            FunGer.ExecutaSQL("UPDATE USUARIO SET lembralogin = 0");
        }
    }
}
