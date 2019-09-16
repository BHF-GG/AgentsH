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

namespace Agents3H
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (LbxAgents.SelectedIndex > 0)
                LbxAgents.SelectedIndex--;

        }

        private void BtnForward_Click(object sender, RoutedEventArgs e)
        {
            if (LbxAgents.SelectedIndex < LbxAgents.Items.Count - 1)
                LbxAgents.SelectedIndex++;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as MainWindowViewModel;
            vm.AddNewAgent();
            LbxAgents.SelectedIndex = LbxAgents.Items.Count - 1;
            TbxId.Focus();
        }
    }
}
