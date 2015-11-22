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
    public partial class Clientes : Form
    {
        private string C;

        public Clientes()
        {
            InitializeComponent();
            C = FunGer.GetConnectionString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = C;

            dataGridView1.DataSource = FunGer.selectDB("CLIENTES", "id");
          //  dataGridView1.DataMember = "Cliente";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string id = FunGer.selectDB("CLIENTES", "id").Rows;
            FunGer.inserirDB("CLIENTES", 02,"João","123456789","22311988","123456",1);
        }
    }
}
