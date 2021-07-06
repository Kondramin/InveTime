namespace InveTime.Services.Interface
{
    interface IAutorisationService
    {
        bool ValidateLoginAndPassword(string login, string password);
    }
}
