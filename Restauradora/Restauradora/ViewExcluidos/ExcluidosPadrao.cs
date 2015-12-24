using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauradora.ViewExcluidos
{
    public partial class ExcluidosPadrao : Form
    {
        public static string _tipoSQL;

        public ExcluidosPadrao()
        {
            InitializeComponent();
            dgvPadrao.DataSource = FunGer.selectDB(_tipoSQL);
        }
    }
}
