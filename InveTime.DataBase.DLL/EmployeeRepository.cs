using InveTime.DataBase.DLL.Context;
using InveTime.DataBase.DLL.Entityes;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InveTime.DataBase.DLL
{
    class EmployeeRepository : DbRepository<Employee>
    {


        public override IQueryable<Employee> Items => base.Items.Include(item => item.Position);


        public EmployeeRepository(InveTimeDB db) : base(db) { }
        
    }
}
