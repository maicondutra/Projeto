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
using System.Windows.Shapes;
using ProStoq.ViewModel;

namespace ProStoq.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginView : LoginViewModel
    {
        public LoginView()
        {
            InitializeComponent();
            IniciaVariaveis();
        }

        private void IniciaVariaveis()
        {
            base.tbxLogin = tbxLogin.Text;
            base.tbxSenha = tbxSenha.Text;
            if(cbxLembrar.IsChecked == true)
            {
                base.cbxLembrar = true;
            }
            else
            {
                base.cbxLembrar = false;
            }
                
        }

        private void lblFechar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLoginSistema_Click(object sender, RoutedEventArgs e)
        {
            ValidarUsuarioSenha();
        }
    }
}
