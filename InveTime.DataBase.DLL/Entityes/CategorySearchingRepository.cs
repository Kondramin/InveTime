using InveTime.DataBase.DLL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InveTime.DataBase.DLL.Entityes
{
    class CategorySearchingRepository : DbRepository<CategorySearching>
    {

        public override IQueryable<CategorySearching> Items => base.Items
            .Include(item => item.Category);



        public CategorySearchingRepository(InveTimeDB db) : base(db) { }
    }
}
