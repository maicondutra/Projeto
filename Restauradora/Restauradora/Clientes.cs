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

            FunGer A = new FunGer();
            //C = A.teste;
            C = A.GetConnectionString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = C;
        }
    }
}
