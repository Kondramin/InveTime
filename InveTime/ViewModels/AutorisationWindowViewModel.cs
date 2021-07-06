using InveTime.Commands.Base;
using InveTime.Services.Interface;
using InveTime.ViewModels.Base;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace InveTime.ViewModels
{
    class AutorisationWindowViewModel : ViewModel
    {   
        private readonly IAutorisationService _AutorisationService;



        #region string AutorisationWindow LoginTextBox

        private string _LoginTextBox;
        /// <summary>AutorisationWindow LoginTextBox</summary>
        public string LoginTextBox
        {
            get => _LoginTextBox;
            set => Set(ref _LoginTextBox, value);
        }

        #endregion



        #region Commands

        #region AutorisationCommand

        public ICommand AutorisationCommand { get; }

        private void OnAutorisationCommandExequted(object p)
        {

            PasswordBox pwdBox = p as PasswordBox;

            if (_AutorisationService.ValidateLoginAndPassword(_LoginTextBox, pwdBox.Password))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Application.Current.MainWindow.Close();
            }
            else
            {
                LoginTextBox = "";
                pwdBox.Password = "";
            }

        }

        private bool CanAutorisationCommandExequte(object p) => true;

        #endregion

        #endregion

        
        
        public AutorisationWindowViewModel(IAutorisationService autorisationService)
        {
            
            _AutorisationService = autorisationService;
            
            
            
            #region Commands

            AutorisationCommand = new LambdaCommand(OnAutorisationCommandExequted, CanAutorisationCommandExequte);

            #endregion

        }
    }
}
