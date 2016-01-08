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
    public partial class Fornecedor : CadastroPadrao
    {
        public Fornecedor()
        {
            InitializeComponent();
            VariaveisIniciais();
        }

        private void VariaveisIniciais()
        {
            dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM FORNECEDOR WHERE Ativo = 1");

            if (_habilitaBotao)
            {
                pAddCliente.Visible = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoCadastroPadrao._idPadraoTabela = "FORNECEDOR";
            NovoFornecedor D = new NovoFornecedor(this);
            D.Show();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            RemovePadrao("FORNECEDOR");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrid("FORNECEDOR");
        }

        private void btnAddPadrao_Click(object sender, EventArgs e)
        {
            int E = dgvCadastro.CurrentRow.Index;
            string F = dgvCadastro.Rows[E].Cells[2].Value.ToString();
            string G = dgvCadastro.Rows[E].Cells[0].Value.ToString();
            NovoCadastroPadrao._AddFornecedorProduto = F;
            NovoCadastroPadrao._AddFornecedorProdutoID = G;
            Close();
        }
    }
}
