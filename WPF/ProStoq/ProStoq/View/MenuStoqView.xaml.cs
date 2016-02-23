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
            this.DataContext = this;

            // IniciaTabs();
        }

        #region --- CloseCommand ---

        private Utils.RelayCommand _cmdCloseCommand;
        ///
        /// Returns a command that closes a TabItem.
        ///
        public ICommand CloseCommand
        {
            get
            {
                if (_cmdCloseCommand == null)
                {
                    _cmdCloseCommand = new Utils.RelayCommand(
                        param => this.CloseTab_Execute(param),
                        param => this.CloseTab_CanExecute(param)
                        );
                }
                return _cmdCloseCommand;
            }
        }

        ///
        /// Called when the command is to be executed.
        ///
        /// <param name="parm">
        /// The TabItem in which the Close-button was clicked.
        ///
        private void CloseTab_Execute(object parm)
        {
            TabItem ti = parm as TabItem;
            if (ti != null)
                ti.Items.Remove(parm);
        }

        ///
        /// Called when the availability of the Close command needs to be determined.
        ///
        /// <param name="parm">
        /// The TabItem for which to determine the availability of the Close-command.
        ///
        private bool CloseTab_CanExecute(object parm)
        {
            //For the sample, the closing of TabItems will only be
            //unavailable for disabled TabItems and the very first TabItem.
            TabItem ti = parm as TabItem;
            if (ti != null && ti != tc.Items[0])
                //We have a valid reference to a TabItem, so return
                //true if the TabItem is enabled.
                return ti.IsEnabled;

            //If no reference to a TabItem could be obtained, the command
            //cannot be executed
            return false;
        }

        #endregion


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
