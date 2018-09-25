using App16ObservColl.Models;
using System;
using System.Windows.Input;

namespace App16ObservColl.ViewModels.Commands
{
    public class Cmd_ADDModelPropsList : ICommand
    {
        public VM_Base_ObsColl ViewModel { get; set; }

        public Cmd_ADDModelPropsList(VM_Base_ObsColl viewModel)
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
            ViewModel.ADDModelPropsList(parameter as Content);
        }
    }
}
