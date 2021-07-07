using InveTime.DataBase.DLL.Entityes;

namespace InveTime.Services.Interface
{
    interface IAutorisationService
    {
        Employee FixedAutorisatedUser(string login, string password);
        bool ValidateLoginAndPassword(string login, string password);
    }
}
