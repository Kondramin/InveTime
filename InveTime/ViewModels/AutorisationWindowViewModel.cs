using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.ViewModels.Base;

namespace InveTime.ViewModels
{
    class AutorisationWindowViewModel : ViewModel
    {
        private readonly IRepository<Employee> _EmployeeRepository;

        
        
        
        #region string AutorisationWindow LoginTextBox

        private string _LoginTextBox;
        /// <summary>AutorisationWindow LoginTextBox</summary>
        public string LoginTextBox
        {
            get => _LoginTextBox;
            set => Set(ref _LoginTextBox, value);
        }

        #endregion


        #region string AutorisationWindow PasswordTextBox

        private string _PasswordTextBox;
        /// <summary>AutorisationWindow PasswordTextBox</summary>
        public string PasswordTextBox
        {
            get => _PasswordTextBox;
            set => Set(ref _PasswordTextBox, value);
        }

        #endregion




        public AutorisationWindowViewModel(IRepository<Employee> EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;
        }
    }
}
