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

namespace ProStoq.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuStoqView : Window
    {
        public MenuStoqView()
        {
            InitializeComponent();
            IniciaTabs();
        }

        public void IniciaTabs()
        {
            foreach (TabItem item in tbcPadrao.Items)
            {
                    //tbcPadrao.SelectedItem = item;
                    item.Visibility = Visibility.Collapsed;
            }
        }

        private void Cliente_Click(object sender, RoutedEventArgs e)
        {
            foreach (TabItem item in tbcPadrao.Items)
            {
                if (item.Header.Equals("Cliente"))
                {
                    item.Visibility = Visibility.Visible;
                    item.IsSelected = true;
                }
                    
            }
        }

        private void Veiculo_Click(object sender, RoutedEventArgs e)
        {
            ClosableTab theTabItem = new ClosableTab();
            theTabItem.Title = "Small title";
            tbcPadrao.Items.Add(theTabItem);
            theTabItem.Focus();
        }
    }
}
