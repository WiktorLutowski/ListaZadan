using System.Windows.Input;

namespace Lista.Commands
{
    public class RelayCommand(Action commandAction) : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Action commandAction = commandAction;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            commandAction?.Invoke();
        }
    }
}
