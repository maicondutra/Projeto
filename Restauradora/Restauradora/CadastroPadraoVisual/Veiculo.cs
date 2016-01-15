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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int _index = dgvCadastro.CurrentRow.Index;

            NovoVeiculo A = new NovoVeiculo(this);
            A.RetiraPaginas("VEICULO");
            A.btnEditar.Visible = true;
            A.cbxAtivo.Checked = true;
            A.tbxCodigo.Text = dgvCadastro.Rows[_index].Cells[0].Value.ToString();

            A.tbxMarca.Text = dgvCadastro.Rows[_index].Cells[1].Value.ToString();
            A.tbxCategoria.Text = dgvCadastro.Rows[_index].Cells[2].Value.ToString();
            A.tbxDescricao.Text = dgvCadastro.Rows[_index].Cells[3].Value.ToString();
            A.tbxAno.Text = dgvCadastro.Rows[_index].Cells[4].Value.ToString();
            A.tbxModelo.Text = dgvCadastro.Rows[_index].Cells[5].Value.ToString();
            A.tbxCor.Text = dgvCadastro.Rows[_index].Cells[6].Value.ToString();
            A.tbxPlaca.Text = dgvCadastro.Rows[_index].Cells[7].Value.ToString();
            A.tbxChassi.Text = dgvCadastro.Rows[_index].Cells[8].Value.ToString();
            A.tbxRenavam.Text = dgvCadastro.Rows[_index].Cells[9].Value.ToString();
            A.Show();
        }
    }
}
