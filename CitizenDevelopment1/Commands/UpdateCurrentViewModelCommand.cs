using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CitizenDevelopment1.ViewModels;
using CitizenDevelopment1.State.Navigators;


namespace CitizenDevelopment1.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType viewType)
            {
                switch (viewType)
                {
                    case ViewType.Insert:
                        _navigator.CurrentViewModel = new InsertViewModel();
                        break;
                    case ViewType.Update:
                        _navigator.CurrentViewModel = new UpdateViewModel();
                        break;
                    case ViewType.Delete:
                        _navigator.CurrentViewModel = new DeleteViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
