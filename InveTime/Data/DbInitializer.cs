using InveTime.DataBase.DLL.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace InveTime.Data
{
    class DbInitializer
    {
        private readonly InveTimeDB _db;

        public DbInitializer(InveTimeDB db)
        {
            _db = db;
        }

        public async Task InitializeAsync()
        {  
            await _db.Database.MigrateAsync();
        }
    }
}
