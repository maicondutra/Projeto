using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauradora
{
    public partial class CadastroPadrao : Form
    {
        public static string _tipoCadastro;
        public static bool _habilitaBotao;

        public CadastroPadrao()
        {
            InitializeComponent();
        }

        public void RemovePadrao(string _tabela)
        {
            try
            {
                //FunGer.deleteDB("DELETE FROM CLIENTES WHERE id = '" + Convert.ToInt32(idremove) + "'");

                string idremove = dgvCadastro.SelectedRows[0].Cells[0].Value.ToString();
                FunGer.ExecutaSQL("UPDATE " + _tabela + " SET ativo = 0 WHERE id = '" + idremove + "' ");
                dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM " + _tabela + " WHERE Ativo = 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void AtualizaGrid(string _tabela)
        {
            dgvCadastro.DataSource = FunGer.selectDB("SELECT * FROM " + _tabela + " WHERE Ativo = 1");
        }

        private void btnAddPadrao_Click(object sender, EventArgs e)
        {
            switch (_tipoCadastro)
            {
                case "novousuario":
                    break;
                case "novocliente":
                    int A = dgvCadastro.CurrentRow.Index;
                    string B = dgvCadastro.Rows[A].Cells[A].Value.ToString();
                    NovoPedido._AddClientePedido = B;
                    Close();
                    break;
                case "novoproduto":
                    int C = dgvCadastro.CurrentRow.Index;
                    string D = dgvCadastro.Rows[C].Cells[0].Value.ToString();
                    NovoPedido._AddClientePedido = D;
                    Close();
                    break;
                case "novofornecedor":
                    break;
                case "novopedido":
                    break;
                default:
                    break;
            }
        }
    }
}
