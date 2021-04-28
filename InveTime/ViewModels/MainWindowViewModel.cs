using InveTime.ViewModels.Base;

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
