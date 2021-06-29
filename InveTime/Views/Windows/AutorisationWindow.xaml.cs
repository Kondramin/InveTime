using InveTime.Services.Interface;
using System.Windows;

namespace InveTime.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorisationWindow.xaml
    /// </summary>
    public partial class AutorisationWindow : Window , IPasswordSupplier
    {
        public AutorisationWindow()
        {
            InitializeComponent();
        }

        public string GetPassword()
        {
            return pwdBox.Password;
        }
    }
}
