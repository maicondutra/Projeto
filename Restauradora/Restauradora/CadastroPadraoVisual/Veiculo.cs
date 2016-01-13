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
    public partial class Veiculo : CadastroPadrao
    {
        public Veiculo()
        {
            InitializeComponent();
            VariaveisIniciais();
        }

        private void VariaveisIniciais()
        {
            dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM VEICULO WHERE Ativo = 1");

            if (_habilitaBotao)
            {
                pAddPadrao.Visible = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoCadastroPadrao._idPadraoTabela = "VEICULO";
            NovoVeiculo A = new NovoVeiculo(this);
            A.Show();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            RemovePadrao("VEICULO");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrid("VEICULO");
        }

        private void btnAddPadrao_Click(object sender, EventArgs e)
        {
            int A = dgvCadastro.CurrentRow.Index;
            string B = dgvCadastro.Rows[A].Cells[1].Value.ToString();
            string C = dgvCadastro.Rows[A].Cells[0].Value.ToString();
            NovoPedido._AddVeiculoPedido = B;
            NovoPedido._AddIdVeiculo = C;
            Close();
        }
    }
}
