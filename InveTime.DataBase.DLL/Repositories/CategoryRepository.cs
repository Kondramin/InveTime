using InveTime.DataBase.DLL.Context;
using InveTime.DataBase.DLL.Entityes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InveTime.DataBase.DLL
{
    class CategoryRepository : DbRepository<Category>
    {

        public override IQueryable<Category> Items => base.Items
            .Include(item => item.Products)
            .Include(item => item.CategoriesSearching)
            ;

        public CategoryRepository(InveTimeDB db) : base(db) { }
    }
}
