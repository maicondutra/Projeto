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
    public partial class FNovoUsuario : Form
    {
        public FNovoUsuario()
        {
            InitializeComponent();
            limparCampos();
        }

        private int ativo;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = FunGer.selectDB("SELECT MAX(id) as id FROM USUARIO").Rows[0]["id"].ToString();
                if (id == "") { id = "0"; }
                int idconv = Convert.ToInt32(id) + 1;
                bool a = cbxAtivo.Checked;
                if (a) { ativo = 1; } else { ativo = 0; }

                // FunGer.inserirDB("CLIENTES", idconv, tbxNome.Text, tbxCPFCNPJ.Text, tbxDataNacimento.Text, tbxTelefone.Text, ativo);  DateTime.Now.ToShortDateString()
                FunGer.ExecutaSQL("INSERT INTO USUARIO (id,nome,senha,ativo,email,datanacimento,datahora) VALUES " +
                               " ('" + idconv + "', '" + tbxNome.Text + "','" + FunGer.cryptographyPass(tbxSenha.Text) + "','" + ativo + "','" + tbxEmail.Text + "','" + tbxDataNacimento.Text + "','" + DateTime.Now + "')");
                MessageBox.Show("Usuário Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();



                //        this.login = this.txtLogin.Text;
                //        this.senha = cryptographyPass(this.txtSenha.Text);
                //        this.cpf = this.MaskCpf.Text;
                //        this.nome = this.txtNome.Text;
                //        this.flagTipoUser = byte.Parse(this.CbTipoUser.SelectedIndex.ToString());
                //        BD.inserirUsuario(this.getUsuario());
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void limparCampos()
        {
            dgvUsuario.DataSource = FunGer.selectDB("SELECT nome as Nome, email as Email FROM USUARIO WHERE Ativo = 1");
            tbxDataNacimento.Text = "";
            tbxEmail.Text = "";
            tbxNome.Text = "";
            tbxSenha.Text = "";
        }
    }
}
