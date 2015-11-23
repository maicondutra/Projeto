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
    public partial class FNovoCliente : Form
    {
        public FNovoCliente()
        {
            InitializeComponent();
        }

        private int ativo;

        private void btnSalvar_Click(object sender, EventArgs e) 
        {
            string id = FunGer.selectDB("SELECT MAX(id) as id FROM CLIENTES").Rows[0]["id"].ToString();
            if (id == "") { id = "0"; }
            int idconv = Convert.ToInt32(id) + 1;
            bool a = cbxAtivo.Checked;
            if (a) { ativo = 1; } else { ativo = 0; }

            FunGer.inserirDB("CLIENTES", idconv, tbxNome.Text, tbxCPFCNPJ.Text, tbxDataNacimento.Text, tbxTelefone.Text, ativo);

            Close();

        }
    }
}
