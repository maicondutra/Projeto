using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restauradora.NovoCadastro;

namespace Restauradora.CadastroPadraoVisual
{
    public partial class Pedido : CadastroPadrao
    {
        public Pedido()
        {
            InitializeComponent();
            VariaveisIniciais();
        }

        private void VariaveisIniciais()
        {
            dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM PEDIDO WHERE Ativo = 1");

            if (_habilitaBotao)
            {
                pAddCliente.Visible = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoCadastroPadrao._idPadraoTabela = "PEDIDO";
            NovoPedido E = new NovoPedido(this);
            E.Show();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            RemovePadrao("PEDIDO");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrid("PEDIDO");
        }

        private void btnAddPadrao_Click(object sender, EventArgs e)
        {
            //int C = dgvCadastro.CurrentRow.Index;
            //string D = dgvCadastro.Rows[C].Cells[0].Value.ToString();
            //NovoPedido._AddClientePedido = D;
            //Close();
        }
    }
}
