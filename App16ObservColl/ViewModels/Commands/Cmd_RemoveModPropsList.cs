using App16ObservColl.Models;
using System;
using System.Windows.Input;

namespace App16ObservColl.ViewModels.Commands
{
    public class Cmd_RemoveModPropsList : ICommand
    {
        public VM_Base_ObsColl ViewModel { get; set; }

        public Cmd_RemoveModPropsList(VM_Base_ObsColl viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //if (parameter != null)
            //{
            //    var s = parameter as String;
            //    s = s.Trim();
            //    if (String.IsNullOrEmpty(s))   
            //        return false;

            //    return true;
            //}
            //return false;
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.RemoveModPropsList(parameter as Content);         
        }
    }
}
