using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.Services.Interface;
using System;
using System.Linq;
using System.Windows;

namespace InveTime.Services
{
    internal class AutorisationService : IAutorisationService
    {
        private readonly IRepository<Employee> _EmployeeRepository;

        public AutorisationService(IRepository<Employee> employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }

        public bool ValidateLoginAndPassword(string login, string password)
        {
            if (!(_EmployeeRepository.Items.Select(p => p.Login).Contains(login)))
            {
                MessageBox.Show("Не верный логин");
                return false;
            }
            else if (!(_EmployeeRepository.Items.Where(p => p.Login == login).Select(p => p.Password).Contains(password)))
            {
                MessageBox.Show("Не верный пароль");
                return false;
            }
            return true;
        }
    }
}


