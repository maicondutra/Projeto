using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restauradora.CadastroPadraoVisual;

namespace Restauradora.NovoCadastro
{
    public partial class NovoCadastroPadrao : Form
    {
        private int _ativo;
        private int _idFornecedor;
        public static string _idPadraoTabela = "usuario";
        public static string _AddFornecedorProduto;
        public static string _AddFornecedorProdutoID;

        public NovoCadastroPadrao()
        {
            InitializeComponent();
            IniciaCadastros();
        }

        private void IniciaCadastros()
        {
            tbxCodigo.Text = "";
            tbxCPFCNPJCliente.Text = "";
            tbxNacimentoUsuario.Text = "";
            tbxNomeUsuario.Text = "";
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
                    tcPadrao.TabPages.Remove(tpProduto);
                    tcPadrao.TabPages.Remove(tpVeiculo);
                    break;
                case "CLIENTES":
                    tcPadrao.TabPages.Remove(tpUsuario);
                    tcPadrao.TabPages.Remove(tpFornecedor);
                    tcPadrao.TabPages.Remove(tpProduto);
                    tcPadrao.TabPages.Remove(tpPermissoes);
                    tcPadrao.TabPages.Remove(tpVeiculo);
                    break;
                case "PRODUTO":
                    tcPadrao.TabPages.Remove(tpCliente);
                    tcPadrao.TabPages.Remove(tpFornecedor);
                    tcPadrao.TabPages.Remove(tpUsuario);
                    tcPadrao.TabPages.Remove(tpPermissoes);
                    tcPadrao.TabPages.Remove(tpVeiculo);
                    break;
                case "FORNECEDOR":
                    tcPadrao.TabPages.Remove(tpCliente);
                    tcPadrao.TabPages.Remove(tpUsuario);
                    tcPadrao.TabPages.Remove(tpProduto);
                    tcPadrao.TabPages.Remove(tpPermissoes);
                    tcPadrao.TabPages.Remove(tpVeiculo);
                    break;
                case "VEICULO":
                    tcPadrao.TabPages.Remove(tpCliente);
                    tcPadrao.TabPages.Remove(tpUsuario);
                    tcPadrao.TabPages.Remove(tpProduto);
                    tcPadrao.TabPages.Remove(tpPermissoes);
                    tcPadrao.TabPages.Remove(tpFornecedor);
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
                                                      + tbxNomeUsuario.Text + "','"
                                                      + FunGer.cryptographyPass(tbxSenhaUsuario.Text) + "','"
                                                      + _ativo + "','"
                                                      + tbxEmailUsuario.Text + "','"
                                                      + tbxNacimentoUsuario.Text + "','"
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
                                                       + tbxNomeCliente.Text + "','"
                                                       + tbxCPFCNPJCliente.Text + "','"
                                                       + tbxNacimentoCliente.Text + "','"
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
                                                      + " idfornecedor,"
                                                      + " nome,"
                                                      + " ativo,"
                                                      + " valor,"
                                                      + " datahora) "
                                                      + " VALUES "
                                                      + " ('" 
                                                      + idconPro + "', '"
                                                      + _idFornecedor + "','"
                                                      + tbxNomeProduto.Text + "','"  
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
                                                         + tbxNomeFornecedor.Text + "','" 
                                                         + tbxTelefoneFornecedor.Text + "','" 
                                                         + DateTime.Now + "','" 
                                                         + tbxEmailFornecedor.Text + "')");

                MessageBox.Show("Fornecedor Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void IncluiVeiculo()
        {
            try
            {
                bool a = cbxAtivo.Checked;
                if (a) { _ativo = 1; } else { _ativo = 0; }
                string idVeiculo = FunGer.selectDB("SELECT MAX(id) as id FROM VEICULO").Rows[0]["id"].ToString();
                if (idVeiculo == "") { idVeiculo = "0"; }
                int idconFor = Convert.ToInt32(idVeiculo) + 1;
                // FunGer.inserirDB("CLIENTES", idconv, tbxNome.Text, tbxCPFCNPJ.Text, tbxDataNacimento.Text, tbxTelefone.Text, ativo);  DateTime.Now.ToShortDateString()
                FunGer.ExecutaSQL("INSERT INTO VEICULO ("
                                                         + " id,"
                                                         + " marca,"
                                                         + " categoria,"
                                                         + " descricao,"
                                                         + " ano,"
                                                         + " modelo,"
                                                         + " cor,"
                                                         + " placa,"
                                                         + " chassi,"
                                                         + " renavam,"
                                                         + " ativo,"
                                                         + " datahora) "
                                                         + "VALUES "
                                                         + " ('"
                                                         + idconFor + "', '"
                                                         + tbxMarca.Text + "','"
                                                         + tbxCategoria.Text + "','"
                                                         + tbxDescricao.Text + "','"
                                                         + Convert.ToInt32(tbxAno.Text) + "','"
                                                         + Convert.ToInt32(tbxModelo.Text) + "','"
                                                         + tbxCor.Text + "','"
                                                         + tbxPlaca.Text + "','"
                                                         + tbxChassi.Text + "','"
                                                         + tbxRenavam.Text + "','"
                                                         + _ativo + "','"
                                                         + DateTime.Now + "')");

                MessageBox.Show("Veículo Cadastrado com Sucesso!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Não foi Possível realizar o Cadastro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            CadastroPadrao._habilitaBotao = true;
            Fornecedor B = new Fornecedor();
            B.ShowDialog();
            CadastroPadrao._habilitaBotao = false;
            tbxFornecedorProduto.Text = _AddFornecedorProduto;
            _idFornecedor = Convert.ToInt32(_AddFornecedorProdutoID);
        }
    }
}
