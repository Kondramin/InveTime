using InveTime.Commands.Base;
using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.ViewModels.Base;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace InveTime.ViewModels
{
    class AutorisationWindowViewModel : ViewModel
    {
        private readonly IRepository<Employee> _EmployeeRepository;
        



        #region string AutorisationWindow Title  = "Авторизация в системе"

        private string _Title = "Авторизация в системе";
        /// <summary>AutorisationWindow Title</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion


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

            if (!(_EmployeeRepository.Items.Select(p => p.Login).Contains(_LoginTextBox)))
            {
                MessageBox.Show("Не верный логин");
                LoginTextBox = "";
            }
            else if (!(_EmployeeRepository.Items.Where(p => p.Login == _LoginTextBox).Select(p => p.Password).Contains(pwdBox.Password)))
            {
                MessageBox.Show("Не верный пароль");
                pwdBox.Password = "";
            }
        }

        private bool CanAutorisationCommandExequte(object p) => true;

        #endregion

        #endregion




        public AutorisationWindowViewModel(
            IRepository<Employee> EmployeeRepository
            )
        {
            _EmployeeRepository = EmployeeRepository;

            AutorisationCommand = new LambdaCommand(OnAutorisationCommandExequted, CanAutorisationCommandExequte);

            #region Commands



            #endregion


        }
    }
}
