using CharityNet.UI.Commands;
using CharityNet.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CharityNet.UI.State.Navigators
{
    public class Navigator : INavigator
    {
        public ViewModelBase CurrentViewModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
