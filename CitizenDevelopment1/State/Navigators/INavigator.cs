using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenDevelopment1.ViewModels;
using System.Windows.Input;

namespace CitizenDevelopment1.State.Navigators
{
    public enum ViewType
    { 
        Insert,
        Update,
        Delete
    }

    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }

        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
