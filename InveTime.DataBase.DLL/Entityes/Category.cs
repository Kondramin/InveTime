using InveTime.DataBase.DLL.Entityes.Base;
using System.Collections.Generic;

namespace InveTime.DataBase.DLL.Entityes
{
    public class Category : NamedEntity
    {
        public List<Product> Products { get; set; }
        public List<CategorySearching> CategoriesSearching { get; set; }
    }
}
