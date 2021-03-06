using Prism.Commands;
using System;
using System.Windows.Input;

namespace AppDuolingoClone.ViewModels
{
    public class LessonsViewModel :ViewModelBase
    {
        public ICommand NavigateToTrainingCommand { get; private set; }
        public LessonsViewModel()
        {
            NavigateToTrainingCommand = new DelegateCommand(NavigateToTrainingExecute);
        }

        private void NavigateToTrainingExecute()
        {
            System.Diagnostics.Debug.WriteLine("The FAB was selected");
        }
    }
}
