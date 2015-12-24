using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauradora.Cadastros
{
    public partial class ViewCadastroPadrao : Form
    {
        public static string _tipoCadastro;
        public static string _tipoConexao;
        public static string _tipoSQL;

        private int _ativo;

        public ViewCadastroPadrao()
        {
            InitializeComponent();
            IniciaCadastros();
        }

        public void IniciaCadastros()
        {
            tbxCodigo.Text = "";
            tbxCPFCNPJ.Text = "";
            tbxDataNacimento.Text = "";
            tbxNome.Text = "";
            tbxTelefone.Text = "";

           switch (_tipoCadastro)
            {
                case "novousuario":
                    lblPadrao.Text = "Cadastro de Usuários";
                    break;
                case "novocliente":
                    lblPadrao.Text = "Cadastro de Cliente";
                    break;
                case "novoproduto":
                    lblPadrao.Text = "Cadastro de Produto";
                    break;
                case "novofornecedor":
                    lblPadrao.Text = "Cadastro de Fornecedor";
                    break;
                default:
                    break;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool a = cbxAtivo.Checked;
            if (a) { _ativo = 1; } else { _ativo = 0; }

            switch (_tipoCadastro)
            {
                case "novousuario":
                    IncluiUsuario();
                    break;
                case "novocliente":
                    IncluiCliente();
                    break;
                case "novoproduto":
                    IncluiProduto();
                    break;
                case "novofornecedor":
                    IncluiFornecedor();
                    break;
                default:
                    break;
            }
        }

        private void IncluiUsuario()
        {
            try
            {
                string idUsuario = FunGer.selectDB("SELECT MAX(id) as id FROM USUARIO").Rows[0]["id"].ToString();
                if (idUsuario == "") { idUsuario = "0"; }
                int idconUsu = Convert.ToInt32(idUsuario) + 1;
                // FunGer.inserirDB("CLIENTES", idconv, tbxNome.Text, tbxCPFCNPJ.Text, tbxDataNacimento.Text, tbxTelefone.Text, ativo);  DateTime.Now.ToShortDateString()
                FunGer.ExecutaSQL("INSERT INTO USUARIO ("
                                                      + " id, "
                                                      + " nome,"
                                                      + " senha,"
                                                      + " ativo,"
                                                      + " email,"
                                                      + " datanacimento,"
                                                      + " datahora) "
                                                      + " VALUES "
                                                      + " ('"
                                                      + idconUsu + "', '"
                                                      + tbxNome.Text + "','"
                                                      + FunGer.cryptographyPass(tbxSenha.Text) + "','"
                                                      + _ativo + "','"
                                                      + tbxEmail.Text + "','"
                                                      + tbxDataNacimento.Text + "','"
                                                      + DateTime.Now + "')");

                MessageBox.Show("Usuário Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void IncluiCliente()
        {
            try
            {
                string idCliente = FunGer.selectDB("SELECT MAX(id) as id FROM CLIENTES").Rows[0]["id"].ToString();
                if (idCliente == "") { idCliente = "0"; }
                int idconCli = Convert.ToInt32(idCliente) + 1;
                // FunGer.inserirDB("CLIENTES", idconv, tbxNome.Text, tbxCPFCNPJ.Text, tbxDataNacimento.Text, tbxTelefone.Text, ativo);  DateTime.Now.ToShortDateString()
                FunGer.ExecutaSQL("INSERT INTO CLIENTES ("
                                                       + " id,"
                                                       + " nome,"
                                                       + " cpfcnpj,"
                                                       + " datanacimento,"
                                                       + " telefone,"
                                                       + " datahora,"
                                                       + " ativo) "
                                                       + " VALUES "
                                                       + " ('"
                                                       + idconCli + "', '"
                                                       + tbxNome.Text + "','"
                                                       + tbxCPFCNPJ.Text + "','"
                                                       + tbxDataNacimento.Text + "','"
                                                       + tbxTelefone.Text + "','"
                                                       + DateTime.Now + "','"
                                                       + _ativo + "')");

                MessageBox.Show("Cliente Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
             }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void IncluiProduto()
        {
            try
            {
                string idProduto = FunGer.selectDB("SELECT MAX(id) as id FROM PRODUTO").Rows[0]["id"].ToString();
                if (idProduto == "") { idProduto = "0"; }
                int idconPro = Convert.ToInt32(idProduto) + 1;
                // FunGer.inserirDB("CLIENTES", idconv, tbxNome.Text, tbxCPFCNPJ.Text, tbxDataNacimento.Text, tbxTelefone.Text, ativo);  DateTime.Now.ToShortDateString()
                FunGer.ExecutaSQL("INSERT INTO PRODUTO ("
                                                      + " id,"
                                                      + " nome,"
                                                      + " ativo,"
                                                      + " valor,"
                                                      + " datahora) "
                                                      + " VALUES "
                                                      + " ('" 
                                                      + idconPro + "', '" 
                                                      + tbxNome.Text + "','"  
                                                      + _ativo + "','"
                                                      + tbxValor.Text + "','"
                                                      + DateTime.Now + "')");

                MessageBox.Show("Produto Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void IncluiFornecedor()
        {
            try
            {
                string idFornecedor = FunGer.selectDB("SELECT MAX(id) as id FROM FORNECEDOR").Rows[0]["id"].ToString();
                if (idFornecedor == "") { idFornecedor = "0"; }
                int idconFor = Convert.ToInt32(idFornecedor) + 1;
                // FunGer.inserirDB("CLIENTES", idconv, tbxNome.Text, tbxCPFCNPJ.Text, tbxDataNacimento.Text, tbxTelefone.Text, ativo);  DateTime.Now.ToShortDateString()
                FunGer.ExecutaSQL("INSERT INTO FORNECEDOR ("
                                                         + " id,"
                                                         + " ativo,"
                                                         + " nome,"
                                                         + " telefone,"
                                                         + " datahora,"
                                                         + " email) "
                                                         + "VALUES "
                                                         + " ('" 
                                                         + idconFor + "', '" 
                                                         + _ativo + "','" 
                                                         + tbxNome.Text + "','" 
                                                         + tbxTelefone.Text + "','" 
                                                         + DateTime.Now + "','" 
                                                         + tbxEmail.Text + "')");

                MessageBox.Show("Fornecedor Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
