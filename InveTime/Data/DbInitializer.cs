using InveTime.DataBase.DLL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace InveTime.Data
{
    class DbInitializer
    {
        private readonly InveTimeDB _db;
        private readonly ILogger<InveTimeDB> _logger;

        public DbInitializer(InveTimeDB db, ILogger<InveTimeDB> logger)
        {
            _db = db;
            _logger = logger;
        }

        public async Task InitializeAsync()
        {
            var timer = Stopwatch.StartNew();

            _logger.LogInformation("Удаление существующей бд.....");
            //временно для отладки.
            await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);
            _logger.LogInformation($"Удаление существующей бд выполнено за {0} мс", timer.ElapsedMilliseconds);



            _logger.LogInformation("Начата миграция БД.....");
            await _db.Database.MigrateAsync();
            _logger.LogInformation("Миграция выполнена за {0} мс", timer.ElapsedMilliseconds);
        }
    }
}
