using InveTime.Commands.Base;
using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using InveTime.ViewModels.Base;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using InveTime.Services;

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





        public MainWindowViewModel()
        {

            
            #region Commands


            CloseAppCommand = new LambdaCommand(OnCloseAppCommandExequted, CanCloseAppCommandExequte);


            #endregion

            string filePath = @"D:\Study\TestList.xlsx";

            var test = ExeleParser.GetDataFromExcel(filePath);
            var test2 = ExeleParser.GetDataFromExcel(filePath);




        }































        //private readonly IRepository<TypeProduct> _TypeProductRepository;


        //public MainWindowViewModel()
        //{

        //}

        //public MainWindowViewModel(IRepository<TypeProduct> TypeProductRepository)
        //{
        //    _TypeProductRepository = TypeProductRepository;


        //    var tupeprod = TypeProductRepository.Items.Take(10).ToList();
        //}
    }
}
