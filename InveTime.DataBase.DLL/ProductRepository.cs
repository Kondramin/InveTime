using InveTime.DataBase.DLL.Context;
using InveTime.DataBase.DLL.Entityes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InveTime.DataBase.DLL
{
    class ProductRepository : DbRepository<Product>
    {


        public override IQueryable<Product> Items => base.Items.Include(item => item.TypeProduct).Include(item => item.DateInventarisation);


        public ProductRepository(InveTimeDB db) : base(db) { }

    }
}
