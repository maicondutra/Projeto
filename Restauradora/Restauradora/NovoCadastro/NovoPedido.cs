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
    public partial class NovoPedido : Form
    {
        private CadastroPadrao f;
        public static string _AddClientePedido;
        public static string _AddIdCliente;
        public static string _AddVeiculoPedido;
        public static string _AddIdVeiculo;
        public static string _AddProdutoPedido;
        public static string _AddIdProduto;
        public static bool _AddProduto;

        private int _idItensPedidoDelete;


        public NovoPedido(CadastroPadrao _f)
        {
            InitializeComponent();
            this.f = _f;
            DadosIniciais();
        }

        private void VariaveisIniciais()
        {
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CadastroPadrao._habilitaBotao = true;
            Cliente A = new Cliente();
            A.ShowDialog();
            CadastroPadrao._habilitaBotao = false;
            tbxCliente.Text = _AddClientePedido;
        }

        private void btnAddVeiculo_Click(object sender, EventArgs e)
        {
            CadastroPadrao._habilitaBotao = true;
            Veiculo A = new Veiculo();
            A.ShowDialog();
            CadastroPadrao._habilitaBotao = false;
            tbxVeiculo.Text = _AddVeiculoPedido;
        }

        private void DadosIniciais()
        {
            string id = FunGer.selectDB("SELECT MAX(id) as id FROM PEDIDO").Rows[0]["id"].ToString();
            if (id == "") { id = "0"; }
            int idconv = Convert.ToInt32(id) + 1;
            tbxCodigo.Text = Convert.ToString(idconv);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            CadastroPadrao._habilitaBotao = true;
            Produto D = new Produto();
            D.ShowDialog();
            CadastroPadrao._habilitaBotao = false;
            if (_AddProduto)
            {
                InsereItensPedido();
                dgvPedido.DataSource = FunGer.selectDB("SELECT * FROM ITENSPEDIDO WHERE Ativo = 1 AND idpedido = " + tbxCodigo.Text);
                _AddProduto = false;
            }
        }

        public void InsereItensPedido()
        {
            string id = FunGer.selectDB("SELECT MAX(id) as id FROM ITENSPEDIDO").Rows[0]["id"].ToString();
            if (id == "") { id = "0"; }
            int idconv = Convert.ToInt32(id) + 1;
            _idItensPedidoDelete = idconv;

            int ativo = 1;

            FunGer.ExecutaSQL("INSERT INTO ITENSPEDIDO ( "
                + " id,"
                + " idpedido,"
                + " idproduto,"
                + " descricao,"
                + " ativo,"
                + " datahora "
                + " ) "
                + " VALUES ('"
                + idconv + "','"
                + tbxCodigo.Text + "','"
                + _AddIdProduto + "','"
                + _AddProdutoPedido + "','"
                + ativo + "','"
                + DateTime.Now + "')");
        }

        public void InserePedido()
        {
            int __ativo = 1;

            FunGer.ExecutaSQL("INSERT INTO PEDIDO ( "
                + " id,"
                + " idcliente,"
                + " idveiculo,"
                + " iditenspedido,"
                + " ativo,"
                + " datahora "
                + " ) "
                + " VALUES ('"
                + tbxCodigo.Text + "','"
                + _AddIdCliente + "','"
                + _AddIdVeiculo + "','"
                + __ativo + "','"
                + __ativo + "','"
                + DateTime.Now + "')");
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            InserePedido();
            Close();
            f.AtualizaGrid("PEDIDO");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           // FunGer.ExecutaSQL("DELETE FROM PEDIDO WHERE id = '" + Convert.ToInt32(tbxCodigo.Text) + "'");
            FunGer.ExecutaSQL("DELETE FROM ITENSPEDIDO WHERE idpedido = '" + Convert.ToInt32(tbxCodigo.Text) + "'");
            Close();
            f.AtualizaGrid("PEDIDO");
        }

        private void NovoPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
           // FunGer.ExecutaSQL("DELETE FROM PEDIDO WHERE id = '" + Convert.ToInt32(tbxCodigo.Text) + "'");
           // FunGer.ExecutaSQL("DELETE FROM ITENSPEDIDO WHERE idpedido = '" + Convert.ToInt32(tbxCodigo.Text) + "'");
            f.AtualizaGrid("PEDIDO");
        }
    }
}
