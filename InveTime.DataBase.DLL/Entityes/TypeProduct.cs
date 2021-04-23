using InveTime.DataBase.DLL.Entityes.Base;
using System.Collections.Generic;

namespace InveTime.DataBase.DLL.Entityes
{
    public class TypeProduct : NamedEntity
    {
        public List<Product> Products { get; set; }
    }
}
