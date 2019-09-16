using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AgentAssignment;
using Agents3H.Annotations;

namespace Agents3H
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            agents = new ObservableCollection<Agent>();
            agents.Add(new Agent("001", "Nina", "Assassination", "UpperVolta"));
            agents.Add(new Agent("007", "James Bond", "Martinis", "North Korea"));
            CurrentAgent = agents[0];
        }
        #region Properties




        private ObservableCollection<Agent> agents;
        private Agent currentAgent = null;

        public Agent CurrentAgent
        {
            get { return currentAgent; }
            set
            {
                if (currentAgent != value)
                {
                    currentAgent = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Agent> Agents
        {
            get { return agents; }
        }
        #endregion

        

        #region Methods

        public void AddNewAgent()
        {
            agents.Add(new Agent());
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
