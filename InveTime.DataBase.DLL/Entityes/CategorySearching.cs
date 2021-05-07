using InveTime.DataBase.DLL.Entityes.Base;

namespace InveTime.DataBase.DLL.Entityes
{
    public class CategorySearching : NamedEntity
    {

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
