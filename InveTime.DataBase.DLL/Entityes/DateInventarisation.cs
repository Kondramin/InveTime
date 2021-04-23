using InveTime.DataBase.DLL.Entityes.Base;
using System;
using System.Collections.Generic;

namespace InveTime.DataBase.DLL.Entityes
{
    public class DateInventarisation : Entity
    {
        public DateTime InventarisationDate { get; set; }



        public List<Product> Products { get; set; }
    }
}
