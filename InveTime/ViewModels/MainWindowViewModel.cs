using InveTime.DataBase.DLL.Entityes;
using InveTime.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveTime.ViewModels
{
    class MainWindowViewModel
    {
        private readonly IRepository<TypeProduct> _TypeProductRepository;

        
        public MainWindowViewModel()
        {

        }

        public MainWindowViewModel(IRepository<TypeProduct> TypeProductRepository)
        {
            _TypeProductRepository = TypeProductRepository;


            var tupeprod = TypeProductRepository.Items.Take(10).ToList();
        }
    }
}
