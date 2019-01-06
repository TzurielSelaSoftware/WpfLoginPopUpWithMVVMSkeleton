using System;
using System.Windows.Input;
namespace WpfLoginPopUpWithMVVMSkeleton.Commands
{
    class DelegateCommand : ICommand
    {
        public Action CommandAction { get; set; }
        public Func<bool> CanExecuteFunc { get; set; }
        public DelegateCommand(Action action)
        {
            CommandAction = action;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object parameter)
        {
            CommandAction();
        }
        public bool CanExecute(object parameter)
        {
            return CanExecuteFunc == null || CanExecuteFunc();
        }
    }
}
