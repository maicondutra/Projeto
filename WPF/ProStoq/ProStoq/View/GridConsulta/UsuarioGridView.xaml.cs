using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProStoq.View.NovoCadastro;

namespace ProStoq.View.GridConsulta
{
    /// <summary>
    /// Interaction logic for UsuarioGridView.xaml
    /// </summary>
    public partial class UsuarioGridView : UserControl
    {
        public UsuarioGridView()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            var A = new UsuarioView();
            A.Show();
        }
    }
}
