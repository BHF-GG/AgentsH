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
using AgentAssignment;

namespace Agents2H
{
    
    public partial class MainWindow : Window
    {
        List<Agent> _agents = new List<Agent>();
        public MainWindow()
        {
            InitializeComponent();
            _agents.Add(new Agent() { ID = "001", CodeName = "Nina", Speciality = "Assassination", Assignment = "Golden Eye" });
            _agents.Add(new Agent("007", "James Bond", "Martinis", "North Korea"));
            GridAgents.DataContext = _agents;
        }
    }
}
