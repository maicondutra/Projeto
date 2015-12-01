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
    public partial class FClientes : Form
    {
        public FClientes()
        {
            InitializeComponent();
            dgvClientes.DataSource = FunGer.selectDB("SELECT * FROM CLIENTES WHERE Ativo = 1");
        }

        private void btnAdicionaCliente_Click(object sender, EventArgs e)
        {
            FNovoCliente A = new FNovoCliente();
            A.Show();
           // dgvClientes.DataSource = FunGer.selectDB("SELECT * FROM CLIENTES WHERE Ativo = 1");
        }

        private void btnRemoveCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string idremove = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
                //FunGer.deleteDB("DELETE FROM CLIENTES WHERE id = '" + Convert.ToInt32(idremove) + "'");
                FunGer.ExecutaSQL("UPDATE CLIENTES SET ativo = 0 WHERE id = '" + idremove + "' ");
                dgvClientes.DataSource = FunGer.selectDB("SELECT * FROM CLIENTES WHERE Ativo = 1");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void AtualizaGrid()
        {
            dgvClientes.DataSource = FunGer.selectDB("SELECT * FROM CLIENTES WHERE Ativo = 1");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
}
