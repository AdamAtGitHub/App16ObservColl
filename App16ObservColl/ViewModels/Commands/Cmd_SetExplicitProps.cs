using App16ObservColl.Models;
using System;
using System.Windows.Input;

namespace App16ObservColl.ViewModels.Commands
{
    public class Cmd_SetExplicitProps : ICommand
    {
        public VM_Base ViewModel { get; set; }

        public Cmd_SetExplicitProps(VM_Base viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.SetExplicitProps(parameter as String);
        }
    }
}
