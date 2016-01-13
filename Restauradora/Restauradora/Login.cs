using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Restauradora
{
    public partial class Login : Form
    {

        public bool logado = false;
        public bool clos = false;

        public Login()
        {
            InitializeComponent();
            CriaUsuarioAdmin();
            LerUsuarioSalvo();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ValidarUsuarioSenha();
            if (logado)
            {
                SalvaUsuario();
                this.Dispose();
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clos = true;
            Application.Exit();
        }


        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
           ValidarUsuarioSenha();
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
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    logado = true;
                }
                else
                {                   
                    MessageBox.Show("Usuário ou Senha inválidos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxLogin.Clear();
                    tbxSenha.Clear();
                    tbxLogin.Focus();
                    logado = false;
                }
            }
            else
            {
                MessageBox.Show("Insira Login e Senha!", "Verifique os Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (cbxLembrar.Checked)
            {

                FunGer.ExecutaSQL("UPDATE USUARIO SET lembralogin = 1 WHERE  nome = '" + tbxLogin.Text + "' AND senha = '" + FunGer.cryptographyPass(tbxSenha.Text) + "'");
            }
            else
            {
                FunGer.ExecutaSQL("UPDATE USUARIO SET lembralogin = 0 WHERE  nome = '" + tbxLogin.Text + "' AND senha = '" + FunGer.cryptographyPass(tbxSenha.Text) + "'");
            }

        }

        private void LerUsuarioSalvo()
        {
            //while (FunGer.selectDB2("SELECT nome FROM USUARIO WHERE lembralogin = 1").Read())
            //{
            try 
            {
                tbxLogin.Text = FunGer.selectDB("SELECT nome FROM USUARIO WHERE lembralogin = 1").Rows[0]["nome"].ToString();
                cbxLembrar.Checked = true;
                tbxSenha.Focus();
                tbxSenha.Select();
            }
            catch
            {
                tbxLogin.Text = "";
            }
        }

        //private void CriarCookie(string usuario)
        //{
        //    HttpCookie cookie = new HttpCookie("SITE");
        //    //cria cookie com o ip da maquina
        //    cookie.Values.Add("IP", this.Page.Request.UserHostAddress.ToString());
        //    cookie.Values.Add("USERNAME", usuario);
        //    //colocando o cookie para expirar
        //    cookie.Expires = DateTime.Now.AddDays(365);
        //    this.Page.Response.AppendCookie(cookie);
        //}


        //string temp = Path.GetTempPath();
        //var writer = new StreamWriter(temp + "Usuario.txt");
        //writer.WriteLine(tbxLogin.Text);
        //writer.Close();
        //UsuarioSalvoNaMemoria = true;

        //    break;
        //}
        //if (UsuarioSalvoNaMemoria)
        //{
        //    string temp = Path.GetTempPath();
        //    var reader = new StreamReader(temp + "Usuario.txt");
        //    var fileContents = reader.ReadToEnd();
        //    if (fileContents.Length > 0)
        //    {
        //        cbxLembrar.Checked = true;
        //        tbxLogin.Text = fileContents;
        //    }
        //    else
        //    {
        //        cbxLembrar.Checked = false;
        //        tbxLogin.Text = "";
        //    }
        //    reader.Close();
        //}

    }
}
