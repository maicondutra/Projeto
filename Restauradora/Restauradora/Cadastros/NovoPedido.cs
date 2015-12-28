using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restauradora.Cadastros;
using Restauradora.ViewCadastros;

namespace Restauradora
{
    public partial class NovoPedido : Form
    {
        private ViewPadrao f;
        public static string _AddClientePedido;
        public static string _AddProdutoPedido;


        public NovoPedido(ViewPadrao _f)
        {
            InitializeComponent();
            this.f = _f;
            DadosIniciais();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ViewPadrao._habilitaBotao = true;
            Cliente A = new Cliente();
            A.ShowDialog();
            AddCliente();
        }

        private void DadosIniciais()
        {
            string id = FunGer.selectDB("SELECT MAX(id) as id FROM PEDIDO").Rows[0]["id"].ToString();
            if (id == "") { id = "0"; }
            int idconv = Convert.ToInt32(id) + 1;
            tbxCodigo.Text = Convert.ToString(idconv);
        }

        public void AddCliente()
        {
            tbxCliente.Text = _AddClientePedido;
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ViewPadrao._habilitaBotao = true;
            Produto D = new Produto();
            D.ShowDialog();
            InserePedido();
            dgvPedido.DataSource = FunGer.selectDB("SELECT * FROM ITENSPEDIDO WHERE Ativo = 1");
        }

        public void InserePedido()
        {
            string id = FunGer.selectDB("SELECT MAX(id) as id FROM ITENSPEDIDO").Rows[0]["id"].ToString();
            if (id == "") { id = "0"; }
            int idconv = Convert.ToInt32(id) + 1;

            int ativo = 1;

            FunGer.ExecutaSQL("INSERT INTO ITENSPEDIDO ( "
                + " id,"
                + " idpedido,"
                + " idproduto,"
                + " ativo,"
                + " datahora,"
                + " ) "
                + " VALUES ('"
                + idconv + "',"
                + tbxCodigo.Text + "',"
                + _AddProdutoPedido + "',"
                + ativo + "',"
                + DateTime.Now + "')");
        }
    }
}
