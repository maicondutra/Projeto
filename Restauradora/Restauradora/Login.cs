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

        public bool logado = false;

        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ValidarUsuarioSenha();
            if (logado)
            {
                this.Dispose();
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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



    }
}
