using InveTime.DataBase.DLL.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InveTime.DataBase.DLL.Entityes
{
    class CategorySearchingRepository : DbRepository<CategorySearching>
    {

        public override IQueryable<CategorySearching> Items => base.Items
            .Include(item => item.Category);



        public CategorySearchingRepository(InveTimeDB db) : base(db) { }
    }
}
