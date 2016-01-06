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
    public partial class NovoCadastroPadrao : Form
    {
        private int _ativo;
        public static string _idPadraoTabela = "usuario";

        public NovoCadastroPadrao()
        {
            InitializeComponent();
            IniciaCadastros();
        }

        private void IniciaCadastros()
        {
            tbxCodigo.Text = "";
            tbxCPFCNPJCliente.Text = "";
            tbxDataNacimento.Text = "";
            tbxNome.Text = "";
            tbxTelefoneCliente.Text = "";
            tbxTelefoneFornecedor.Text = "";
            cbxAtivo.Checked = true;
            tbxCodigo.Text = IDPadrao(_idPadraoTabela);
            RetiraPaginas(_idPadraoTabela);
        }

        public void RetiraPaginas(string _tipoCadastroPadrao)
        {
            switch (_tipoCadastroPadrao)
            {
                case "USUARIO":
                    tcPadrao.TabPages.Remove(tpCliente);
                    tcPadrao.TabPages.Remove(tpFornecedor);
                    tcPadrao.TabPages.Remove(tpPedido);
                    tcPadrao.TabPages.Remove(tpProduto);
                    break;
                case "CLIENTE":
                    tcPadrao.TabPages.Remove(tpUsuario);
                    tcPadrao.TabPages.Remove(tpFornecedor);
                    tcPadrao.TabPages.Remove(tpPedido);
                    tcPadrao.TabPages.Remove(tpProduto);
                    tcPadrao.TabPages.Remove(tpPermissoes);
                    break;
                case "PRODUTO":
                    tcPadrao.TabPages.Remove(tpCliente);
                    tcPadrao.TabPages.Remove(tpFornecedor);
                    tcPadrao.TabPages.Remove(tpPedido);
                    tcPadrao.TabPages.Remove(tpUsuario);
                    tcPadrao.TabPages.Remove(tpPermissoes);
                    break;
                case "FORNECEDOR":
                    tcPadrao.TabPages.Remove(tpCliente);
                    tcPadrao.TabPages.Remove(tpUsuario);
                    tcPadrao.TabPages.Remove(tpPedido);
                    tcPadrao.TabPages.Remove(tpProduto);
                    tcPadrao.TabPages.Remove(tpPermissoes);
                    break;
                case "PEDIDO":
                    tcPadrao.TabPages.Remove(tpCliente);
                    tcPadrao.TabPages.Remove(tpFornecedor);
                    tcPadrao.TabPages.Remove(tpPermissoes);
                    tcPadrao.TabPages.Remove(tpProduto);
                    tcPadrao.TabPages.Remove(tpUsuario);
                    break;
                default:
                    break;
            }
        }

        public string IDPadrao(string _tabela)
        {
            string idPadrao = FunGer.selectDB("SELECT MAX(id) as id FROM " + _tabela).Rows[0]["id"].ToString();
            if (idPadrao == "") { idPadrao = "0"; }
            int idconUsu = Convert.ToInt32(idPadrao) + 1;
            return Convert.ToString(idconUsu);
        }

        public void IncluiUsuario()
        {
            try
            {
                bool a = cbxAtivo.Checked;
                if (a) { _ativo = 1; } else { _ativo = 0; }
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

        public void IncluiCliente()
        {
            try
            {
                bool a = cbxAtivo.Checked;
                if (a) { _ativo = 1; } else { _ativo = 0; }
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
                                                       + tbxCPFCNPJCliente.Text + "','"
                                                       + tbxDataNacimento.Text + "','"
                                                       + tbxTelefoneCliente.Text + "','"
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

        public void IncluiProduto()
        {
            try
            {
                bool a = cbxAtivo.Checked;
                if (a) { _ativo = 1; } else { _ativo = 0; }
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
                                                      + tbxValorProduto.Text + "','"
                                                      + DateTime.Now + "')");

                MessageBox.Show("Produto Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void IncluiFornecedor()
        {
            try
            {
                bool a = cbxAtivo.Checked;
                if (a) { _ativo = 1; } else { _ativo = 0; }
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
                                                         + tbxTelefoneFornecedor.Text + "','" 
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
