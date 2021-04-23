using InveTime.DataBase.DLL.Entityes.Base;
using System.Collections.Generic;

namespace InveTime.DataBase.DLL.Entityes
{
    public class Position : NamedEntity
    {
        public int AccessLevel { get; set; }


        public List<Employee> Employees { get; set; }
    }
}
