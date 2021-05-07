using InveTime.Commands.Base;
using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.ViewModels.Base;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using InveTime.Services;
using InveTime.Services.Interface;

namespace InveTime.ViewModels
{
    class MainWindowViewModel : ViewModel
    {

        #region string MainWindow Title  = "InveTime"

        private string _Title = "InveTime";
        /// <summary>MainWindow Title</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion



        #region Commands

        
        
        #region CloseAppCommand

        public ICommand CloseAppCommand { get; }

        public bool CanCloseAppCommandExequte(object p) => true;

        public void OnCloseAppCommandExequted(object p)
        {
            Application.Current.Shutdown();
        }


        #endregion



        #endregion



        //public MainWindowViewModel()
        //{


        //    #region Commands


        //    CloseAppCommand = new LambdaCommand(OnCloseAppCommandExequted, CanCloseAppCommandExequte);


        //    #endregion

        //    string filePath = @"D:\Study\TestList.xlsx";
        //    new ParserService().SaveDataInDataBase(new ParserService().GetDataFromExcel(filePath));






        //}




        private readonly IRepository<Category> _TypeProductRepository;
        private readonly IParserService _ParserService;

        public MainWindowViewModel(IRepository<Category> TypeProductRepository,
            IParserService ParserService)
        {
            _TypeProductRepository = TypeProductRepository;
            _ParserService = ParserService;
            string filePath = @"D:\Study\TestList.xlsx";
            ParserService.SaveDataInDataBase(ParserService.GetDataFromExcel(filePath));
            var tupeprod = TypeProductRepository.Items.Take(10).ToList();
        }
    }
}
