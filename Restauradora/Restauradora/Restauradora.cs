using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration.Assemblies;

namespace Restauradora
{
    public partial class Restauradora : Form
    {
        public Restauradora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FClientes A = new FClientes();
            A.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNovoUsuario A = new FNovoUsuario();
            A.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Produto A = new Produto();
            A.Show();
        }

        private void btnNuvem_Click(object sender, EventArgs e)
        {
            Nuvem A = new Nuvem();
            A.Show();
        }
    }
}
