using InveTime.Commands.Base;
using System.Windows;

namespace InveTime.Commands
{
    class CloseAppCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
