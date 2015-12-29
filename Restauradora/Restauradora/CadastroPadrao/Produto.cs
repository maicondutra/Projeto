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

namespace Restauradora
{
    public partial class Produto : CadastroPadrao
    {
        public Produto()
        {
            InitializeComponent();
            VariaveisIniciais();
        }

        private void VariaveisIniciais()
        {
            dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM PRODUTO WHERE Ativo = 1");

            if (_habilitaBotao)
            {
                pAddCliente.Visible = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoProduto C = new NovoProduto(this);
            C.Show();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            RemovePadrao("PRODUTO");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrid("PRODUTO");
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
