using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.Services.Interface;
using InveTime.ViewModels.Base;
using System.Security;

namespace InveTime.ViewModels
{
    class AutorisationWindowViewModel : ViewModel
    {
        private readonly IRepository<Employee> _EmployeeRepository;
        //private readonly IPasswordSupplier _PasswordSupplier;



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


        #region SecureString AutorisationWindow PasswordTextBox

        private SecureString _PasswordTextBox;
        /// <summary>AutorisationWindow PasswordTextBox</summary>
        public SecureString PasswordTextBox
        {
            get => _PasswordTextBox;
            set => Set(ref _PasswordTextBox, value);
        }

        #endregion




        public AutorisationWindowViewModel(
            IRepository<Employee> EmployeeRepository
            /*IPasswordSupplier PasswordSupplier*/)
        {
            _EmployeeRepository = EmployeeRepository;
            //_PasswordSupplier = PasswordSupplier;
        }
    }
}
