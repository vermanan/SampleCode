using System.Windows.Input;
using SampleCode.ViewModels;

namespace SampleCode.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        /// <summary>
        /// Intializes a new instance of the CustomerUpdateCommand class
        /// </summary>
        /// <param name="viewModel"></param>
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        public CustomerViewModel _ViewModel { get; set; }

        #region ICommand Members
        public event System.EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _ViewModel.CanUpdate;
        }

        public void Execute(object? parameter)
        {
            _ViewModel.SaveChanges();
        }

        #endregion
    }
}
