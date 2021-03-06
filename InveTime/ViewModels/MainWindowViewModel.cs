using InveTime.Commands.Base;
using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.ViewModels.Base;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using InveTime.Services;
using InveTime.Services.Interface;
using InveTime.Views.Windows;

namespace InveTime.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        internal static Employee AutorisatedUser;



        #region string MainWindow Title  = "InveTime"

        private string _Title = "InveTime";
        /// <summary>MainWindow Title</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        #region string MainWindow StatusBar Name

        private string _AutorisatedUserName;
        /// <summary>MainWindow StatusBar Name = AutorisatedUser.Name</summary>
        public string AutorisatedUserName
        {
            get => _AutorisatedUserName;
            set => Set(ref _AutorisatedUserName, value);
        }

        #endregion

        #region string MainWindow StatusBar Position.Name

        private string _AutorisatedUserPositionName;
        /// <summary>MainWindow StatusBar Position.Name = AutorisatedUser.Position.Name</summary>
        public string AutorisatedUserPositionName
        {
            get => _AutorisatedUserPositionName;
            set => Set(ref _AutorisatedUserPositionName, value);
        }

        #endregion


        #region Commands



        #region CloseAppCommand

        //public icommand closeappcommand { get; }

        //public bool cancloseappcommandexequte(object p) => true;

        //public void oncloseappcommandexequted(object p)
        //{
        //    application.current.shutdown();
        //}


        #endregion

        #region ReAutorisationCommand

        public ICommand ReAutorisationCommand { get; }

        public bool CanReAutorisationCommandExequte(object p) => true;

        public void OnReAutorisationCommandExequted(object p)
        {   
            var autWindow = new AutorisationWindow();
            autWindow.Show();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = autWindow;
            
        }


        #endregion



        #endregion



        public MainWindowViewModel()
        {
            


            #region Commands

            ReAutorisationCommand = new LambdaCommand(OnReAutorisationCommandExequted, CanReAutorisationCommandExequte);

            #endregion


        }
        //public MainWindowViewModel()
        //{


        //    #region Commands


        //    CloseAppCommand = new LambdaCommand(OnCloseAppCommandExequted, CanCloseAppCommandExequte);


        //    #endregion

        //    string filePath = @"D:\Study\TestList.xlsx";
        //    new ParserService().SaveDataInDataBase(new ParserService().GetDataFromExcel(filePath));






        //}




        //private readonly IRepository<Category> _TypeProductRepository;
        //private readonly IParserService _ParserService;

        //public MainWindowViewModel(IRepository<Category> TypeProductRepository,
        //    IParserService ParserService)
        //{
        //    _TypeProductRepository = TypeProductRepository;
        //    _ParserService = ParserService;
        //    string filePath = @"D:\Study\TestList.xlsx";
        //    ParserService.SaveDataInDataBase(ParserService.GetDataFromExcel(filePath));
        //    var tupeprod = TypeProductRepository.Items.Take(10).ToList();
        //}
    }
}
